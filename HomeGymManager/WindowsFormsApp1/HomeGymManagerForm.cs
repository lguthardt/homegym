﻿using OpenCvSharp;
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
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace HomeGymManager
{
    public struct WINDOWPLACEMENT
    {
        public int length;
        public uint flags;
        public uint showCmd;
        public System.Drawing.Point ptMinPosition;
        public System.Drawing.Point ptMaxPosition;
        public System.Drawing.Rectangle rcNormalPosition;
    }

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

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        const uint SW_HIDE = 0;
        const uint SW_MAXIMIZE = 3;
        const uint SW_MINIMIZE = 6;
        const uint SW_RESTORE = 9;
        const uint SW_SHOW = 5;
        const uint SW_SHOWMAXIMIZED = 3;
        const uint SW_SHOWMINIMIZED = 2;
        const uint SW_SHOWMINNOACTIVE = 7;
        const uint SW_SHOWNA = 8;
        const uint SW_SHOWNOACTIVATE = 4;
        const uint SW_SHOWNORMAL = 1;

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
        private int cameraImageHeight;
        private int cameraImageWidth;

        public bool Recording { get; private set; }
        public bool MessagePopupShown { get; private set; }
        public int CurrentPopupTime { get; private set; }
        public int PopupShowDuration { get; private set; }
        public int PopupMinutesChange { get; private set; }
        public int PopupSecondsChange { get; private set; }

        public HomeGymManagerForm()
        {
            InitializeComponent();

            InitCam();
            InitTimer();
            InitControlValues();

            SetColors();

            CenterControl(paBottomMain, laTimerGeneral);
            CenterControl(paLower, paTimerContainer);
            CenterControl(paPicture, pbLoading);

            InitWindowsSizes();

            InitTooltip();
        }

        private void InitTooltip()
        {   
            //maybe use tooltips one day

            //var tooltip = new ToolTip();
            //tooltip.AutomaticDelay = 1000;
            //tooltip.OwnerDraw = true;
            //tooltip.Draw += Tooltip_Draw;

            //tooltip.BackColor = ColorManager.Instance.Medium;
            //tooltip.ForeColor = Color.LightGray;
            //tooltip.SetToolTip(pbTimer, "Start/Stop the time" + "     SPACE");
        }

        private void Tooltip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            //e.DrawBorder();
            e.DrawText();
        }

        private void InitControlValues()
        {
            int padding = pbCornerTopLeft.Width;

            paLeftMainTopCornerPadding.Height = padding;

            pbCam.Location = new Point(padding, padding);
            pbCam.Width = paPicture.Width - padding * 2;
            pbCam.Height = paPicture.Height - padding * 2;
        }

        private void InitWindowsSizes()
        {
            if (Properties.Settings.Default.autoDock)
            {
                SetThisProgramAndOtherProgramSizeLocation();
            }
        }

        private Size GetThisWindowSize()
        {
            int w = (int)(Properties.Settings.Default.rightWindowPercentage * Screen.PrimaryScreen.Bounds.Width);
            int h = Screen.PrimaryScreen.WorkingArea.Height;

            return new System.Drawing.Size(w, h);
        }

        private Size GetOtherWindowSize()
        {
            int w = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int h = this.Height;

            if (Properties.Settings.Default.dockWindowName.ToLower() == "chrome")
            {
                w += 8;
                h += 8;
            }

            return new System.Drawing.Size(w, h);
        }

        private Point GetThisWindowLocation()
        {
            int x = Screen.PrimaryScreen.Bounds.Width - this.Width;
            int y = 0;

            return new Point(x, y);
        }

        private Point GetOtherWindowLocation()
        {
            int x = 0;
            int y = 0;

            if (Properties.Settings.Default.dockWindowName.ToLower() == "chrome")
            {
                x = -8;
            }

            return new Point(x, y);
        }

        private void SetThisProgramAndOtherProgramSizeLocation()
        {
            this.Width = GetThisWindowSize().Width;
            this.Height = GetThisWindowSize().Height;
            this.Location = GetThisWindowLocation();

            SetOtherProgramSizeLocation();
        }

        private void SetOtherProgramSizeLocation()
        {
            IntPtr hWndChrome = IntPtr.Zero;
            Process[] processes = Process.GetProcessesByName(Properties.Settings.Default.dockWindowName);
            if (processes.Length > 0)
            {
                foreach (Process proc in processes)
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
                WINDOWPLACEMENT windowPos = new WINDOWPLACEMENT();
                if (GetWindowPlacement(hWndChrome, ref windowPos))
                {
                    windowPos.showCmd = SW_SHOWNORMAL;
                    windowPos.rcNormalPosition = new Rectangle(GetOtherWindowLocation(), GetOtherWindowSize());

                    if (SetWindowPlacement(hWndChrome, ref windowPos))
                    {
                        SetForegroundWindow(hWndChrome);
                        SetForegroundWindow(this.Handle);
                    }
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
            //normal colors
            this.BackColor = ColorManager.Instance.DarkLighter;
            paTopMain.BackColor = ColorManager.Instance.Dark;
            paLeftMain.BackColor = ColorManager.Instance.Dark;
            paLeftMainTopCornerPadding.BackColor = ColorManager.Instance.Dark;
            paBottomMain.BackColor = ColorManager.Instance.Dark;

            paPicture.BackColor = ColorManager.Instance.DarkLighter;
            paLower.BackColor = ColorManager.Instance.DarkLighter;

            //other colors
            //this.BackColor = ColorManager.Instance.DarkLighter;
            //paTopMain.BackColor = ColorManager.Instance.Dark;
            //paLeftMain.BackColor = ColorManager.Instance.Dark;
            //paLeftMainTopCornerPadding.BackColor = ColorManager.Instance.Dark;
            //paBottomMain.BackColor = ColorManager.Instance.DarkLighter;

            //paPicture.BackColor = ColorManager.Instance.Medium;
            //paLower.BackColor = ColorManager.Instance.Medium;
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

                    try
                    {
                        if (cameraStarted && !loadingScreenHidden)
                        {
                            this.pbLoading?.Invoke((MethodInvoker)delegate {
                                // Running on the UI thread
                                pbLoading.Visible = false;
                            });

                            loadingScreenHidden = true;
                        }
                    }
                    catch (Exception)
                    {

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
                        cameraImageHeight = image.Height;
                        cameraImageWidth = image.Width;
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
            CenterControl(paBottomMain, laTimerGeneral);
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
            else if (e.KeyData == (Keys.Control | Keys.Oemplus))
            {
                AdjustResttimerShortcutEvent(15, true);
            }
            else if (e.KeyData == (Keys.Control | Keys.OemMinus))
            {
                AdjustResttimerShortcutEvent(15, false);
            }
            else if (e.KeyData == (Keys.Control | Keys.D))
            {
                ShowDockForm();
            }
            else if (e.KeyData == (Keys.Control | Keys.T))
            {
                ShowTimeForm();
            }
            else if (e.KeyData == (Keys.Control | Keys.S))
            {
                ShowRestSoundForm();
            }
        }

        private void AdjustResttimerShortcutEvent(int change, bool add)
        {
            int m = Properties.Settings.Default.minsRestTime;
            int s = Properties.Settings.Default.secondsRestTime;

            var time = GetTimeFromAddSeconds(m, s, change, add);

            bool didNotChange = false;
            if (m == time.Item1 && s == time.Item2)
                didNotChange = true;

            Properties.Settings.Default.secondsRestTime = time.Item2;
            Properties.Settings.Default.minsRestTime = time.Item1;

            ShowMessagePopup(m, s, change, add, didNotChange);
        }

        private void ShowMessagePopup(int m, int s, int change, bool add, bool didNotChange)
        {
            if (!MessagePopupShown)
            {
                MessagePopupShown = true;
                paPopup.Visible = true;
                timerPopUp.Start();
            }

            ChangeMessagePopup(m, s, change, add, didNotChange);
        }

        Tuple<int, int> GetTimeFromAddSeconds(int m, int s, int change, bool add, bool allowNegative = false)
        {
            if (add)
            {
                //add when below 0
                if (m < 0 || s < 0)
                {
                    if (s < - 15)
                    {
                        s += 15;
                    }
                    else
                    {
                        m++;
                        s = 60 - change;
                    }
                }

                //add when above 0
                if (s < 45)
                    s += change;
                else
                {
                    m++;
                    s += change - 60;
                }
            }
            else
            {
                //subtract when below 0
                if (!allowNegative)
                {
                    if (s >= change)
                        s -= change;
                    else
                    {
                        if (m != 0)
                        {
                            m--;
                            s = s - change + 60;
                        }
                    }
                }
                else
                {
                    //subtract when above 0
                    if (s == 0)
                    {
                        s = - change;
                    }
                    else if (s > -45 && s != 0)
                        s -= change;
                    else
                    {
                        m--;
                        s = s - change + 60;
                    }
                }
            }

            return new Tuple<int, int>(m, s);
        }

        private void ChangeMessagePopup(int m, int s, int change, bool add, bool didNotChange)
        {
            CurrentPopupTime = 0;
            PopupShowDuration = 30;

            if (!didNotChange)
            {
                var time = GetTimeFromAddSeconds(PopupMinutesChange, PopupSecondsChange, change, add, true);

                PopupMinutesChange = time.Item1;
                PopupSecondsChange = time.Item2;

                string sign = "";
                if (PopupMinutesChange < 0 || PopupSecondsChange < 0)
                {
                    sign = "- ";
                    laPopupRestTimerDiff.ForeColor = ColorManager.Instance.Error;

                    string min;
                    if (PopupMinutesChange < 0)
                        min = (PopupMinutesChange * (-1)).ToString("00");
                    else
                        min = PopupMinutesChange.ToString("00");

                    string sec;
                    if (PopupSecondsChange < 0)
                        sec = (PopupSecondsChange * (-1)).ToString("00");
                    else
                        sec = PopupSecondsChange.ToString("00");

                    laPopupRestTimerDiff.Text = sign + min + ":" + sec ;
                }
                else
                {
                    sign = "+ ";
                    laPopupRestTimerDiff.ForeColor = ColorManager.Instance.Green;
                    laPopupRestTimerDiff.Text = sign + PopupMinutesChange.ToString("00") + ":" + PopupSecondsChange.ToString("00"); ;
                }

                laPopupRestTimer.Text = Properties.Settings.Default.minsRestTime.ToString("00") + ":" + Properties.Settings.Default.secondsRestTime.ToString("00");
            }
        }

        private void ShowRestSoundForm()
        {
            var soundForm = new ChangeRestSound();
            soundForm.ShowDialog();
        }

        private void ShowTimeForm()
        {
            var timerForm = new ChangeRestTimer();
            timerForm.ShowDialog();
        }

        private void ShowDockForm()
        {
            var dockForm = new SettingsForm();

            if (dockForm.ShowDialog() == DialogResult.OK)
            {
                InitWindowsSizes();
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
                pbTimer.Image = Properties.Resources.Timer_Stop_smaller;
            }
            else
            {
                timerIsRunning = true;
                pbTimeSymbol.Image = Properties.Resources.Timer;
                pbTimer.Image = Properties.Resources.Timer_smaller;
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

        private void pbSettings_MouseEnter(object sender, EventArgs e)
        {
            var c = (Control)sender;
            c.BackColor = ColorManager.Instance.DarkLighter;
        }

        private void pbSettings_MouseLeave(object sender, EventArgs e)
        {
            var c = (Control)sender;
            c.BackColor = ColorManager.Instance.Dark;
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackColor = ColorManager.Instance.Error;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackColor = ColorManager.Instance.Dark;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbTimer_Click(object sender, EventArgs e)
        {
            SwitchTimer();
        }

        private void pbRecord_Click(object sender, EventArgs e)
        {
            SwitchRecording();
        }

        private void SwitchRecording()
        {
            if (!Recording)
            {
                Recording = true;

                pbRecord.Image = Properties.Resources.StopRecording;
            }
            else
            {
                Recording = false;

                pbRecord.Image = Properties.Resources.Record;
            }
        }

        private void pbRestSound_Click(object sender, EventArgs e)
        {
            ShowRestSoundForm();
        }

        private void pbRestTimer_Click(object sender, EventArgs e)
        {
            ShowTimeForm(); 
        }

        private void pbDocking_Click(object sender, EventArgs e)
        {
            ShowDockForm();
        }

        private void timerPopUp_Tick(object sender, EventArgs e)
        {
            CurrentPopupTime += 1;

            if (CurrentPopupTime == PopupShowDuration)
            {
                timerPopUp.Stop();
                paPopup.Visible = false;
                MessagePopupShown = false;
                CurrentPopupTime = 0;
                PopupMinutesChange = 0;
                PopupSecondsChange = 0;

                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
        }
    }
}
