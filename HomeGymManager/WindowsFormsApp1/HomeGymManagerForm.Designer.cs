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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStartTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRestTimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRestTimerSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adjustLogoAndTexInLefBottomCornerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tellMeOtherSuggestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeRestTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paLower = new System.Windows.Forms.Panel();
            this.paTimerContainer = new System.Windows.Forms.Panel();
            this.laTimer = new System.Windows.Forms.Label();
            this.paBottom = new System.Windows.Forms.Panel();
            this.laTimerGeneral = new System.Windows.Forms.Label();
            this.laMotivationText = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerGeneral = new System.Windows.Forms.Timer(this.components);
            this.changeOtherSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startResetTimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.pbCam = new System.Windows.Forms.PictureBox();
            this.pbTimeSymbol = new System.Windows.Forms.PictureBox();
            this.pbThumosLogo = new System.Windows.Forms.PictureBox();
            this.recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paPicture.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.paLower.SuspendLayout();
            this.paTimerContainer.SuspendLayout();
            this.paBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeSymbol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumosLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // paPicture
            // 
            this.paPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.paPicture.Controls.Add(this.pbLoading);
            this.paPicture.Controls.Add(this.pbCam);
            this.paPicture.Controls.Add(this.menuStrip1);
            this.paPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paPicture.Location = new System.Drawing.Point(0, 0);
            this.paPicture.Name = "paPicture";
            this.paPicture.Size = new System.Drawing.Size(695, 584);
            this.paPicture.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem2,
            this.optionsToolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem2
            // 
            this.actionsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetStartTimerToolStripMenuItem});
            this.actionsToolStripMenuItem2.Name = "actionsToolStripMenuItem2";
            this.actionsToolStripMenuItem2.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem2.Text = "Actions";
            // 
            // resetStartTimerToolStripMenuItem
            // 
            this.resetStartTimerToolStripMenuItem.Name = "resetStartTimerToolStripMenuItem";
            this.resetStartTimerToolStripMenuItem.ShortcutKeyDisplayString = "Space";
            this.resetStartTimerToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.resetStartTimerToolStripMenuItem.Text = "Reset / Start Timer";
            this.resetStartTimerToolStripMenuItem.Click += new System.EventHandler(this.resetStartTimerToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem2
            // 
            this.optionsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeRestTimerToolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.changeRestTimerSoundToolStripMenuItem,
            this.adjustLogoAndTexInLefBottomCornerToolStripMenuItem,
            this.recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem,
            this.tellMeOtherSuggestionsToolStripMenuItem});
            this.optionsToolStripMenuItem2.Name = "optionsToolStripMenuItem2";
            this.optionsToolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem2.Text = "Options";
            // 
            // changeRestTimerToolStripMenuItem1
            // 
            this.changeRestTimerToolStripMenuItem1.Name = "changeRestTimerToolStripMenuItem1";
            this.changeRestTimerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.changeRestTimerToolStripMenuItem1.Size = new System.Drawing.Size(587, 22);
            this.changeRestTimerToolStripMenuItem1.Text = "Change Rest Timer";
            this.changeRestTimerToolStripMenuItem1.Click += new System.EventHandler(this.changeRestTimerToolStripMenuItem1_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(587, 22);
            this.settingsToolStripMenuItem.Text = "Change Window Docking Size";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click_1);
            // 
            // changeRestTimerSoundToolStripMenuItem
            // 
            this.changeRestTimerSoundToolStripMenuItem.Name = "changeRestTimerSoundToolStripMenuItem";
            this.changeRestTimerSoundToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.changeRestTimerSoundToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.changeRestTimerSoundToolStripMenuItem.Size = new System.Drawing.Size(587, 22);
            this.changeRestTimerSoundToolStripMenuItem.Text = "Change Rest Sound";
            this.changeRestTimerSoundToolStripMenuItem.Click += new System.EventHandler(this.changeRestTimerSoundToolStripMenuItem_Click);
            // 
            // adjustLogoAndTexInLefBottomCornerToolStripMenuItem
            // 
            this.adjustLogoAndTexInLefBottomCornerToolStripMenuItem.Name = "adjustLogoAndTexInLefBottomCornerToolStripMenuItem";
            this.adjustLogoAndTexInLefBottomCornerToolStripMenuItem.ShortcutKeyDisplayString = "*...in work*";
            this.adjustLogoAndTexInLefBottomCornerToolStripMenuItem.Size = new System.Drawing.Size(587, 22);
            this.adjustLogoAndTexInLefBottomCornerToolStripMenuItem.Text = "Adjustable Logo and Tex in left bottom corner";
            // 
            // tellMeOtherSuggestionsToolStripMenuItem
            // 
            this.tellMeOtherSuggestionsToolStripMenuItem.Name = "tellMeOtherSuggestionsToolStripMenuItem";
            this.tellMeOtherSuggestionsToolStripMenuItem.Size = new System.Drawing.Size(587, 22);
            this.tellMeOtherSuggestionsToolStripMenuItem.Text = "Tell me other suggestions?!";
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
            this.paLower.Controls.Add(this.paTimerContainer);
            this.paLower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paLower.Location = new System.Drawing.Point(0, 584);
            this.paLower.Name = "paLower";
            this.paLower.Size = new System.Drawing.Size(695, 98);
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
            // paBottom
            // 
            this.paBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.paBottom.Controls.Add(this.laTimerGeneral);
            this.paBottom.Controls.Add(this.pbThumosLogo);
            this.paBottom.Controls.Add(this.laMotivationText);
            this.paBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paBottom.Location = new System.Drawing.Point(0, 682);
            this.paBottom.Name = "paBottom";
            this.paBottom.Size = new System.Drawing.Size(695, 79);
            this.paBottom.TabIndex = 4;
            this.paBottom.SizeChanged += new System.EventHandler(this.paBottom_SizeChanged);
            // 
            // laTimerGeneral
            // 
            this.laTimerGeneral.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.laTimerGeneral.AutoSize = true;
            this.laTimerGeneral.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTimerGeneral.ForeColor = System.Drawing.Color.Silver;
            this.laTimerGeneral.Location = new System.Drawing.Point(277, 22);
            this.laTimerGeneral.Name = "laTimerGeneral";
            this.laTimerGeneral.Size = new System.Drawing.Size(125, 36);
            this.laTimerGeneral.TabIndex = 1;
            this.laTimerGeneral.Text = "00:00:01";
            this.laTimerGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // laMotivationText
            // 
            this.laMotivationText.AutoSize = true;
            this.laMotivationText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMotivationText.ForeColor = System.Drawing.Color.Silver;
            this.laMotivationText.Location = new System.Drawing.Point(79, 28);
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
            // pbLoading
            // 
            this.pbLoading.Image = global::HomeGymManager.Properties.Resources.LoadingGif;
            this.pbLoading.Location = new System.Drawing.Point(165, 112);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(343, 233);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 3;
            this.pbLoading.TabStop = false;
            // 
            // pbCam
            // 
            this.pbCam.BackColor = System.Drawing.Color.Transparent;
            this.pbCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCam.Location = new System.Drawing.Point(0, 24);
            this.pbCam.Name = "pbCam";
            this.pbCam.Size = new System.Drawing.Size(695, 560);
            this.pbCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCam.TabIndex = 0;
            this.pbCam.TabStop = false;
            this.pbCam.SizeChanged += new System.EventHandler(this.pbCam_SizeChanged);
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
            // pbThumosLogo
            // 
            this.pbThumosLogo.Image = global::HomeGymManager.Properties.Resources.HighThumosLogo;
            this.pbThumosLogo.Location = new System.Drawing.Point(22, 22);
            this.pbThumosLogo.Name = "pbThumosLogo";
            this.pbThumosLogo.Size = new System.Drawing.Size(51, 36);
            this.pbThumosLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThumosLogo.TabIndex = 1;
            this.pbThumosLogo.TabStop = false;
            // 
            // recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem
            // 
            this.recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem.Name = "recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem";
            this.recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem.ShortcutKeyDisplayString = "*...in work*";
            this.recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem.Size = new System.Drawing.Size(587, 22);
            this.recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem.Text = "Record feature, so you can make short clisp and look at your form after your work" +
    "out";
            // 
            // HomeGymManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 761);
            this.Controls.Add(this.paPicture);
            this.Controls.Add(this.paLower);
            this.Controls.Add(this.paBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(16, 800);
            this.Name = "HomeGymManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home Gym Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.paPicture.ResumeLayout(false);
            this.paPicture.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.paLower.ResumeLayout(false);
            this.paTimerContainer.ResumeLayout(false);
            this.paTimerContainer.PerformLayout();
            this.paBottom.ResumeLayout(false);
            this.paBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTimeSymbol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumosLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCam;
        private System.Windows.Forms.Panel paPicture;
        private System.Windows.Forms.Panel paLower;
        private System.Windows.Forms.Panel paBottom;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetStartTimerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem changeRestTimerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeRestTimerSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adjustLogoAndTexInLefBottomCornerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tellMeOtherSuggestionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordFeatureSoYouCanLookAtYourFormAfterYourWorkoutToolStripMenuItem;
    }
}

