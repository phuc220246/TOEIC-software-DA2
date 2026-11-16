# Hệ thống ôn luyện TOEIC (TOEIC Practice)

Ứng dụng desktop hỗ trợ luyện thi TOEIC theo cấu trúc đề 7 part, kèm công cụ quản trị ngân hàng đề và tài khoản người dùng.

Đồ án chuyên ngành 2 – Ngành Kỹ thuật Phần mềm, Khoa Công nghệ Thông tin, Trường Đại học Nam Cần Thơ.

- Sinh viên thực hiện: Nguyễn Tòng Phúc – 220246
- Giảng viên hướng dẫn: Lê Thanh Trúc

## Tính năng

### Người dùng

- **Đăng nhập**, hệ thống tự phân quyền và mở giao diện phù hợp (người dùng / quản trị viên).
- **Chọn đề và phần thi**: chọn bộ ETS, bài test, làm toàn bộ hoặc chỉ một số part; chọn giới hạn thời gian (không giới hạn, 120, 60, 45, 30 hoặc 15 phút).
- **Làm bài Part 1 – Part 7**: nghe audio, xem hình, đọc đoạn văn (Part 6, Part 7 nhiều đoạn). Đáp án được lưu ngay khi chọn.
- **Trộn đáp án**: thứ tự câu hỏi giữ nguyên như đề thật, chỉ các lựa chọn A/B/C/D được trộn riêng cho mỗi lần làm.
- **Nộp bài và chấm điểm tự động**: số câu đúng, sai, bỏ qua và thời gian làm bài.
- **Xem lại bài làm**: đối chiếu đáp án đã chọn với đáp án đúng, xem giải thích.
- **Lịch sử làm bài** và **thống kê cá nhân** (tổng quan, theo part, theo test, các lần làm gần đây).

### Quản trị viên

- **Quản lý tài khoản**: thêm, sửa, tìm kiếm, khóa/mở khóa, đặt lại mật khẩu, phân quyền.
- **Quản lý ngân hàng đề**: bộ ETS → bài test → nhóm câu hỏi → câu hỏi → đáp án và nhãn A/B/C/D. Xóa dữ liệu là xóa mềm (ngừng kích hoạt).
- **Quản lý media**: chọn file audio/hình cho nhóm câu hỏi, file được chép vào thư mục `Assets` của ứng dụng.
- **Thống kê hệ thống**: số tài khoản, lượt làm bài, độ chính xác theo part, theo test và theo từng người dùng.

## Công nghệ

- C#, Windows Forms, .NET Framework 4.7.2
- SQL Server (toàn bộ truy vấn qua stored procedure, ADO.NET)
- Kiến trúc 3 lớp: GUI – BLL – DAL, cùng project DTO dùng chung
- Windows Media Player (COM `WMPLib`) để phát audio
- Mật khẩu được băm bằng PBKDF2 (100.000 vòng lặp) kèm salt ngẫu nhiên

## Cấu trúc thư mục

```
├── Project/
│   ├── CSDL/
│   │   └── CSDL_TOEIC_PracticeDB.sql    # Schema, stored procedure, dữ liệu mẫu
│   └── TOEIC_Practice/
│       ├── TOEIC_Practice.slnx          # Solution
│       ├── TOEIC_Practice.GUI/          # Form, user control, Assets (audio/hình)
│       ├── TOEIC_Practice.BLL/          # Xử lý nghiệp vụ, băm mật khẩu
│       ├── TOEIC_Practice.DAL/          # Gọi stored procedure (DataHelper)
│       └── TOEIC_Practice.DTO/          # Đối tượng dữ liệu, Session đăng nhập
├── Audio/, Images/                      # File gốc của đề (theo năm/test/part)
├── Báo Cáo Đồ Án 2.docx / .pdf          # Báo cáo đồ án
└── SƠ ĐỒ *.docx                         # Sơ đồ BFD, Class, ERD, Use Case
```

