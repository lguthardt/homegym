namespace HomeGymManager
{
    partial class HomeGymManagerForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeGymManagerForm));
            this.paPicture = new System.Windows.Forms.Panel();
            this.pbCornerTopLeft = new System.Windows.Forms.PictureBox();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRestTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paLower = new System.Windows.Forms.Panel();
            this.paTimerContainer = new System.Windows.Forms.Panel();
            this.laTimer = new System.Windows.Forms.Label();
            this.pbTimeSymbol = new System.Windows.Forms.PictureBox();
            this.paBottomMain = new System.Windows.Forms.Panel();
            this.laTimerGeneral = new System.Windows.Forms.Label();
            this.pbThumosLogo = new System.Windows.Forms.PictureBox();
            this.laMotivationText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerGeneral = new System.Windows.Forms.Timer(this.components);
            this.changeOtherSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startResetTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paTopMain = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paLeftMain = new System.Windows.Forms.Panel();
            this.btTimer = new System.Windows.Forms.Button();
            this.pbCornerBottomLeft = new System.Windows.Forms.PictureBox();
            this.paPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCornerTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            this.paLower.SuspendLayout();
            this.paTimerContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeSymbol)).BeginInit();
            this.paBottomMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumosLogo)).BeginInit();
            this.paTopMain.SuspendLayout();
            this.paLeftMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCornerBottomLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // paPicture
            // 
            this.paPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paPicture.Controls.Add(this.pbCornerTopLeft);
            this.paPicture.Controls.Add(this.pbLoading);
            this.paPicture.Controls.Add(this.pbCam);
            this.paPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paPicture.Location = new System.Drawing.Point(70, 23);
            this.paPicture.Name = "paPicture";
            this.paPicture.Size = new System.Drawing.Size(732, 619);
            this.paPicture.TabIndex = 2;
            // 
            // pbCornerTopLeft
            // 
            this.pbCornerTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbCornerTopLeft.Image")));
            this.pbCornerTopLeft.Location = new System.Drawing.Point(0, 0);
            this.pbCornerTopLeft.Name = "pbCornerTopLeft";
            this.pbCornerTopLeft.Size = new System.Drawing.Size(16, 16);
            this.pbCornerTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCornerTopLeft.TabIndex = 4;
            this.pbCornerTopLeft.TabStop = false;
            // 
            // pbLoading
            // 
            this.pbLoading.Image = global::HomeGymManager.Properties.Resources.LoadingGif;
            this.pbLoading.Location = new System.Drawing.Point(200, 164);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(343, 233);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 3;
            this.pbLoading.TabStop = false;
            // 
            // pbCam
            // 
            this.pbCam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCam.BackColor = System.Drawing.Color.Transparent;
            this.pbCam.Location = new System.Drawing.Point(13, 26);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(695, 578);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCam.TabIndex = 0;
            this.pbCam.TabStop = false;
            this.pbCam.SizeChanged += new System.EventHandler(this.pbCam_SizeChanged);
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // resetStartToolStripMenuItem
            // 
            this.resetStartToolStripMenuItem.Name = "resetStartToolStripMenuItem";
            this.resetStartToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // changeRestTimerToolStripMenuItem
            // 
            this.changeRestTimerToolStripMenuItem.Name = "changeRestTimerToolStripMenuItem";
            this.changeRestTimerToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // paLower
            // 
            this.paLower.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paLower.Controls.Add(this.pbCornerBottomLeft);
            this.paLower.Controls.Add(this.paTimerContainer);
            this.paLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paLower.Location = new System.Drawing.Point(70, 642);
            this.paLower.Name = "paLower";
            this.paLower.Size = new System.Drawing.Size(732, 98);
            this.paLower.TabIndex = 3;
            this.paLower.SizeChanged += new System.EventHandler(this.paLower_SizeChanged);
            // 
            // paTimerContainer
            // 
            this.paTimerContainer.Controls.Add(this.laTimer);
            this.paTimerContainer.Controls.Add(this.pbTimeSymbol);
            this.paTimerContainer.Location = new System.Drawing.Point(277, 6);
            this.paTimerContainer.Name = "paTimerContainer";
            this.paTimerContainer.Size = new System.Drawing.Size(138, 86);
            this.paTimerContainer.TabIndex = 3;
            // 
            // laTimer
            // 
            this.laTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.laTimer.AutoSize = true;
            this.laTimer.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTimer.ForeColor = System.Drawing.Color.White;
            this.laTimer.Location = new System.Drawing.Point(42, 22);
            this.laTimer.Name = "laTimer";
            this.laTimer.Size = new System.Drawing.Size(103, 42);
            this.laTimer.TabIndex = 1;
            this.laTimer.Text = "00:01";
            this.laTimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbTimeSymbol
            // 
            this.pbTimeSymbol.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbTimeSymbol.Image = global::HomeGymManager.Properties.Resources.Timer_Stop;
            this.pbTimeSymbol.Location = new System.Drawing.Point(11, 31);
            this.pbTimeSymbol.Name = "pbTimeSymbol";
            this.pbTimeSymbol.Size = new System.Drawing.Size(25, 25);
            this.pbTimeSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTimeSymbol.TabIndex = 2;
            this.pbTimeSymbol.TabStop = false;
            // 
            // paBottomMain
            // 
            this.paBottomMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paBottomMain.Controls.Add(this.laTimerGeneral);
            this.paBottomMain.Controls.Add(this.pbThumosLogo);
            this.paBottomMain.Controls.Add(this.laMotivationText);
            this.paBottomMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottomMain.Location = new System.Drawing.Point(70, 740);
            this.paBottomMain.Name = "paBottomMain";
            this.paBottomMain.Size = new System.Drawing.Size(732, 60);
            this.paBottomMain.TabIndex = 4;
            this.paBottomMain.SizeChanged += new System.EventHandler(this.paBottom_SizeChanged);
            // 
            // laTimerGeneral
            // 
            this.laTimerGeneral.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.laTimerGeneral.AutoSize = true;
            this.laTimerGeneral.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTimerGeneral.ForeColor = System.Drawing.Color.Silver;
            this.laTimerGeneral.Location = new System.Drawing.Point(282, 14);
            this.laTimerGeneral.Name = "laTimerGeneral";
            this.laTimerGeneral.Size = new System.Drawing.Size(125, 36);
            this.laTimerGeneral.TabIndex = 1;
            this.laTimerGeneral.Text = "00:00:01";
            this.laTimerGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pbThumosLogo
            // 
            this.pbThumosLogo.Image = global::HomeGymManager.Properties.Resources.HighThumosLogo;
            this.pbThumosLogo.Location = new System.Drawing.Point(20, 14);
            this.pbThumosLogo.Name = "pbThumosLogo";
            this.pbThumosLogo.Size = new System.Drawing.Size(51, 36);
            this.pbThumosLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThumosLogo.TabIndex = 1;
            this.pbThumosLogo.TabStop = false;
            // 
            // laMotivationText
            // 
            this.laMotivationText.AutoSize = true;
            this.laMotivationText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMotivationText.ForeColor = System.Drawing.Color.Silver;
            this.laMotivationText.Location = new System.Drawing.Point(77, 20);
            this.laMotivationText.Name = "laMotivationText";
            this.laMotivationText.Size = new System.Drawing.Size(129, 22);
            this.laMotivationText.TabIndex = 0;
            this.laMotivationText.Text = "High Thumos!";
            this.laMotivationText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerGeneral
            // 
            this.timerGeneral.Enabled = true;
            this.timerGeneral.Interval = 1000;
            this.timerGeneral.Tick += new System.EventHandler(this.timerGeneral_Tick);
            // 
            // changeOtherSettingsToolStripMenuItem
            // 
            this.changeOtherSettingsToolStripMenuItem.Name = "changeOtherSettingsToolStripMenuItem";
            this.changeOtherSettingsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.changeOtherSettingsToolStripMenuItem.Text = "Change Other Settings";
            // 
            // actionsToolStripMenuItem1
            // 
            this.actionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startResetTimerToolStripMenuItem});
            this.actionsToolStripMenuItem1.Name = "actionsToolStripMenuItem1";
            this.actionsToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem1.Text = "Actions";
            // 
            // startResetTimerToolStripMenuItem
            // 
            this.startResetTimerToolStripMenuItem.Name = "startResetTimerToolStripMenuItem";
            this.startResetTimerToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // paTopMain
            // 
            this.paTopMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paTopMain.Controls.Add(this.btClose);
            this.paTopMain.Controls.Add(this.label1);
            this.paTopMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.paTopMain.Location = new System.Drawing.Point(0, 0);
            this.paTopMain.Name = "paTopMain";
            this.paTopMain.Size = new System.Drawing.Size(802, 23);
            this.paTopMain.TabIndex = 4;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.LightGray;
            this.btClose.Location = new System.Drawing.Point(776, 0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 23);
            this.btClose.TabIndex = 11;
            this.btClose.TabStop = false;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "HGM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // paLeftMain
            // 
            this.paLeftMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paLeftMain.Controls.Add(this.btTimer);
            this.paLeftMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.paLeftMain.Location = new System.Drawing.Point(0, 23);
            this.paLeftMain.Name = "paLeftMain";
            this.paLeftMain.Size = new System.Drawing.Size(70, 777);
            this.paLeftMain.TabIndex = 5;
            // 
            // btTimer
            // 
            this.btTimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTimer.BackColor = System.Drawing.Color.Transparent;
            this.btTimer.FlatAppearance.BorderSize = 0;
            this.btTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimer.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btTimer.ForeColor = System.Drawing.Color.LightGray;
            this.btTimer.Location = new System.Drawing.Point(17, 15);
            this.btTimer.Name = "btTimer";
            this.btTimer.Size = new System.Drawing.Size(40, 40);
            this.btTimer.TabIndex = 10;
            this.btTimer.Text = "Ok";
            this.btTimer.UseVisualStyleBackColor = false;
            this.btTimer.Click += new System.EventHandler(this.btTimer_Click);
            this.btTimer.MouseEnter += new System.EventHandler(this.btTimer_MouseEnter);
            this.btTimer.MouseLeave += new System.EventHandler(this.btTimer_MouseLeave);
            // 
            // pbCornerBottomLeft
            // 
            this.pbCornerBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbCornerBottomLeft.Image = ((System.Drawing.Image)(resources.GetObject("pbCornerBottomLeft.Image")));
            this.pbCornerBottomLeft.Location = new System.Drawing.Point(0, 82);
            this.pbCornerBottomLeft.Name = "pbCornerBottomLeft";
            this.pbCornerBottomLeft.Size = new System.Drawing.Size(16, 16);
            this.pbCornerBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCornerBottomLeft.TabIndex = 5;
            this.pbCornerBottomLeft.TabStop = false;
            // 
            // HomeGymManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 800);
            this.Controls.Add(this.paPicture);
            this.Controls.Add(this.paLower);
            this.Controls.Add(this.paBottomMain);
            this.Controls.Add(this.paLeftMain);
            this.Controls.Add(this.paTopMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(16, 800);
            this.Name = "HomeGymManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home Gym Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.paPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCornerTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            this.paLower.ResumeLayout(false);
            this.paTimerContainer.ResumeLayout(false);
            this.paTimerContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeSymbol)).EndInit();
            this.paBottomMain.ResumeLayout(false);
            this.paBottomMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumosLogo)).EndInit();
            this.paTopMain.ResumeLayout(false);
            this.paTopMain.PerformLayout();
            this.paLeftMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCornerBottomLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCam;
        private System.Windows.Forms.Panel paPicture;
        private System.Windows.Forms.Panel paLower;
        private System.Windows.Forms.Panel paBottomMain;
        private System.Windows.Forms.Label laMotivationText;
        private System.Windows.Forms.Label laTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pbThumosLogo;
        private System.Windows.Forms.PictureBox pbTimeSymbol;
        private System.Windows.Forms.Panel paTimerContainer;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Timer timerGeneral;
        private System.Windows.Forms.Label laTimerGeneral;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeRestTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeOtherSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startResetTimerToolStripMenuItem;
        private System.Windows.Forms.Panel paTopMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paLeftMain;
        private System.Windows.Forms.Button btTimer;
        private System.Windows.Forms.PictureBox pbCornerTopLeft;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.PictureBox pbCornerBottomLeft;
    }
}

