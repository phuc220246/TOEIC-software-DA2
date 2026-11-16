using System;
using System.Windows.Forms;

namespace TOEIC_Practice.GUI.UserControls.LamBai
{
    public partial class UcAudioPlayerSimple : UserControl
    {
        private string _audioFullPath = "";
        private bool _audioLoaded = false;

        private static UcAudioPlayerSimple _currentlyPlayingControl = null;

        public UcAudioPlayerSimple()
        {
            InitializeComponent();
            InitUi();
        }

        private void InitUi()
        {
            btnPlayAudio.Click += btnPlayAudio_Click;
            btnStopAudio.Click += btnStopAudio_Click;

            try
            {
                wmpAudio.settings.autoStart = false;
                wmpAudio.uiMode = "none";
                wmpAudio.stretchToFit = false;
                wmpAudio.Visible = false;
            }
            catch
            {
            }
        }

        public void SetAudioPath(string fullAudioPath)
        {
            StopAudio();

            _audioFullPath = fullAudioPath ?? "";
            _audioLoaded = false;
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

    }
}