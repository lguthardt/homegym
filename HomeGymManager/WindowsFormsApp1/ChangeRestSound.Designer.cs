namespace HomeGymManager
{
    partial class ChangeRestSound
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
            this.laTimerGeneral = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.cbSound = new System.Windows.Forms.CheckBox();
            this.laDockDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTimerGeneral
            // 
            this.laTimerGeneral.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.laTimerGeneral.AutoSize = true;
            this.laTimerGeneral.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTimerGeneral.ForeColor = System.Drawing.Color.LightGray;
            this.laTimerGeneral.Location = new System.Drawing.Point(137, 57);
            this.laTimerGeneral.Name = "laTimerGeneral";
            this.laTimerGeneral.Size = new System.Drawing.Size(340, 36);
            this.laTimerGeneral.TabIndex = 2;
            this.laTimerGeneral.Text = "Change the rest sound";
            this.laTimerGeneral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laTimerGeneral);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 141);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.laDockDescription);
            this.panel2.Controls.Add(this.cbSound);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 378);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btCancel);
            this.panel3.Controls.Add(this.btOk);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 59);
            this.panel3.TabIndex = 7;
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.Color.Transparent;
            this.btCancel.FlatAppearance.BorderSize = 0;
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btCancel.Location = new System.Drawing.Point(481, 9);
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
            this.btOk.BackColor = System.Drawing.Color.Transparent;
            this.btOk.FlatAppearance.BorderSize = 0;
            this.btOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOk.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.btOk.ForeColor = System.Drawing.Color.LightGray;
            this.btOk.Location = new System.Drawing.Point(357, 9);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(118, 41);
            this.btOk.TabIndex = 9;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = false;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            this.btOk.MouseEnter += new System.EventHandler(this.btOk_MouseEnter);
            this.btOk.MouseLeave += new System.EventHandler(this.btOk_MouseLeave);
            // 
            // cbSound
            // 
            this.cbSound.AutoSize = true;
            this.cbSound.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSound.ForeColor = System.Drawing.Color.LightGray;
            this.cbSound.Location = new System.Drawing.Point(54, 175);
            this.cbSound.Name = "cbSound";
            this.cbSound.Size = new System.Drawing.Size(406, 28);
            this.cbSound.TabIndex = 9;
            this.cbSound.Text = "Play sound after the rest time expired";
            this.cbSound.UseVisualStyleBackColor = true;
            // 
            // laDockDescription
            // 
            this.laDockDescription.AutoSize = true;
            this.laDockDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDockDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.laDockDescription.Location = new System.Drawing.Point(50, 206);
            this.laDockDescription.MaximumSize = new System.Drawing.Size(450, 0);
            this.laDockDescription.Name = "laDockDescription";
            this.laDockDescription.Size = new System.Drawing.Size(445, 63);
            this.laDockDescription.TabIndex = 11;
            this.laDockDescription.Text = "More features are planned, so you can select the sound of a few default sounds or" +
    " even pick your own sound from your PC";
            this.laDockDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeRestSound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(614, 384);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeRestSound";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRestTimer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laTimerGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.CheckBox cbSound;
        private System.Windows.Forms.Label laDockDescription;
    }
}