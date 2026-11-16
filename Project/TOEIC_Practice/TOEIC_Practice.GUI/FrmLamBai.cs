using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL.LamBai;
using TOEIC_Practice.DTO.LamBai;
using TOEIC_Practice.GUI.UserControls.LamBai;
namespace TOEIC_Practice.GUI
{
    public partial class FrmLamBai : Form
    {
        private readonly AttemptBLL _attemptBll = new AttemptBLL();
        private readonly AttemptOptionBLL _optBll = new AttemptOptionBLL();
        private readonly ReviewBLL _reviewBll = new ReviewBLL();
        private readonly string _audioRootFolder;
        private readonly string _imageRootFolder;
        private readonly int _attemptId;

        private List<AttemptQuestionDTO> _all = new List<AttemptQuestionDTO>();
        private Dictionary<int, List<AttemptOptionDTO>> _optionsMap = new Dictionary<int, List<AttemptOptionDTO>>();
        
        private List<int> _selectedParts = new List<int>();
        private int _partIndex = 0;
        
        // Timer
        private DateTime _startedAt = DateTime.Now;
        private int? _timeLimitMinutes = null; 
        private bool _countdown = false;

        public FrmLamBai(int attemptId)
        {
            InitializeComponent();
            _attemptId = attemptId;

            _audioRootFolder = Path.Combine(Application.StartupPath, "Assets", "Audio");
            _imageRootFolder = Path.Combine(Application.StartupPath, "Assets", "Images");

            // Co giãn form
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Co giãn nội dung khi đổi kích thước
            this.Resize += FrmLamBai_Resize;
            this.FormClosing += FrmLamBai_FormClosing;
        }

        private void FrmLamBai_Load(object sender, EventArgs e)
        {
            // 1) Load toàn bộ câu của attempt (đã có thứ tự)
            Dictionary<int, List<AttemptOptionDTO>> optionsMap;
            _all = _attemptBll.GetQuestionList(_attemptId, out optionsMap);

            // Lưu lại optionsMap để render UI Part 5
            _optionsMap = optionsMap;
            
            if (_all == null || _all.Count == 0)
            {
                MessageBox.Show("Attempt không có câu hỏi. Kiểm tra dữ liệu/part đã chọn.");
                Close();
                return;
            }

            // 2) Xác định các part đã chọn
            _selectedParts = _all.Select(x => x.PartId).Distinct().OrderBy(x => x).ToList();
            _partIndex = 0;

            // 3) Start timer (tạm: đếm lên)
            _startedAt = DateTime.Now;
            lblTimer.Text = "00:00:00";
            timer1.Start();

            // 4) Load part đầu tiên
            LoadCurrentPart();
        }

