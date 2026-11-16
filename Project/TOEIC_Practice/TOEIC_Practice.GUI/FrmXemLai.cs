using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.BLL.LamBai;
using TOEIC_Practice.DTO.LamBai;

namespace TOEIC_Practice.GUI
{
    public partial class FrmXemLai : Form
    {
        private readonly int _attemptId;
        private int _partId; // 0 = xem tất cả
        private readonly ReviewBLL _bll = new ReviewBLL();

        // Map số câu -> Control để scroll tới
        private readonly Dictionary<int, Control> _questionControlMap = new Dictionary<int, Control>();

        public FrmXemLai(int attemptId, int partId = 0) // ✅ đổi default: 0 = tất cả
        {
            InitializeComponent();
            _attemptId = attemptId;
            _partId = partId;

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Render ở Shown để đảm bảo Form đã có kích thước thật
            this.Shown += FrmXemLai_Shown;
            this.Resize += FrmXemLai_Resize;
        }

        private void FrmXemLai_Shown(object sender, EventArgs e)
        {
            LoadReview();
            this.PerformLayout();
            flpReview.PerformLayout();
            flpReview.Refresh();
        }

        private void LoadReview()
        {
            flpReview.SuspendLayout();
            flpNav.SuspendLayout();

            try
            {
                flpReview.Controls.Clear();
                flpNav.Controls.Clear();
                _questionControlMap.Clear();

                // 1) Xác định part cần render
                List<int> partsToRender;

                if (_partId > 0)
                {
                    partsToRender = new List<int> { _partId };
                }
                else
                {
                    partsToRender = _bll.GetAttemptParts(_attemptId)
                        .Distinct()
                        .OrderBy(x => x)
                        .ToList();
                }

                // 2) Tiêu đề panel nav bên phải
                lblPartTitle.Text = (_partId == 0)
                    ? "Xem đáp án"
                    : $"Xem đáp án (Part {_partId})";

                // 3) Render lần lượt từng part
                foreach (int pid in partsToRender)
                {
                    // ----- Header bên trái cho mỗi part -----
                    Label lblHeader = new Label();
                    lblHeader.AutoSize = false;
                    lblHeader.Width = Math.Max(300, flpReview.ClientSize.Width - 35);
                    lblHeader.Height = 34;
                    lblHeader.Margin = new Padding(0, 0, 0, 10);
                    lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                    lblHeader.ForeColor = Color.Black;
                    lblHeader.BackColor = Color.FromArgb(241, 245, 249);
                    lblHeader.TextAlign = ContentAlignment.MiddleLeft;
                    lblHeader.Text = $"PART {pid}";
                    flpReview.Controls.Add(lblHeader);

                    // ----- Header + container nav của part này -----
                    Label navHeader = CreateNavPartHeader(pid);
                    FlowLayoutPanel navContainer = CreateNavPartContainer();

                    flpNav.Controls.Add(navHeader);
                    flpNav.Controls.Add(navContainer);

                    // ----- Lấy danh sách câu review -----
                    var questions = _bll.GetQuestions(_attemptId, pid);

                    if (questions == null || questions.Count == 0)
                    {
                        Label lblEmpty = new Label();
                        lblEmpty.AutoSize = false;
                        lblEmpty.Width = Math.Max(300, flpReview.ClientSize.Width - 35);
                        lblEmpty.Height = 40;
                        lblEmpty.Margin = new Padding(0, 0, 0, 14);
                        lblEmpty.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
                        lblEmpty.ForeColor = Color.DimGray;
                        lblEmpty.TextAlign = ContentAlignment.MiddleLeft;
                        lblEmpty.Text = $"Part {pid} không có dữ liệu review.";
                        flpReview.Controls.Add(lblEmpty);
                        continue;
                    }

                    // ----- Part 6, 7: render theo group có passage -----
                    if (pid == 6 || pid == 7)
                    {
                        RenderPassagePartAsGroups(pid, questions, navContainer);
                        continue;
                    }

                    // ----- Các part còn lại: render từng câu lẻ -----
                    RenderPart5AsSingles(pid, questions, navContainer);
                }
            }
            finally
            {
                flpReview.ResumeLayout();
                flpReview.PerformLayout();

                flpNav.ResumeLayout();
                flpNav.PerformLayout();

                FixReviewChildrenWidth();
            }
        }
        private void RenderPassagePartAsGroups(int partId, List<AttemptReviewQuestionDTO> questions, FlowLayoutPanel navContainer)
        {
            var groups = questions
                .GroupBy(x => x.GroupId)
                .OrderBy(g => g.Key)
                .ToList();

            foreach (var g in groups)
            {
                string passage = g.First().PassageText ?? "";

                var ucGroup = new UcReview_Part6Group();
                ucGroup.Width = Math.Max(300, flpReview.ClientSize.Width - 35);
                ucGroup.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                ucGroup.Margin = new Padding(0, 0, 0, 14);

                Func<int, List<AttemptReviewOptionDTO>> optionsProvider =
                    (attemptQuestionId) => _bll.GetOptions(attemptQuestionId);

                ucGroup.Bind(
                    $"PART {partId}",
                    passage,
                    g.OrderBy(x => x.OrderNo).ToList(),
                    optionsProvider
                );

                flpReview.Controls.Add(ucGroup);

                foreach (var kv in ucGroup.OrderToControl)
                    _questionControlMap[kv.Key] = kv.Value;

                foreach (var q in g.OrderBy(x => x.OrderNo))
                {
                    Button btn = CreateNavButton(q.OrderNo, q.ChosenOptionLabel, q.CorrectOptionLabel);
                    int orderNoLocal = q.OrderNo;
                    btn.Click += (s, ev) => ScrollToQuestion(orderNoLocal);
                    navContainer.Controls.Add(btn);
                }
            }
        }

