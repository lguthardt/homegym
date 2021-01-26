using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeGymManager
{
    public partial class HomeGymManagerForm : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning;
        bool cameraStarted;

        int mins_RestTimer;
        int seconds_RestTimer;

        int seconds_Total;
        int mins_Total;
        int hours_Total;

        bool timerIsRunning;
        bool loadingScreenHidden;

        public HomeGymManagerForm()
        {
            InitializeComponent();

            InitCam();
            SetColors();
            InitTimer();

            CenterControl(paBottom, laTimerGeneral);
            CenterControl(paLower, paTimerContainer);
            CenterControl(paPicture, pbLoading);

            InitWindowsSizes();
        }

        private void InitWindowsSizes()
        {
            var t = Properties.Settings.Default.rightWindowPercentage;

            this.Width = (int)(Properties.Settings.Default.rightWindowPercentage * Screen.PrimaryScreen.Bounds.Width);
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new System.Drawing.Point(Screen.PrimaryScreen.Bounds.Width - this.Width + 10, 0);

            if (Properties.Settings.Default.autoDock)
            {
                InitChromeAndThisProgramSize();
            }
        }

        private void InitChromeAndThisProgramSize()
        {
            IntPtr hWndChrome = IntPtr.Zero;
            Process[] processesChrome = Process.GetProcessesByName("Chrome");
            if (processesChrome.Length > 0)
            {
                foreach (Process proc in processesChrome)
                {
                    if (proc.MainWindowHandle == IntPtr.Zero)
                        continue;
                    else
                    {
                        hWndChrome = proc.MainWindowHandle;
                        break;
                    }
                }
            }
            if (hWndChrome != IntPtr.Zero)
            {
                var moved = SetWindowPos(hWndChrome, IntPtr.Zero, -10, 0, Screen.PrimaryScreen.Bounds.Width - this.Width + 20 + 15, Screen.PrimaryScreen.Bounds.Height, 0);

                if (moved)
                {
                    SetForegroundWindow(hWndChrome);
                    SetForegroundWindow(this.Handle);
                }
            }
        }

        private void InitTimer()
        {
            SetTimerText();
        }

        private void SetTimerText()
        {
            laTimer.Text = mins_RestTimer.ToString("00") + ":" + seconds_RestTimer.ToString("00");
        }

        private void InitCam()
        {
            CaptureCamera();
            isCameraRunning = true;
        }

        private void SetColors()
        {
            this.BackColor = ColorManager.Instance.DarkLighter;
            paBottom.BackColor = ColorManager.Instance.Dark;
            paPicture.BackColor = ColorManager.Instance.DarkLighter;
            paLower.BackColor = ColorManager.Instance.DarkLighter;
        }

        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    if (!loadingScreenHidden)
                        cameraStarted = true;

                    if (cameraStarted && !loadingScreenHidden)
                    {
                        this.pbLoading?.Invoke((MethodInvoker)delegate {
                            // Running on the UI thread
                            pbLoading.Visible = false;
                        });

                        loadingScreenHidden = true;
                    }

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    if (pbCam.Image != null)
                    {
                        pbCam.Image.Dispose();
                    }

                    try
                    {
                        pbCam.Image = image;
                    }
                    catch (System.InvalidOperationException)
                    {
                        //catch error that causes outdated winforms
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCameraRunning = false;
            capture.Release();
        }

        private void CenterControl(Control parent, Control child)
        {
            int x = parent.Width / 2 - child.Width / 2;

            int y = parent.Height / 2 - child.Height / 2;

            child.Location = new System.Drawing.Point(x, y);
        }

        private void paBottom_SizeChanged(object sender, EventArgs e)
        {
            CenterControl(paBottom, laTimerGeneral);
        }

        private void paLower_SizeChanged(object sender, EventArgs e)
        {
            CenterControl(paLower, paTimerContainer);
        }

        private void pbCam_SizeChanged(object sender, EventArgs e)
        {
            if (!cameraStarted)
            {
                CenterControl(paPicture, pbLoading);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            AddSecond();
        }

        private void AddSecond()
        {
            if (seconds_RestTimer != 59)
            {
                seconds_RestTimer++;
            }
            else
            {
                mins_RestTimer++;
                seconds_RestTimer = 0;
            }

            CheckIfMaxTimerTimeReached();
        }

        private void CheckIfMaxTimerTimeReached()
        {
            if (mins_RestTimer == Properties.Settings.Default.minsRestTime &&
                            seconds_RestTimer == Properties.Settings.Default.secondsRestTime)
            {
                PlayStopSound();
                TimerStopEvent();
            }
            else
            {
                SetTimerText();
            }
        }

        private void PlayStopSound()
        {
            if (Properties.Settings.Default.playRestTimerSound)
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.StartSound);
                simpleSound.Play();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                SwitchTimer();
            }
        }

        private void SwitchTimer()
        {
            if (timerIsRunning)
            {
                TimerStopEvent();
            }
            else
            {
                TimerStartEvent();
            }
        }

        private void TimerStartEvent()
        {
            timer.Start();
            SwitchRestTimerLogo();
        }

        private void TimerStopEvent()
        {
            timer.Stop();
            mins_RestTimer = 0;
            seconds_RestTimer = 0;
            SetTimerText();

            SwitchRestTimerLogo();
        }

        private void SwitchRestTimerLogo()
        {
            if (timerIsRunning)
            {
                timerIsRunning = false;
                pbTimeSymbol.Image = Properties.Resources.Timer_Stop;
            }
            else
            {
                timerIsRunning = true;
                pbTimeSymbol.Image = Properties.Resources.Timer;
            }
        }

        private void timerGeneral_Tick(object sender, EventArgs e)
        {
            if (seconds_Total != 59)
            {
                seconds_Total++;
            }
            else if (mins_Total != 59)
            {
                mins_Total++;
                seconds_Total = 0;
            }
            else
            {
                hours_Total++;
                seconds_Total = 0;
                mins_Total = 0;
            }

            SetTimerTextGeneral();
        }

        private void SetTimerTextGeneral()
        {
            laTimerGeneral.Text = hours_Total.ToString("00") + ":" + mins_Total.ToString("00") + ":" + seconds_Total.ToString("00");
        }

        private void resetStartTimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitchTimer();
        }

        private void changeRestTimerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var changeTimerForm = new ChangeRestTimer();
            changeTimerForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();

            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                InitWindowsSizes();
            }
        }

        private void changeRestTimerSoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var changeRestSound = new ChangeRestSound();
            changeRestSound.ShowDialog();
        }
    }
}
