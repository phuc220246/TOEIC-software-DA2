using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TOEIC_Practice.DTO.LamBai;
using TOEIC_Practice.Helpers;

namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    public partial class UcP2_SingleQuestion : UserControl
    {
        public event Action<int, string> AnswerSelected;

        private AttemptQuestionDTO _question;
        private List<AttemptOptionDTO> _options;

        private string _audioFullPath = "";
        private bool _audioLoaded = false;

        private static UcP2_SingleQuestion _currentlyPlayingControl = null;

        public UcP2_SingleQuestion()
        {
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            rdoA.CheckedChanged += Option_CheckedChanged;
            rdoB.CheckedChanged += Option_CheckedChanged;
            rdoC.CheckedChanged += Option_CheckedChanged;

            btnPlayAudio.Click += btnPlayAudio_Click;
            btnStopAudio.Click += btnStopAudio_Click;

            try
            {
                wmpAudio.settings.autoStart = false;
                wmpAudio.uiMode = "none";
                wmpAudio.stretchToFit = false;
            }
            catch
            {
            }
        }

        public void BindData(
            AttemptQuestionDTO question,
            List<AttemptOptionDTO> options,
            string audioRootFolder)
        {
            _question = question;
            _options = options ?? new List<AttemptOptionDTO>();

            lblQuestionNo.Text = question.OrderNo.ToString();

            BindAudio(question, audioRootFolder);
            BindOptions(_options, question.ChosenOptionLabel);
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
                    "Lỗi load audio Part 2:\n" + ex.Message,
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

            rdoA.Text = "A.";
            rdoB.Text = "B.";
            rdoC.Text = "C.";

            rdoA.Tag = optA?.OptionLabel;
            rdoB.Tag = optB?.OptionLabel;
            rdoC.Tag = optC?.OptionLabel;

            rdoA.CheckedChanged -= Option_CheckedChanged;
            rdoB.CheckedChanged -= Option_CheckedChanged;
            rdoC.CheckedChanged -= Option_CheckedChanged;

            rdoA.Checked = chosenLabel == "A";
            rdoB.Checked = chosenLabel == "B";
            rdoC.Checked = chosenLabel == "C";

            rdoA.CheckedChanged += Option_CheckedChanged;
            rdoB.CheckedChanged += Option_CheckedChanged;
            rdoC.CheckedChanged += Option_CheckedChanged;
        }

        private void Option_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = sender as RadioButton;
            if (rdo == null || !rdo.Checked || _question == null) return;

            string optionLabel = rdo.Tag?.ToString();
            if (string.IsNullOrWhiteSpace(optionLabel)) return;

            AnswerSelected?.Invoke(_question.AttemptQuestionId, optionLabel);
        }

        private void btnPlayAudio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_audioFullPath))
                    return;

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

        //protected override void Dispose(bool disposing)
        //{
        //    try
        //    {
        //        if (_currentlyPlayingControl == this)
        //        {
        //            _currentlyPlayingControl = null;
        //        }

        //        if (disposing)
        //        {
        //            components?.Dispose();
        //        }
        //    }
        //    finally
        //    {
        //        base.Dispose(disposing);
        //    }
        //}
    }
}