        private void RenderPart5AsSingles(int pid, List<AttemptReviewQuestionDTO> questions, FlowLayoutPanel navContainer)
        {
            foreach (var q in questions.OrderBy(x => x.OrderNo))
            {
                var opts = _bll.GetOptions(q.AttemptQuestionId);

                var uc = new UcReview_Part5Question();
                uc.Width = Math.Max(300, flpReview.ClientSize.Width - 35);
                uc.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                uc.Margin = new Padding(0, 0, 0, 12);

                uc.Bind(q, opts);

                flpReview.Controls.Add(uc);
                _questionControlMap[q.OrderNo] = uc;

                Button btn = CreateNavButton(q.OrderNo, q.ChosenOptionLabel, q.CorrectOptionLabel);
                int orderNoLocal = q.OrderNo;
                btn.Click += (s, ev) => ScrollToQuestion(orderNoLocal);
                navContainer.Controls.Add(btn);
            }
        }

        private void RenderPartHeader(int partId)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Height = 40;
            lbl.Width = Math.Max(300, flpReview.ClientSize.Width - 35);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl.Text = $"PART {partId}";
            lbl.BackColor = Color.FromArgb(241, 245, 249);
            lbl.Padding = new Padding(10, 0, 0, 0);
            lbl.Margin = new Padding(0, 10, 0, 10);
            flpReview.Controls.Add(lbl);
        }

