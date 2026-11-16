using AxWMPLib;
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
    public partial class UcP1_SingleQuestion : UserControl
    {
        public event Action<int, string> AnswerSelected;

        private AttemptQuestionDTO _question;
        private List<AttemptOptionDTO> _options;
        private string _audioFullPath = "";
        private bool _audioLoaded = false;
        private static UcP1_SingleQuestion _currentlyPlayingControl = null;

        public UcP1_SingleQuestion()
        {
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            picImage.SizeMode = PictureBoxSizeMode.Zoom;

            rdoA.CheckedChanged += Option_CheckedChanged;
            rdoB.CheckedChanged += Option_CheckedChanged;
            rdoC.CheckedChanged += Option_CheckedChanged;
            rdoD.CheckedChanged += Option_CheckedChanged;

            btnPlayAudio.Click += btnPlayAudio_Click;
            btnStopAudio.Click += btnStopAudio_Click;

            try
            {
                wmpAudio.settings.autoStart = false;
                wmpAudio.uiMode = "none"; // ẩn player mặc định
                wmpAudio.stretchToFit = false;
            }
            catch
            {
            }
        }

        public void BindData(
    AttemptQuestionDTO question,
    List<AttemptOptionDTO> options,
    string audioRootFolder,
    string imageRootFolder)
        {
            _question = question;
            _options = options ?? new List<AttemptOptionDTO>();

            this.SuspendLayout();
            pnlMain.SuspendLayout();

            lblQuestionNo.Text = question.OrderNo.ToString();

            BindAudio(question, audioRootFolder);
            BindImage(question, imageRootFolder);
            BindOptions(_options, question.ChosenOptionLabel);

            pnlMain.ResumeLayout(true);
            this.ResumeLayout(true);

            pnlMain.PerformLayout();
            this.PerformLayout();
        }

        private void BindAudio(AttemptQuestionDTO question, string audioRootFolder)
        {
            try
            {
                _audioFullPath = "";
                _audioLoaded = false;

                try
                {
                    wmpAudio.Ctlcontrols.stop();
                    wmpAudio.URL = string.Empty;
                    wmpAudio.settings.autoStart = false;
                }
                catch
                {
                }

                if (question == null || string.IsNullOrWhiteSpace(question.AudioPath))
                    return;

                string fullAudioPath = MediaPathHelper.GetAbsoluteAudioPath(question.AudioPath);

                if (File.Exists(fullAudioPath))
                {
                    _audioFullPath = fullAudioPath;
                }
                else
                {
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
                    "Lỗi load audio Part 1:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BindImage(AttemptQuestionDTO question, string imageRootFolder)
        {
            try
            {
                ClearPicture();

                if (question == null || string.IsNullOrWhiteSpace(question.ImagePath))
                    return;

                string fullImagePath = MediaPathHelper.GetAbsoluteImagePath(question.ImagePath);

                if (string.IsNullOrWhiteSpace(fullImagePath))
                    return;

                if (!File.Exists(fullImagePath))
                {
                    MessageBox.Show(
                        "Không tìm thấy file ảnh:\n" + fullImagePath,
                        "Thiếu ảnh",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Đọc bytes để tránh lock file
                byte[] imageBytes = File.ReadAllBytes(fullImagePath);

                Image loadedImage;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                using (Image temp = Image.FromStream(ms))
                {
                    loadedImage = new Bitmap(temp);
                }

                picImage.SuspendLayout();

                picImage.Image = loadedImage;
                picImage.SizeMode = PictureBoxSizeMode.Zoom;
                picImage.Visible = true;
                picImage.Enabled = true;
                picImage.BringToFront();

                // debug tạm để nhìn rõ vùng ảnh
                // picImage.BorderStyle = BorderStyle.FixedSingle;

                picImage.ResumeLayout();
                picImage.Invalidate();
                picImage.Refresh();

                if (picImage.Parent != null)
                {
                    picImage.Parent.PerformLayout();
                    picImage.Parent.Invalidate();
                    picImage.Parent.Refresh();
                }

                this.PerformLayout();
                this.Invalidate();
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi load ảnh Part 1:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void BindOptions(List<AttemptOptionDTO> options, string chosenLabel)
        {
            var ordered = options
                .OrderBy(x => x.DisplayOrder)
                .ToList();

            var optA = ordered.FirstOrDefault(x => x.OptionLabel == "A");
            var optB = ordered.FirstOrDefault(x => x.OptionLabel == "B");
            var optC = ordered.FirstOrDefault(x => x.OptionLabel == "C");
            var optD = ordered.FirstOrDefault(x => x.OptionLabel == "D");

            rdoA.Text = "A.";
            rdoB.Text = "B.";
            rdoC.Text = "C.";
            rdoD.Text = "D.";

            rdoA.Tag = optA?.OptionLabel;
            rdoB.Tag = optB?.OptionLabel;
            rdoC.Tag = optC?.OptionLabel;
            rdoD.Tag = optD?.OptionLabel;

            rdoA.CheckedChanged -= Option_CheckedChanged;
            rdoB.CheckedChanged -= Option_CheckedChanged;
            rdoC.CheckedChanged -= Option_CheckedChanged;
            rdoD.CheckedChanged -= Option_CheckedChanged;

            rdoA.Checked = chosenLabel == "A";
            rdoB.Checked = chosenLabel == "B";
            rdoC.Checked = chosenLabel == "C";
            rdoD.Checked = chosenLabel == "D";

            rdoA.CheckedChanged += Option_CheckedChanged;
            rdoB.CheckedChanged += Option_CheckedChanged;
            rdoC.CheckedChanged += Option_CheckedChanged;
            rdoD.CheckedChanged += Option_CheckedChanged;
        }

        private void Option_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (rdo == null || !rdo.Checked || _question == null) return;

            string optionLabel = rdo.Tag?.ToString();
            if (string.IsNullOrWhiteSpace(optionLabel)) return;

            AnswerSelected?.Invoke(_question.AttemptQuestionId, optionLabel);
        }

        public void StopAudio()
        {
            try
            {
                if (wmpAudio != null)
                {
                    wmpAudio.Ctlcontrols.stop();
                    wmpAudio.URL = string.Empty;
                }

                _audioLoaded = false;

                if (_currentlyPlayingControl == this)
                {
                    _currentlyPlayingControl = null;
                }
            }
            catch
            {
            }
        }
        private void btnPlayAudio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_audioFullPath))
                    return;

                // Nếu đang có control khác phát audio thì dừng nó trước
                if (_currentlyPlayingControl != null && _currentlyPlayingControl != this)
                {
                    _currentlyPlayingControl.StopAudio();
                }

                if (!_audioLoaded)
                {
                    wmpAudio.URL = _audioFullPath;
                    wmpAudio.settings.autoStart = false;
                    _audioLoaded = true;
                }

                wmpAudio.Ctlcontrols.play();
                _currentlyPlayingControl = this;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi phát audio:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnStopAudio_Click(object sender, EventArgs e)
        {
            StopAudio();
        }
        private void ClearPicture()
        {
            try
            {
                Image oldImage = picImage.Image;
                picImage.Image = null;
                picImage.Visible = false;
                picImage.BackColor = Color.WhiteSmoke;

                if (oldImage != null)
                {
                    oldImage.Dispose();
                }
            }
            catch
            {
            }
        }
    }
}