        private void LoadCurrentPart()
        {
            if (_selectedParts == null || _selectedParts.Count == 0) return;

            if (_partIndex < 0) _partIndex = 0;
            if (_partIndex >= _selectedParts.Count) _partIndex = _selectedParts.Count - 1;

            int partId = _selectedParts[_partIndex];
            lblThongTinPart.Text = $"Part: {partId}  ({_partIndex + 1}/{_selectedParts.Count})";

            // Clear nội dung cũ
            flpNoiDung.SuspendLayout();

            // Dừng toàn bộ audio/media của part hiện tại trước khi xóa UI cũ
            StopAllMediaInCurrentScreen();

            flpNoiDung.Controls.Clear();

            // Setup flow panel
            flpNoiDung.FlowDirection = FlowDirection.TopDown;
            flpNoiDung.WrapContents = false;
            flpNoiDung.AutoScroll = true;

            // Lấy câu thuộc part hiện tại theo OrderNo
            var list = _all.Where(x => x.PartId == partId)
                           .OrderBy(x => x.OrderNo)
                           .ToList();

            // Render theo part
            if (partId == 1)
            {
                RenderPart1(list);
            }
            else if (partId == 2)
            {
                RenderPart2(list);
            }
            else if (partId == 3)
            {
                RenderPart3(list);
            }
            else if (partId == 4)
            {
                RenderPart4(list);
            }
            else if (partId == 5)
            {
                RenderPart5(list);
            }
            else if (partId == 6)
            {
                RenderPart6(list);
            }
            else if (partId == 7)
            {
                RenderPart7(list);
            }
            else
            {
                RenderNotSupported(partId, list.Count);
            }
            

            // Footer cuối trang: nút điều hướng part
            flpNoiDung.Controls.Add(CreateFooterPartNavigation());

            flpNoiDung.ResumeLayout();

            // đảm bảo co đúng width sau khi load part
            FixChildrenWidth();
        }
        private void RenderPart1(List<AttemptQuestionDTO> list)
        {
            int total = list.Count;

            foreach (var q in list)
            {
                var uc = new UcP1_SingleQuestion();
                uc.Width = flpNoiDung.ClientSize.Width - 40;
                uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                uc.Margin = new Padding(0, 0, 0, 12);

                List<AttemptOptionDTO> options = new List<AttemptOptionDTO>();

                // Ưu tiên lấy từ _optionsMap đã load sẵn
                if (_optionsMap != null && _optionsMap.ContainsKey(q.AttemptQuestionId))
                {
                    options = _optionsMap[q.AttemptQuestionId];
                }
                else
                {
                    // fallback nếu cần
                    try
                    {
                        options = _optBll.GetOptions(q.AttemptQuestionId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi load đáp án Part 1",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                uc.BindData(q, options, _audioRootFolder, _imageRootFolder);

                uc.AnswerSelected += (attemptQuestionId, optionLabel) =>
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(optionLabel)) return;

                        _attemptBll.SaveAnswer(attemptQuestionId, optionLabel);

                        // cập nhật lại dữ liệu local để khi load lại part vẫn giữ đáp án đã chọn
                        var current = _all.FirstOrDefault(x => x.AttemptQuestionId == attemptQuestionId);
                        if (current != null)
                            current.ChosenOptionLabel = optionLabel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi lưu đáp án Part 1",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                flpNoiDung.Controls.Add(uc);
            }
        }
        private void RenderPart2(List<AttemptQuestionDTO> list)
        {
            foreach (var q in list)
            {
                var uc = new UcP2_SingleQuestion();
                uc.Width = flpNoiDung.ClientSize.Width - 40;
                uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                uc.Margin = new Padding(0, 0, 0, 12);

                List<AttemptOptionDTO> options = new List<AttemptOptionDTO>();

                if (_optionsMap != null && _optionsMap.ContainsKey(q.AttemptQuestionId))
                {
                    options = _optionsMap[q.AttemptQuestionId];
                }
                else
                {
                    try
                    {
                        options = _optBll.GetOptions(q.AttemptQuestionId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi load đáp án Part 2",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                uc.BindData(q, options, _audioRootFolder);

                uc.AnswerSelected += (attemptQuestionId, optionLabel) =>
                {
                    try
                    {
                        if (string.IsNullOrWhiteSpace(optionLabel)) return;

                        _attemptBll.SaveAnswer(attemptQuestionId, optionLabel);

                        var current = _all.FirstOrDefault(x => x.AttemptQuestionId == attemptQuestionId);
                        if (current != null)
                            current.ChosenOptionLabel = optionLabel;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi lưu đáp án Part 2",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                flpNoiDung.Controls.Add(uc);
            }
        }

        private void RenderPart3(List<AttemptQuestionDTO> list)
        {
            var groups = list
                .GroupBy(x => x.GroupId)
                .OrderBy(g => g.Min(x => x.GroupOrderNo))
                .ToList();

            int total = list.Count;

            for (int i = 0; i < groups.Count; i++)
            {
                var g = groups[i];
                var first = g.First();

                if (first.GroupOrderNo <= 0)
                    first.GroupOrderNo = i + 1;

                var uc = new UcPart3Group();
                uc.Width = flpNoiDung.ClientSize.Width - 40;
                uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                uc.Margin = new Padding(0, 0, 0, 16);

                uc.Bind(
                    first,
                    g.OrderBy(x => x.OrderNo).ToList(),
                    _optionsMap,
                    _audioRootFolder,
                    _imageRootFolder,
                    total
                );

                uc.AnswerSelected += (attemptQuestionId, selectedIndex) =>
                {
                    try
                    {
                        string label = IndexToLabel(selectedIndex);
                        if (string.IsNullOrWhiteSpace(label)) return;

                        _attemptBll.SaveAnswer(attemptQuestionId, label);

                        var current = _all.FirstOrDefault(x => x.AttemptQuestionId == attemptQuestionId);
                        if (current != null)
                            current.ChosenOptionLabel = label;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi lưu đáp án Part 3",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                flpNoiDung.Controls.Add(uc);
            }
        }
        private void RenderPart4(List<AttemptQuestionDTO> list)
        {
            var groups = list
                .GroupBy(x => x.GroupId)
                .OrderBy(g => g.Min(x => x.GroupOrderNo))
                .ToList();

            int total = list.Count;

            for (int i = 0; i < groups.Count; i++)
            {
                var g = groups[i];
                var first = g.First();

                if (first.GroupOrderNo <= 0)
                    first.GroupOrderNo = i + 1;

                var uc = new UcPart3Group();
                uc.Width = flpNoiDung.ClientSize.Width - 40;
                uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                uc.Margin = new Padding(0, 0, 0, 16);

                uc.Bind(
                    first,
                    g.OrderBy(x => x.OrderNo).ToList(),
                    _optionsMap,
                    _audioRootFolder,
                    _imageRootFolder,
                    total
                );

                uc.AnswerSelected += (attemptQuestionId, selectedIndex) =>
                {
                    try
                    {
                        string label = IndexToLabel(selectedIndex);
                        if (string.IsNullOrWhiteSpace(label)) return;

                        _attemptBll.SaveAnswer(attemptQuestionId, label);

                        var current = _all.FirstOrDefault(x => x.AttemptQuestionId == attemptQuestionId);
                        if (current != null)
                            current.ChosenOptionLabel = label;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi lưu đáp án Part 4",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                flpNoiDung.Controls.Add(uc);
            }
        }
        private void RenderPart5(List<AttemptQuestionDTO> list)
        {
            int total = list.Count;

            foreach (var q in list)
            {
                // UcP5_SingleQuestion của bạn đang dùng constructor (q, total)
                var uc = new UcP5_SingleQuestion(q, total);

                uc.Width = flpNoiDung.ClientSize.Width - 40;
                uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                if (_optionsMap != null && _optionsMap.ContainsKey(q.AttemptQuestionId))
                {
                    uc.SetOptions(_optionsMap[q.AttemptQuestionId]);
                }
                if (_optionsMap.ContainsKey(q.AttemptQuestionId))
                    uc.SetOptions(_optionsMap[q.AttemptQuestionId]);
                // 1) Load đáp án A/B/C/D từ DB (AttemptOption đã trộn)
                try
                {
                    var options = _optBll.GetOptions(q.AttemptQuestionId);
                    uc.SetOptions(options);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi load đáp án Part 5",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // 2) Khi user chọn đáp án -> lưu DB
                uc.AnswerSelected += (attemptQuestionId, selectedIndex) =>
                {
                    try
                    {
                        string label = IndexToLabel(selectedIndex); // 0->A,1->B,2->C,3->D
                        if (string.IsNullOrEmpty(label)) return;

                        _optBll.SaveAnswer(attemptQuestionId, label);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi lưu đáp án",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                };

                flpNoiDung.Controls.Add(uc);
            }
        }
        private void RenderPart6(List<AttemptQuestionDTO> list)
        {
            // Part 6: group theo GroupId (mỗi group = 1 đoạn)
            // Mỗi group hiển thị: PassageBlock -> các câu thuộc group (reuse UcP5_SingleQuestion)

            var groups = list
                .GroupBy(x => x.GroupId)
                .OrderBy(g => g.Min(x => x.GroupOrderNo))  // theo thứ tự group trong test
                .ToList();

            int total = list.Count;

            foreach (var g in groups)
            {
                var first = g.First();

                // 1) Passage
                var ucPassage = new UcPassageBlock();
                ucPassage.Width = flpNoiDung.ClientSize.Width - 40;
                ucPassage.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                ucPassage.Margin = new Padding(0, 0, 0, 10);

                string title = $"Part 6 - Đoạn {first.GroupOrderNo}";
                ucPassage.Bind(title, first.PassageText);

                flpNoiDung.Controls.Add(ucPassage);

                // 2) Questions trong group
                foreach (var q in g.OrderBy(x => x.OrderNo))
                {
                    var uc = new UcP5_SingleQuestion(q, total);
                    uc.Width = flpNoiDung.ClientSize.Width - 40;
                    uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                    uc.Margin = new Padding(0, 0, 0, 10);

                    // ✅ set options theo attempt (đã trộn)
                    if (_optionsMap != null && _optionsMap.ContainsKey(q.AttemptQuestionId))
                    {
                        uc.SetOptions(_optionsMap[q.AttemptQuestionId]);
                    }

                    // Event chọn đáp án -> lưu DB ngay (nếu bạn đã làm Part 5 rồi thì giữ logic đó)
                    uc.AnswerSelected += (attemptQuestionId, selectedIndex) =>
                    {
                        // selectedIndex: 0=A,1=B,2=C,3=D
                        char label = (char)('A' + selectedIndex);

                        // TODO: gọi AttemptBLL.SaveAnswer(...) nếu bạn đang lưu realtime
                        _attemptBll.SaveAnswer(attemptQuestionId, label.ToString());
                    };

                    flpNoiDung.Controls.Add(uc);
                }

                // separator giữa các passage
                var sep = new Panel();
                sep.Height = 1;
                sep.Width = flpNoiDung.ClientSize.Width - 40;
                sep.BackColor = Color.Gainsboro;
                sep.Margin = new Padding(0, 6, 0, 16);
                flpNoiDung.Controls.Add(sep);
            }
        }
        private void RenderPart7(List<AttemptQuestionDTO> list)
        {
            flpNoiDung.Controls.Clear();

            // Lấy group Part 7 + map options đúng theo chữ ký hàm BLL hiện tại
            var groups = _attemptBll.GetPart7Groups(_attemptId, out _optionsMap);

            int total = list.Count;

            foreach (var g in groups.OrderBy(x => x.GroupOrderNo))
            {
                var uc = new UcPart7Group();
                uc.Margin = new Padding(0, 0, 0, 16);
                uc.Width = flpNoiDung.ClientSize.Width - 30;

                uc.Bind(g, _optionsMap, total);

                uc.AnswerSelected += (attemptQuestionId, selectedIndex) =>
                {
                    try
                    {
                        string label = IndexToLabel(selectedIndex);
                        if (string.IsNullOrWhiteSpace(label)) return;

                        _attemptBll.SaveAnswer(attemptQuestionId, label);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi lưu đáp án Part 7: " + ex.Message,
                            "Cảnh báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                };

                flpNoiDung.Controls.Add(uc);
            }

            FixChildrenWidth();
        }
        private void RenderNotSupported(int partId, int count)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Width = flpNoiDung.ClientSize.Width - 40;
            lbl.Height = 80;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lbl.Text = $"Part {partId} (có {count} câu) - Chưa dựng UI part này.\n" +
                       $"Bước tiếp theo mình sẽ dựng theo mô tả của bạn (audio/image/passage...).";
            flpNoiDung.Controls.Add(lbl);
        }
        private Control CreateFooterPartNavigation()
        {
            Panel p = new Panel();
            p.Height = 70;
            p.Width = flpNoiDung.ClientSize.Width - 40;
            p.BackColor = Color.White;
            p.Margin = new Padding(0, 12, 0, 12);

            Button btnPrev = new Button();
            btnPrev.Text = "← Part trước";
            btnPrev.Width = 160;
            btnPrev.Height = 38;
            btnPrev.Left = 10;
            btnPrev.Top = 15;
            btnPrev.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPrev.Enabled = _partIndex > 0;
            btnPrev.Click += (s, e) => GoToPreviousPart();

            Button btnNext = new Button();
            btnNext.Text = "Tiếp Part →";
            btnNext.Width = 160;
            btnNext.Height = 38;
            btnNext.Top = 15;
            btnNext.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNext.Left = p.Width - btnNext.Width - 10;
            btnNext.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNext.Enabled = _partIndex < _selectedParts.Count - 1;
            btnNext.Click += (s, e) => GoToNextPart();

            p.Controls.Add(btnPrev);
            p.Controls.Add(btnNext);

            return p;
        }
        private void GoToNextPart()
        {
            StopAllMediaInCurrentScreen();

            if (_partIndex < _selectedParts.Count - 1)
            {
                _partIndex++;
                LoadCurrentPart();
                ScrollContentToTop();
            }
            else
            {
                MessageBox.Show("Bạn đã đến Part cuối cùng.");
            }
        }

        private void GoToPreviousPart()
        {
            StopAllMediaInCurrentScreen();

            if (_partIndex > 0)
            {
                _partIndex--;
                LoadCurrentPart();
                ScrollContentToTop();
            }
            else
            {
                MessageBox.Show("Bạn đang ở Part đầu tiên.");
            }
        }
        private void ScrollContentToTop()
        {
            try
            {
                flpNoiDung.VerticalScroll.Value = 0;
            }
            catch
            {
            }

            flpNoiDung.PerformLayout();
        }
        private void StopAllMediaInCurrentScreen()
        {
            try
            {
                StopMediaRecursive(flpNoiDung);
            }
            catch
            {
            }
        }

        private void StopMediaRecursive(Control parent)
        {
            foreach (Control ctl in parent.Controls)
            {
                if (ctl is UcP1_SingleQuestion p1)
                {
                    p1.StopAudio();
                }
                else if (ctl is UcP2_SingleQuestion p2)
                {
                    p2.StopAudio();
                }
                else if (ctl is UcPart3Group p3)
                {
                    p3.StopAudio();
                }

                if (ctl.HasChildren)
                {
                    StopMediaRecursive(ctl);
                }
            }
        }
        

        private void btnTiepPart_Click(object sender, EventArgs e)
        {
            GoToPreviousPart();
        }
        private void btnPartTruoc_Click(object sender, EventArgs e)
        {
            GoToPreviousPart();
        }
        private string GetResultBadgeText()
        {
            var parts = _reviewBll.GetAttemptParts(_attemptId);

            if (parts == null || parts.Count == 0)
                return "Luyện tập";

            if (parts.Count == 1)
                return $"Part {parts[0]}";

            return string.Join(", ", parts.ConvertAll(x => $"Part {x}"));
        }
        private void btnNopBai_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Stop();
                StopAllPart1Audio();

                AttemptSummaryDTO summary = _attemptBll.SubmitAttempt(_attemptId);
                string badgeText = GetResultBadgeText();

                this.Hide();

                using (FrmKetQua f = new FrmKetQua(summary, badgeText))
                {
                    f.ShowDialog();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nộp bài thất bại",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void StopAllPart1Audio()
        {
            StopAudioRecursive(this);
        }
        private void FrmLamBai_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopAllPart1Audio();
        }

        private void StopAudioRecursive(Control parent)
        {
            foreach (Control ctl in parent.Controls)
            {
                if (ctl is UcP1_SingleQuestion p1)
                {
                    p1.StopAudio();
                }
                else if (ctl is UcP2_SingleQuestion p2)
                {
                    p2.StopAudio();
                }
                else if (ctl is UcPart3Group p3)
                {
                    p3.StopAudio();
                }

                if (ctl.HasChildren)
                {
                    StopAudioRecursive(ctl);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tạm: đếm lên
            TimeSpan elapsed = DateTime.Now - _startedAt;

            if (_countdown && _timeLimitMinutes.HasValue)
            {
                TimeSpan remain = TimeSpan.FromMinutes(_timeLimitMinutes.Value) - elapsed;
                if (remain.TotalSeconds <= 0)
                {
                    lblTimer.Text = "00:00:00";
                    timer1.Stop();
                    MessageBox.Show("Hết giờ! Bước sau sẽ tự động nộp bài.");
                    return;
                }
                lblTimer.Text = remain.ToString(@"hh\:mm\:ss");
            }
            else
            {
                lblTimer.Text = elapsed.ToString(@"hh\:mm\:ss");
            }
        }

        // ====== HỖ TRỢ ======

        private string IndexToLabel(int selectedIndex)
        {
            switch (selectedIndex)
            {
                case 0: return "A";
                case 1: return "B";
                case 2: return "C";
                case 3: return "D";
                default: return "";
            }
        }

        private void FrmLamBai_Resize(object sender, EventArgs e)
        {
            FixChildrenWidth();
        }

        private void FixChildrenWidth()
        {
            int w = flpNoiDung.ClientSize.Width - 40;
            if (w < 200) w = 200;

            foreach (Control c in flpNoiDung.Controls)
            {
                c.Width = w;

                if (c is UcPart7Group p7)
                {
                    p7.FixChildrenWidth();
                }
                else if (c is UcPart3Group p3)
                {
                    p3.FixChildrenWidth();
                }
                else if (c is UcP1_SingleQuestion p1)
                {
                    p1.Width = w;
                }
            }
        }
        
        private void flpNoiDung_Paint(object sender, PaintEventArgs e)
        {
            // không cần code
        }
        
    }
}