        private void RenderEmptyPart(int partId)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Height = 50;
            lbl.Width = Math.Max(300, flpReview.ClientSize.Width - 35);
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lbl.Text = $"Part {partId}: Không có dữ liệu xem lại.";
            lbl.Margin = new Padding(0, 0, 0, 12);
            flpReview.Controls.Add(lbl);
        }

        private Control CreateReviewControlByPart(int partId, dynamic q, dynamic opts)
        {
            // ✅ Part 5: dùng UC bạn đã làm tốt
            if (partId == 5)
            {
                var uc = new UcReview_Part5Question();
                uc.Bind(q, opts); // q phải là AttemptReviewQuestionDTO
                return uc;
            }

            // ✅ Part 6: bạn sẽ làm UC riêng theo dạng "đoạn văn + nhiều câu"
            // TẠM thời: nếu chưa làm UI Part 6 thì hiển thị thông báo.
            if (partId == 6)
            {
                Panel p = new Panel();
                p.Height = 70;
                p.BackColor = Color.White;
                p.BorderStyle = BorderStyle.FixedSingle;

                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                lbl.Padding = new Padding(10);
                lbl.Text = "Part 6: Chưa gắn UserControl review Part 6.\n(Bước tiếp theo: dựng UCReview_Part6Group theo mô tả Study4)";
                p.Controls.Add(lbl);

                return p;
            }

            // part khác
            Panel pOther = new Panel();
            pOther.Height = 60;
            pOther.BackColor = Color.White;
            pOther.BorderStyle = BorderStyle.FixedSingle;
            Label lblOther = new Label();
            lblOther.Dock = DockStyle.Fill;
            lblOther.TextAlign = ContentAlignment.MiddleLeft;
            lblOther.Padding = new Padding(10);
            lblOther.Text = $"Part {partId}: Chưa hỗ trợ review UI.";
            pOther.Controls.Add(lblOther);
            return pOther;
        }

        private Button CreateNavButton(int orderNo, string chosen, string correct)
        {
            chosen = (chosen ?? "").Trim().ToUpper();
            correct = (correct ?? "").Trim().ToUpper();

            Color back;
            Color fore = Color.White;

            if (string.IsNullOrEmpty(chosen))
                back = Color.FromArgb(148, 163, 184); // bỏ qua
            else if (!string.IsNullOrEmpty(correct) && chosen == correct)
                back = Color.FromArgb(34, 197, 94);  // đúng
            else
                back = Color.FromArgb(239, 68, 68);  // sai (hoặc chưa xác định đúng)

            Button btn = new Button();
            btn.Width = 36;
            btn.Height = 30;
            btn.Margin = new Padding(6);
            btn.Text = orderNo.ToString();
            btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn.BackColor = back;
            btn.ForeColor = fore;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            return btn;
        }
        private Label CreateNavPartHeader(int partId)
        {
            Label lbl = new Label();
            lbl.AutoSize = false;
            lbl.Width = Math.Max(120, flpNav.ClientSize.Width - 25);
            lbl.Height = 28;
            lbl.Margin = new Padding(0, 8, 0, 6);
            lbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbl.ForeColor = Color.FromArgb(30, 41, 59);
            lbl.BackColor = Color.FromArgb(241, 245, 249);
            lbl.Padding = new Padding(6, 4, 6, 4);
            lbl.Text = $"Part {partId}";
            return lbl;
        }
        private FlowLayoutPanel CreateNavPartContainer()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.AutoSize = true;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.WrapContents = true;
            panel.FlowDirection = FlowDirection.LeftToRight;
            panel.Width = Math.Max(120, flpNav.ClientSize.Width - 25);
            panel.Margin = new Padding(0, 0, 0, 10);
            return panel;
        }

        private void ScrollToQuestion(int orderNo)
        {
            if (!_questionControlMap.ContainsKey(orderNo)) return;

            Control target = _questionControlMap[orderNo];
            flpReview.ScrollControlIntoView(target);
            HighlightControl(target);
        }

        private void HighlightControl(Control ctl)
        {
            Color old = ctl.BackColor;
            ctl.BackColor = Color.FromArgb(254, 249, 195); // vàng nhạt

            Timer t = new Timer();
            t.Interval = 350;
            t.Tick += (s, ev) =>
            {
                t.Stop();
                t.Dispose();
                ctl.BackColor = old;
            };
            t.Start();
        }

        private void FrmXemLai_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flpReview.Controls)
            {
                c.Width = Math.Max(300, flpReview.ClientSize.Width - 35);

                // Nếu UC group có method fix nội bộ thì gọi thêm
                if (c is UcReview_Part6Group group)
                {
                    // chỉ gọi nếu control này của bạn đã có method này
                    // group.FixChildrenWidth();
                }
            }
        }
        private void FixReviewChildrenWidth()
        {
            int reviewWidth = Math.Max(300, flpReview.ClientSize.Width - 35);
            int navWidth = Math.Max(120, flpNav.ClientSize.Width - 25);

            foreach (Control c in flpReview.Controls)
            {
                c.Width = reviewWidth;

                if (c is UcReview_Part6Group g)
                    g.FixChildrenWidth();
            }

            foreach (Control c in flpNav.Controls)
            {
                if (c is Label lbl)
                {
                    lbl.Width = navWidth;
                }
                else if (c is FlowLayoutPanel p)
                {
                    p.Width = navWidth;
                }
            }
        }

        // ✅ Nếu Designer đang hook flpReview_Paint thì để hàm rỗng cho khỏi lỗi
        private void flpReview_Paint(object sender, PaintEventArgs e) { }
    }
}