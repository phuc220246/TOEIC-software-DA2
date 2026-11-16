using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;
using TOEIC_Practice.Helpers;


namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    public partial class UcPart3Group : UserControl
    {
        public event Action<int, int> AnswerSelected;

        private List<AttemptQuestionDTO> _questions = new List<AttemptQuestionDTO>();
        private Dictionary<int, List<AttemptOptionDTO>> _optionsMap = new Dictionary<int, List<AttemptOptionDTO>>();

        public UcPart3Group()
        {
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            picImage.SizeMode = PictureBoxSizeMode.Zoom;

            pnlQuestionsHost.AutoScroll = false;
        }

        public void Bind(

            AttemptQuestionDTO firstQuestionInGroup,
            List<AttemptQuestionDTO> questions,
            Dictionary<int, List<AttemptOptionDTO>> optionsMap,
            string audioRootFolder,
            string imageRootFolder,
            int totalQuestionCount)

        {
            _questions = questions ?? new List<AttemptQuestionDTO>();
            _optionsMap = optionsMap ?? new Dictionary<int, List<AttemptOptionDTO>>();

            lblGroupTitle.Text = $"Part {firstQuestionInGroup.PartId} - Nhóm {firstQuestionInGroup.GroupOrderNo}";

            BindAudio(firstQuestionInGroup, audioRootFolder);
            BindImage(firstQuestionInGroup, imageRootFolder);

            ReLayoutByContent();
            BindQuestions(totalQuestionCount);
            FixChildrenWidth();
            AdjustGroupHeight();
        }

        private void BindAudio(AttemptQuestionDTO question, string audioRootFolder)
        {
            try
            {
                if (question == null || string.IsNullOrWhiteSpace(question.AudioPath))
                {
                    ucAudioPlayer.SetAudioPath("");
                    return;
                }

                string fullAudioPath = MediaPathHelper.GetAbsoluteAudioPath(question.AudioPath);

                if (File.Exists(fullAudioPath))
                {
                    ucAudioPlayer.SetAudioPath(fullAudioPath);
                }
                else
                {
                    ucAudioPlayer.SetAudioPath("");
                    MessageBox.Show(
                        "Không tìm thấy file audio:\n" + fullAudioPath,
                        "Thiếu audio",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load audio Part 3:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BindImage(AttemptQuestionDTO question, string imageRootFolder)
        {
            try
            {
                if (picImage.Image != null)
                {
                    picImage.Image.Dispose();
                    picImage.Image = null;
                }

                picImage.Visible = false;

                if (question == null || string.IsNullOrWhiteSpace(question.ImagePath))
                    return;

                string fullImagePath = MediaPathHelper.GetAbsoluteImagePath(question.ImagePath);

                if (string.IsNullOrWhiteSpace(fullImagePath))
                    return;

                if (File.Exists(fullImagePath))
                {
                    using (var bmpTemp = new System.Drawing.Bitmap(fullImagePath))
                    {
                        picImage.Image = new System.Drawing.Bitmap(bmpTemp);
                    }

                    picImage.SizeMode = PictureBoxSizeMode.Zoom;
                    picImage.Visible = true;
                    picImage.BringToFront();
                    picImage.Refresh();

                    if (picImage.Height <= 0)
                        picImage.Height = 420;
                }
                else
                {
                    picImage.Visible = false;
                    MessageBox.Show(
                        "Không tìm thấy file ảnh:\n" + fullImagePath,
                        "Thiếu ảnh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load ảnh Part 3:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ReLayoutByContent()
        {
            int left = 20;
            int rightPadding = 20;
            int contentWidth = pnlMain.ClientSize.Width - left - rightPadding;

            if (contentWidth < 300) contentWidth = 300;

            lblGroupTitle.Left = left;
            lblGroupTitle.Top = 20;

            ucAudioPlayer.Left = lblGroupTitle.Right + 10;
            ucAudioPlayer.Top = 14;
            ucAudioPlayer.Width = 320;

            int topAfterHeader = ucAudioPlayer.Bottom + 12;

            if (picImage.Visible)
            {
                picImage.Left = left;
                picImage.Top = topAfterHeader;
                picImage.Width = contentWidth;
                picImage.Height = 360;

                pnlQuestionsHost.Left = left;
                pnlQuestionsHost.Top = picImage.Bottom + 14;
            }
            else
            {
                pnlQuestionsHost.Left = left;
                pnlQuestionsHost.Top = topAfterHeader;
            }

            pnlQuestionsHost.Width = contentWidth;
        }

        private void BindQuestions(int totalQuestionCount)
        {
            pnlQuestionsHost.SuspendLayout();
            pnlQuestionsHost.Controls.Clear();

            int questionWidth = pnlQuestionsHost.Width;
            if (questionWidth < 300) questionWidth = 300;

            int currentTop = 0;

            foreach (var q in _questions.OrderBy(x => x.OrderNo))
            {
                var uc = new UcChoiceQuestion();
                uc.Left = 0;
                uc.Top = currentTop;
                uc.Width = questionWidth;
                uc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

                List<AttemptOptionDTO> opts = null;
                if (_optionsMap.ContainsKey(q.AttemptQuestionId))
                {
                    opts = _optionsMap[q.AttemptQuestionId];
                }

                uc.BindData(q, totalQuestionCount, opts);

                uc.AnswerSelected += (attemptQuestionId, selectedIndex) =>
                {
                    AnswerSelected?.Invoke(attemptQuestionId, selectedIndex);
                };

                pnlQuestionsHost.Controls.Add(uc);

                currentTop += uc.Height + 12;
            }

            pnlQuestionsHost.Height = currentTop;
            pnlQuestionsHost.ResumeLayout();
        }

        private void AdjustGroupHeight()
        {
            int totalHeight = pnlQuestionsHost.Top + pnlQuestionsHost.Height + 20;
            if (totalHeight < 200) totalHeight = 200;

            this.Height = totalHeight;
        }

        public void StopAudio()
        {
            try
            {
                ucAudioPlayer?.StopAudio();
            }
            catch
            {
            }
        }

        public void FixChildrenWidth()
        {
            ReLayoutByContent();

            int w = pnlQuestionsHost.Width;
            if (w < 300) w = 300;

            int currentTop = 0;

            foreach (Control c in pnlQuestionsHost.Controls)
            {
                c.Left = 0;
                c.Top = currentTop;
                c.Width = w;

                currentTop += c.Height + 12;
            }

            pnlQuestionsHost.Height = currentTop;
            AdjustGroupHeight();
        }
    }
}