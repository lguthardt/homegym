namespace HomeGymManager
{
    partial class ChangeRestTimerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.numMin = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
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
            this.laTimerGeneral.Size = new System.Drawing.Size(327, 36);
            this.laTimerGeneral.TabIndex = 2;
            this.laTimerGeneral.Text = "Change the rest timer";
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numSeconds);
            this.panel2.Controls.Add(this.numMin);
            this.panel2.Controls.Add(this.label1);
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(288, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numSeconds
            // 
            this.numSeconds.BackColor = System.Drawing.Color.Gray;
            this.numSeconds.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.numSeconds.ForeColor = System.Drawing.Color.LightGray;
            this.numSeconds.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSeconds.Location = new System.Drawing.Point(314, 199);
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(62, 37);
            this.numSeconds.TabIndex = 5;
            // 
            // numMin
            // 
            this.numMin.BackColor = System.Drawing.Color.Gray;
            this.numMin.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.numMin.ForeColor = System.Drawing.Color.LightGray;
            this.numMin.Location = new System.Drawing.Point(220, 199);
            this.numMin.Name = "numMin";
            this.numMin.Size = new System.Drawing.Size(62, 37);
            this.numMin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(51, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ChangeRestTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(614, 384);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "ChangeRestTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeRestTimer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChangeRestTimer_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label laTimerGeneral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.NumericUpDown numMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
    }
}