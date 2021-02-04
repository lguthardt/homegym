using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeGymManager
{
    public partial class ChangeRestSoundForm : Form
    {
        public ChangeRestSoundForm()
        {
            InitializeComponent();

            InitColors();
            CenterControl(panel1, laTimerGeneral);
            InitValues();
        }

        private void InitValues()
        {
            cbSound.Checked = Properties.Settings.Default.playRestTimerSound;
        }

        private void InitColors()
        {
            this.BackColor = ColorManager.Instance.Dark;
            panel2.BackColor = ColorManager.Instance.DarkLighter;
            panel3.BackColor = ColorManager.Instance.Dark;
        }

        private void CenterControl(Control parent, Control child)
        {
            int x = parent.Width / 2 - child.Width / 2;

            int y = parent.Height / 2 - child.Height / 2;

            child.Location = new System.Drawing.Point(x, y);
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.playRestTimerSound = cbSound.Checked;

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

        private void ChangeRestSound_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