Các project BLL, DAL, DTO chia thư mục theo nghiệp vụ: `Admin`, `LamBai` (làm bài, lịch sử, xem lại), `NoiDungDe` (ETS, test, part), `TaiKhoan`, `ThongKe`.

## Cài đặt và chạy

### 1. Yêu cầu

- Windows có Windows Media Player (bản Windows "N" cần cài thêm Media Feature Pack)
- Visual Studio 2026 (hoặc bản Visual Studio hỗ trợ file `.slnx`) với workload **.NET desktop development**
- .NET Framework 4.7.2 Developer Pack
- SQL Server và SQL Server Management Studio (SSMS) hoặc `sqlcmd`

### 2. Tạo cơ sở dữ liệu

Chạy toàn bộ file `Project/CSDL/CSDL_TOEIC_PracticeDB.sql` **một lần** trên SQL Server. Script tự tạo database `TOEIC_PracticeDB`, các bảng, stored procedure và dữ liệu mẫu (Role, 7 Part, một số câu hỏi mẫu Part 1 – Part 7).

Dùng SSMS: mở file và nhấn Execute. Hoặc dùng `sqlcmd` (thay `TEN_MAY\TEN_INSTANCE` bằng server của bạn):

```bash
sqlcmd -S "TEN_MAY\TEN_INSTANCE" -E -f 65001 -i "Project/CSDL/CSDL_TOEIC_PracticeDB.sql"
```

Script được viết để chạy trên database trống; chạy lại lần hai sẽ báo lỗi do bảng và procedure đã tồn tại.

### 3. Cấu hình chuỗi kết nối

Sửa `Data Source` trong `Project/TOEIC_Practice/TOEIC_Practice.GUI/App.config` cho đúng tên SQL Server của bạn:

```xml
<add name="ToeicDb"
     connectionString="Data Source=TEN_MAY\TEN_INSTANCE;Initial Catalog=TOEIC_PracticeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;"
     providerName="System.Data.SqlClient" />
```

`TOEIC_Practice.DAL/Helpers/DataHelper.cs` có một chuỗi kết nối dự phòng dùng khi `App.config` không có `ToeicDb`; nên sửa luôn nếu đổi máy.

### 4. Build và chạy

Mở `Project/TOEIC_Practice/TOEIC_Practice.slnx` bằng Visual Studio, chọn `TOEIC_Practice.GUI` làm startup project và nhấn F5.

Hoặc build bằng dòng lệnh:

```powershell
& "C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe" "Project\TOEIC_Practice\TOEIC_Practice.slnx" /p:Configuration=Debug
```

File chạy nằm ở `Project/TOEIC_Practice/TOEIC_Practice.GUI/bin/Debug/TOEIC_Practice.GUI.exe`. Cảnh báo `MSB3305` về `WMPLib` khi build là bình thường.

### 5. Tài khoản mẫu

Lần đầu mở màn hình đăng nhập, ứng dụng tự tạo hai tài khoản nếu chưa có:

| Tài khoản | Mật khẩu | Quyền |
|-----------|----------|-------|
| `admin`   | `123456` | Quản trị viên |
| `user1`   | `123456` | Người dùng |

## Ghi chú về file media

- CSDL chỉ lưu đường dẫn tương đối theo part, ví dụ `Part1/2024_T1_P1_Q1.mp3`. Ứng dụng đọc file tại `bin/Debug/Assets/Audio/...` và `bin/Debug/Assets/Images/...`.
- File media nằm trong `TOEIC_Practice.GUI/Assets/` và phải được khai báo trong `TOEIC_Practice.GUI.csproj` (`CopyToOutputDirectory`) thì mới được chép ra thư mục chạy khi build.
- File upload từ màn hình quản trị chỉ được chép vào `bin/Debug/Assets`. Muốn giữ lại trong mã nguồn, cần chép vào `TOEIC_Practice.GUI/Assets/` và khai báo trong `.csproj`.
- Quy ước đặt tên: `{Năm}_T{Test}_P{Part}_Q{Số câu}`, nhóm nhiều câu ghi `Q32_33_34`.
