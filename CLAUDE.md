# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Tổng quan

Đồ án 2: ứng dụng desktop luyện thi TOEIC (WinForms, C#, .NET Framework 4.7.2) với SQL Server. Người dùng chọn đề ETS → chọn Part → làm bài (có audio/hình) → xem kết quả, xem lại, lịch sử, thống kê. Admin quản lý ETS/Test/Group/Question/Answer/tài khoản và xem thống kê.

Code, comment, chuỗi giao diện và thông báo lỗi đều bằng tiếng Việt; giữ nguyên quy ước này khi viết code mới.

Cấu trúc thư mục gốc:
- `Project/TOEIC_Practice/` – solution chính (`TOEIC_Practice.slnx`).
- `Project/CSDL/CSDL_TOEIC_PracticeDB.sql` – toàn bộ schema, stored procedure và dữ liệu seed.
- `Audio/`, `Images/` – file nguồn thô của đề (theo `2024/TEST_x/PART_y`). Ứng dụng **không** đọc từ đây.
- Các file `.docx`/`.pdf` – báo cáo và sơ đồ (BFD, Class, ERD, Use Case), không phải code.

Repo GitHub: https://github.com/phuc220246/TOEIC-software-DA2 (nhánh `main`); `.gitignore` bỏ qua `bin/`, `obj/`, `.vs/`. Không có project test, không có lint.

## Build & chạy

Có Visual Studio 18 (2026) Community; `.slnx` cần MSBuild của VS mới (không dùng `dotnet build` vì là project .NET Framework kiểu cũ có COM reference).

```powershell
& "C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe" "Project\TOEIC_Practice\TOEIC_Practice.slnx" /t:Build /p:Configuration=Debug /v:minimal
```

Chạy: `Project\TOEIC_Practice\TOEIC_Practice.GUI\bin\Debug\TOEIC_Practice.GUI.exe` (form đầu tiên là `FrmDangNhap`).

Các cảnh báo MSB3305 về `WMPLib` (Windows Media Player COM, dùng để phát audio) là bình thường.

## Cơ sở dữ liệu

- Chuỗi kết nối tên `ToeicDb` trong `TOEIC_Practice.GUI/App.config` (SQL Server instance `DESKTOP-GKQID4P\BUDDHA`, DB `TOEIC_PracticeDB`, Windows auth). `DataHelper` có chuỗi fallback hard-code giống hệt — đổi máy thì sửa cả hai.
- `sqlcmd` có sẵn trên máy, ví dụ: `sqlcmd -S "DESKTOP-GKQID4P\BUDDHA" -E -d TOEIC_PracticeDB -Q "EXEC dbo.sp_Part_List"`.
- File `CSDL_TOEIC_PracticeDB.sql` là script tích lũy, chỉ chạy được trọn vẹn **một lần** trên DB trống: phần đầu dùng `CREATE TABLE`/`CREATE PROCEDURE` không có guard, các phần sau là `ALTER TABLE` bổ sung (cột `IsActive`/`UpdatedAt`, sửa constraint, mở rộng `GroupType`) và SP admin dùng `CREATE OR ALTER`. Khi sửa/thêm SP: chạy riêng khối đó lên DB **và** cập nhật lại vào file script để hai nơi đồng bộ.
- Tài khoản mẫu `admin` (role Admin) và `user1` (role User) được tạo tự động lúc mở `FrmDangNhap` (`EnsureSampleAccountsIfEmpty`) nếu chưa tồn tại; script SQL chỉ seed Role và Part, không seed tài khoản (mật khẩu là hash PBKDF2 + salt sinh từ `BLL/Security/PasswordHelper.cs`, nên không thể INSERT tài khoản trực tiếp bằng SQL).

### Mô hình dữ liệu chính

- Ngân hàng đề: `EtsSet` (theo năm) → `Test` → `QuestionGroup` (thuộc 1 `Part`, `GroupType` = SINGLE/CONVERSATION/PASSAGE/SINGLE_/DOUBLE_/TRIPLE_PASSAGE, chứa `AudioPath`/`ImagePath`/`PassageText`) → `Question` → `Answer` (`IsCorrect`, tối đa 1 đáp án đúng/câu). `GroupPassage` chứa nhiều đoạn văn cho Part 7. `QuestionOption` là nhãn A/B/C/D mặc định.
- Xóa là **xóa mềm**: các SP `sp_Admin_*_Deactivate` set `IsActive = 0`.
- Làm bài: `sp_Attempt_Start` tạo `Attempt` + `AttemptQuestion` (giữ nguyên thứ tự đề, không trộn câu) rồi gọi `sp_Attempt_GenerateOptions` để **trộn đáp án** và lưu snapshot vào `AttemptOption` riêng cho từng lần làm. `AttemptAnswer` lưu nhãn người dùng chọn (`ChosenOptionLabel`), map ngược về `AnswerId` qua `AttemptOption`. `sp_Attempt_Submit` tính đúng/sai/bỏ qua vào `Attempt` và `AttemptSectionTime` (Listening = Part 1–4, Reading = Part 5–7). Xem lại/lịch sử phải đọc qua `AttemptOption`, không dùng `QuestionOption`.

## Kiến trúc 3 lớp

Bốn project, phụ thuộc một chiều: `GUI → BLL → DAL → DTO` (GUI tham chiếu cả DAL và DTO).

- **DAL** – chỉ gọi stored procedure qua singleton `DAL/Helpers/DataHelper.Instance` (`ExecuteQuerySP` / `ExecuteNonQuerySP` / `ExecuteScalarSP`, và `ExecuteInTransaction` truyền `conn, tran` cho các overload tương ứng). DAL trả `DataTable` thô; không viết SQL text trong code (`ExecuteQueryText` chỉ để debug).
- **BLL** – validate đầu vào, ném `Exception` với thông báo tiếng Việt, chuyển `DataRow` thành DTO, gom nhóm dữ liệu (ví dụ `AttemptBLL.GetQuestionList` trả danh sách câu + `optionsMap` theo `AttemptQuestionId`; `GetPart7Groups` gom câu theo `GroupId` kèm passage).
- **DTO** – mỗi DTO có constructor nhận `DataRow`, dùng `row.Table.Columns.Contains(...)` để chịu được việc SP trả thiếu cột. `DTO/Session.cs` là trạng thái đăng nhập tĩnh (`AccountId`, `Roles`, `IsAdmin`, `IsUser`) dùng toàn ứng dụng.
- **GUI** – form `Frm*` + user control `Uc*`. Lỗi từ BLL được bắt và hiện bằng `MessageBox`.

Các project BLL/DAL/DTO được chia thư mục và namespace theo nghiệp vụ, giống nhau giữa các lớp: `Admin`, `LamBai` (làm bài, lịch sử, xem lại), `NoiDungDe` (ETS/Test/Part), `TaiKhoan`, `ThongKe`. Thêm tính năng thì tạo bộ `XxxDAL` / `XxxBLL` / `XxxDTO` cùng thư mục tương ứng.

**Lưu ý csproj kiểu cũ (non-SDK):** file `.cs` mới phải được thêm `<Compile Include=...>` vào `.csproj` (form/UC cần thêm cả `SubType` và `DependentUpon` cho `.Designer.cs`/`.resx`), nếu không sẽ không được build.

### Luồng giao diện

- `FrmDangNhap` → nếu `Session.IsAdmin` mở `FrmAdminMain`, ngược lại mở `FrmMain`.
- `FrmMain` (người dùng) là màn hình chính: chọn ETS/Test, chọn Part (`FrmChonPart`) và giới hạn thời gian, gọi `AttemptBLL.StartAttempt` rồi mở `FrmLamBai(attemptId)`; lịch sử và thống kê cũng nằm trong `FrmMain`, mở `FrmXemLai` để xem lại. `FrmChonDe`, `FrmLichSu`, `FrmThongKeNguoiDung` hiện không được form nào khởi tạo.
- `FrmLamBai` render theo từng Part vào `flpNoiDung`: Part 1 `UcP1_SingleQuestion`, Part 2 `UcP2_SingleQuestion`, Part 3/4 `UcPart3Group` (bên trong dùng `UcChoiceQuestion`), Part 5 `UcP5_SingleQuestion`, Part 6 `UcPassageBlock` + `UcP5_SingleQuestion`, Part 7 `UcPart7Group`. Mỗi lần chọn đáp án lưu ngay qua `sp_Attempt_SaveAnswer`; khi đổi Part phải dừng audio đang phát (`StopAllMediaInCurrentScreen`). Nộp bài → `FrmKetQua` → `FrmXemLai` (dùng các `UcReview_*`).
- `FrmAdminMain` nhúng form con qua `OpenChildForm` (`FrmAdminStats`, `FrmAdminEts`, `FrmAdminTest`, `FrmAdminGroup`, `FrmAdminQuestion`, `FrmAdminAccount`).

### File media (audio/hình)

- DB lưu đường dẫn tương đối theo Part, ví dụ `Part1/2024_T1_P1_Q1.mp3` (quy ước tên `{Năm}_T{Test}_P{Part}_Q{số câu}`; nhóm nhiều câu dùng `Q32_33_34`).
- `GUI/MediaPathHelper` ghép thành `Application.StartupPath\Assets\Audio|Images\...` (tức là trong `bin\Debug\Assets`). File gốc nằm ở `TOEIC_Practice.GUI/Assets/` và chỉ được copy ra bin nếu được khai báo `<Content Include=... CopyToOutputDirectory>` trong `TOEIC_Practice.GUI.csproj` — thêm media mới vào source thì phải khai báo ở đó.
- Upload media trong `FrmAdminGroup` (`MediaStorageHelper`) copy file vào thư mục `Assets` **bên trong bin**, không vào source; các file này sẽ mất nếu clean/đổi cấu hình build.
- Các helper media nằm trong project GUI nhưng có namespace `TOEIC_Practice.Helpers` (không phải `TOEIC_Practice.GUI`).
