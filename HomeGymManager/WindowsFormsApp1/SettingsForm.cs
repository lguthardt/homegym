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

        Dictionary<string, IntPtr> AllWindowsDic = new Dictionary<string, IntPtr>();
        List<string> NotWantedWindows = new List<string>();

        bool InitValuesState = false;
        string SelectedWindowName = "";

        public SettingsForm()
        {
            InitializeComponent();

            InitValuesState = true;

            InitColors();
            InitValues();

            CenterControl(paTop, laTimerGeneral);
            CenterControl(paContainer, paScreenWannabe);
            CenterControl(paMain, label1, false);

            InitNotWantedWindows();
            InitGetAllProcesses();

            InitValuesState = false;
        }

        private void InitNotWantedWindows()
        {
            NotWantedWindows.Add("Time");
            NotWantedWindows.Add("SystemSettings");
            NotWantedWindows.Add("WindowsInternal.ComposableShell.Experiences.TextInput.InputApp");
            NotWantedWindows.Add("ApplicationFrameHost");
            NotWantedWindows.Add("devenv");
        }

        private void InitGetAllProcesses()
        {
            AllWindowsDic.Clear();

            Process[] processes = Process.GetProcesses();
            if (processes.Length > 0)
            {
                foreach (Process p in processes)
                {
                    if (!String.IsNullOrEmpty(p.MainWindowTitle))
                    {
                        if (!NotWantedWindows.Contains(p.ProcessName))
                        {
                            AllWindowsDic.Add(p.ProcessName.FirstCharToUpper(), p.MainWindowHandle);
                        }
                    }
                }
            }

            InitComboBox();
        }

        private void InitComboBox()
        {
            foreach (var p  in AllWindowsDic.Keys.ToList())
            {
                cobPrograms.Items.Add(p);
            }

            cobPrograms.SelectedIndex = cobPrograms.Items.IndexOf(Properties.Settings.Default.dockWindowName);
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
            cobPrograms.BackColor = ColorManager.Instance.DarkLighter;
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
            Properties.Settings.Default.dockWindowName = SelectedWindowName;

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

        private void cobPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedWindowName = cobPrograms.SelectedItem.ToString();
        }
    }
}
