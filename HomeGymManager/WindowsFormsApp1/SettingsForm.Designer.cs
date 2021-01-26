namespace HomeGymManager
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.laTimerGeneral = new System.Windows.Forms.Label();
            this.paTop = new System.Windows.Forms.Panel();
            this.paMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paContainer = new System.Windows.Forms.Panel();
            this.paScreenWannabe = new System.Windows.Forms.Panel();
            this.paLeft = new System.Windows.Forms.Panel();
            this.laLeft = new System.Windows.Forms.Label();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.paRight = new System.Windows.Forms.Panel();
            this.laRight = new System.Windows.Forms.Label();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.laDockDescription = new System.Windows.Forms.Label();
            this.cbDocking = new System.Windows.Forms.CheckBox();
            this.paBottom = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.paTop.SuspendLayout();
            this.paMain.SuspendLayout();
            this.paContainer.SuspendLayout();
            this.paScreenWannabe.SuspendLayout();
            this.paLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.paRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.paBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTimerGeneral
            // 
            this.laTimerGeneral.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.laTimerGeneral.AutoSize = true;
            this.laTimerGeneral.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTimerGeneral.ForeColor = System.Drawing.Color.LightGray;
            this.laTimerGeneral.Location = new System.Drawing.Point(180, 31);
            this.laTimerGeneral.Name = "laTimerGeneral";
            this.laTimerGeneral.Size = new System.Drawing.Size(384, 36);
            this.laTimerGeneral.TabIndex = 2;
            this.laTimerGeneral.Text = "Change the dock settings";
            this.laTimerGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // paTop
            // 
            this.paTop.Controls.Add(this.laTimerGeneral);
            this.paTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTop.Location = new System.Drawing.Point(0, 0);
            this.paTop.Name = "paTop";
            this.paTop.Size = new System.Drawing.Size(762, 99);
            this.paTop.TabIndex = 3;
            // 
            // paMain
            // 
            this.paMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paMain.BackColor = System.Drawing.Color.Gray;
            this.paMain.Controls.Add(this.label1);
            this.paMain.Controls.Add(this.paContainer);
            this.paMain.Controls.Add(this.laDockDescription);
            this.paMain.Controls.Add(this.cbDocking);
            this.paMain.Controls.Add(this.paBottom);
            this.paMain.Controls.Add(this.paTop);
            this.paMain.Location = new System.Drawing.Point(3, 3);
            this.paMain.Name = "paMain";
            this.paMain.Size = new System.Drawing.Size(762, 725);
            this.paMain.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(170, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change the docking size for your screen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // paContainer
            // 
            this.paContainer.BackColor = System.Drawing.Color.Transparent;
            this.paContainer.Controls.Add(this.paScreenWannabe);
            this.paContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paContainer.Location = new System.Drawing.Point(0, 313);
            this.paContainer.Name = "paContainer";
            this.paContainer.Size = new System.Drawing.Size(762, 353);
            this.paContainer.TabIndex = 11;
            // 
            // paScreenWannabe
            // 
            this.paScreenWannabe.BackColor = System.Drawing.Color.DimGray;
            this.paScreenWannabe.Controls.Add(this.paLeft);
            this.paScreenWannabe.Controls.Add(this.splitter1);
            this.paScreenWannabe.Controls.Add(this.paRight);
            this.paScreenWannabe.Location = new System.Drawing.Point(118, 19);
            this.paScreenWannabe.Name = "paScreenWannabe";
            this.paScreenWannabe.Size = new System.Drawing.Size(538, 303);
            this.paScreenWannabe.TabIndex = 0;
            // 
            // paLeft
            // 
            this.paLeft.BackColor = System.Drawing.Color.Transparent;
            this.paLeft.Controls.Add(this.laLeft);
            this.paLeft.Controls.Add(this.pbLeft);
            this.paLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paLeft.Location = new System.Drawing.Point(0, 0);
            this.paLeft.Name = "paLeft";
            this.paLeft.Size = new System.Drawing.Size(201, 303);
            this.paLeft.TabIndex = 2;
            this.paLeft.SizeChanged += new System.EventHandler(this.paLeft_SizeChanged);
            // 
            // laLeft
            // 
            this.laLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.laLeft.AutoSize = true;
            this.laLeft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laLeft.ForeColor = System.Drawing.Color.LightGray;
            this.laLeft.Location = new System.Drawing.Point(79, 271);
            this.laLeft.Name = "laLeft";
            this.laLeft.Size = new System.Drawing.Size(56, 21);
            this.laLeft.TabIndex = 4;
            this.laLeft.Text = "600px";
            this.laLeft.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbLeft
            // 
            this.pbLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbLeft.Image")));
            this.pbLeft.Location = new System.Drawing.Point(0, 98);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(199, 101);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLeft.TabIndex = 0;
            this.pbLeft.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Silver;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(201, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 303);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // paRight
            // 
            this.paRight.BackColor = System.Drawing.Color.Transparent;
            this.paRight.Controls.Add(this.laRight);
            this.paRight.Controls.Add(this.pbRight);
            this.paRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.paRight.Location = new System.Drawing.Point(204, 0);
            this.paRight.Name = "paRight";
            this.paRight.Size = new System.Drawing.Size(334, 303);
            this.paRight.TabIndex = 0;
            this.paRight.SizeChanged += new System.EventHandler(this.paRight_SizeChanged);
            // 
            // laRight
            // 
            this.laRight.AutoSize = true;
            this.laRight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRight.ForeColor = System.Drawing.Color.LightGray;
            this.laRight.Location = new System.Drawing.Point(144, 271);
            this.laRight.Name = "laRight";
            this.laRight.Size = new System.Drawing.Size(56, 21);
            this.laRight.TabIndex = 5;
            this.laRight.Text = "600px";
            this.laRight.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbRight
            // 
            this.pbRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRight.Image = global::HomeGymManager.Properties.Resources.thumoslogo;
            this.pbRight.Location = new System.Drawing.Point(0, 98);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(334, 101);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRight.TabIndex = 1;
            this.pbRight.TabStop = false;
            // 
            // laDockDescription
            // 
            this.laDockDescription.AutoSize = true;
            this.laDockDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDockDescription.ForeColor = System.Drawing.Color.Silver;
            this.laDockDescription.Location = new System.Drawing.Point(40, 160);
            this.laDockDescription.MaximumSize = new System.Drawing.Size(450, 0);
            this.laDockDescription.Name = "laDockDescription";
            this.laDockDescription.Size = new System.Drawing.Size(432, 63);
            this.laDockDescription.TabIndex = 10;
            this.laDockDescription.Text = "Changing the size of chrome automatically only works when Chrome is not in Full S" +
    "creen mode, it has to be smaller than the screen, so it can be adjusted";
            this.laDockDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDocking
            // 
            this.cbDocking.AutoSize = true;
            this.cbDocking.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocking.ForeColor = System.Drawing.Color.LightGray;
            this.cbDocking.Location = new System.Drawing.Point(44, 129);
            this.cbDocking.Name = "cbDocking";
            this.cbDocking.Size = new System.Drawing.Size(501, 28);
            this.cbDocking.TabIndex = 8;
            this.cbDocking.Text = "Automatically dock Chrome and this program";
            this.cbDocking.UseVisualStyleBackColor = true;
            // 
            // paBottom
            // 
            this.paBottom.BackColor = System.Drawing.Color.DimGray;
            this.paBottom.Controls.Add(this.btCancel);
            this.paBottom.Controls.Add(this.btOk);
            this.paBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom.Location = new System.Drawing.Point(0, 666);
            this.paBottom.Name = "paBottom";
            this.paBottom.Size = new System.Drawing.Size(762, 59);
            this.paBottom.TabIndex = 7;
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btCancel.Location = new System.Drawing.Point(635, 9);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(118, 41);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            this.btCancel.MouseEnter += new System.EventHandler(this.btCancel_MouseEnter);
            this.btCancel.MouseLeave += new System.EventHandler(this.btCancel_MouseLeave);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.BackColor = System.Drawing.Color.Transparent;
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btOk.ForeColor = System.Drawing.Color.LightGray;
            this.btOk.Location = new System.Drawing.Point(511, 9);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(118, 41);
            this.btOk.TabIndex = 9;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            this.btOk.MouseEnter += new System.EventHandler(this.btOk_MouseEnter);
            this.btOk.MouseLeave += new System.EventHandler(this.btOk_MouseLeave);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(768, 731);
            this.Controls.Add(this.paMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRestTimer";
            this.paTop.ResumeLayout(false);
            this.paTop.PerformLayout();
            this.paMain.ResumeLayout(false);
            this.paMain.PerformLayout();
            this.paContainer.ResumeLayout(false);
            this.paScreenWannabe.ResumeLayout(false);
            this.paLeft.ResumeLayout(false);
            this.paLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.paRight.ResumeLayout(false);
            this.paRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.paBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laTimerGeneral;
        private System.Windows.Forms.Panel paTop;
        private System.Windows.Forms.Panel paMain;
        private System.Windows.Forms.Panel paBottom;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.CheckBox cbDocking;
        private System.Windows.Forms.Label laDockDescription;
        private System.Windows.Forms.Panel paContainer;
        private System.Windows.Forms.Panel paScreenWannabe;
        private System.Windows.Forms.Panel paLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel paRight;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laLeft;
        private System.Windows.Forms.Label laRight;
    }
}