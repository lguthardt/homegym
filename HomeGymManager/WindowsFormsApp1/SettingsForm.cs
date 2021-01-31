using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeGymManager
{
    public partial class SettingsForm : Form
    {
        public double RightPercentage { get; set; }

        public SettingsForm()
        {
            InitializeComponent();

            InitColors();
            InitValues();

            CenterControl(paTop, laTimerGeneral);
            CenterControl(paContainer, paScreenWannabe);
            CenterControl(paMain, label1, false);

            InitGetAllProcesses();
        }

        private void InitGetAllProcesses()
        {
            List<IntPtr> mainHWnd = new List<IntPtr>();
            List<string> notWantedWindows = new List<string>();
            notWantedWindows.Add("Time");
            notWantedWindows.Add("SystemSettings");
            notWantedWindows.Add("WindowsInternal.ComposableShell.Experiences.TextInput.InputApp");
            notWantedWindows.Add("ApplicationFrameHost");

            Process[] processes = Process.GetProcesses();
            if (processes.Length > 0)
            {
                foreach (Process p in processes)
                {
                    if (!String.IsNullOrEmpty(p.MainWindowTitle))
                    {
                        if (!notWantedWindows.Contains(p.ProcessName))
                        {
                            mainHWnd.Add(p.MainWindowHandle);
                        }
                    }
                }
            }
        }

        private void InitValues()
        {
            cbDocking.Checked = Properties.Settings.Default.autoDock;

            double relativeRightWidth = Properties.Settings.Default.rightWindowPercentage * (double)paScreenWannabe.Width;
            double relativeLeftWidth = paScreenWannabe.Width - relativeRightWidth;

            splitter1.SplitPosition = (int)relativeRightWidth;
        }

        private void InitColors()
        {
            this.BackColor = ColorManager.Instance.Dark;
            paMain.BackColor = ColorManager.Instance.DarkLighter;
            paBottom.BackColor = ColorManager.Instance.Dark;
            paScreenWannabe.BackColor = ColorManager.Instance.Medium;
        }

        private void CenterControl(Control parent, Control child, bool changeHeight = true)
        {
            int x = parent.Width / 2 - child.Width / 2;

            int y = child.Location.Y;

            if (changeHeight)
            {
                y = parent.Height / 2 - child.Height / 2;
            }

            child.Location = new System.Drawing.Point(x, y);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoDock = cbDocking.Checked;
            Properties.Settings.Default.rightWindowPercentage = RightPercentage;

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            DialogResult = DialogResult.OK;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btOk_MouseEnter(object sender, EventArgs e)
        {
            btOk.BackColor = ColorManager.Instance.DarkLighter;
        }

        private void btOk_MouseLeave(object sender, EventArgs e)
        {
            btOk.BackColor = ColorManager.Instance.Dark;
        }

        private void btCancel_MouseEnter(object sender, EventArgs e)
        {
            btCancel.BackColor = ColorManager.Instance.DarkLighter;
        }

        private void btCancel_MouseLeave(object sender, EventArgs e)
        {
            btCancel.BackColor = ColorManager.Instance.Dark;
        }

        private void paLeft_SizeChanged(object sender, EventArgs e)
        {
            CenterControl(paLeft, laLeft, false);
        }

        private void UpdateDockSizeLabels()
        {
            RightPercentage = (double)paRight.Width / (double)paScreenWannabe.Width;

            double rightWidth = (double)Screen.PrimaryScreen.Bounds.Width * RightPercentage;
            double leftWidth = Screen.PrimaryScreen.Bounds.Width - rightWidth;

            laRight.Text = ((int)rightWidth).ToString() + "px";
            laLeft.Text = ((int)leftWidth).ToString() + "px";
        }

        private void paRight_SizeChanged(object sender, EventArgs e)
        {
            UpdateDockSizeLabels();

            CenterControl(paRight, laRight, false);
        }
    }
}
