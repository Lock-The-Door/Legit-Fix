namespace Legit_Fix
{
    partial class f_fixing
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
            this.components = new System.ComponentModel.Container();
            this.pb_progress = new System.Windows.Forms.ProgressBar();
            this.p_progress = new System.Windows.Forms.Panel();
            this.l_percent = new System.Windows.Forms.Label();
            this.l_title = new System.Windows.Forms.Label();
            this.l_desc = new System.Windows.Forms.Label();
            this.b_cancel = new System.Windows.Forms.Button();
            this.tmr_timer = new System.Windows.Forms.Timer(this.components);
            this.l_timeElapsed = new System.Windows.Forms.Label();
            this.tmr_updateElapsedTime = new System.Windows.Forms.Timer(this.components);
            this.p_progress.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_progress
            // 
            this.pb_progress.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_progress.Location = new System.Drawing.Point(0, 0);
            this.pb_progress.Name = "pb_progress";
            this.pb_progress.Size = new System.Drawing.Size(470, 23);
            this.pb_progress.Step = 1;
            this.pb_progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_progress.TabIndex = 0;
            // 
            // p_progress
            // 
            this.p_progress.Controls.Add(this.l_percent);
            this.p_progress.Controls.Add(this.pb_progress);
            this.p_progress.Location = new System.Drawing.Point(12, 41);
            this.p_progress.Name = "p_progress";
            this.p_progress.Size = new System.Drawing.Size(525, 23);
            this.p_progress.TabIndex = 1;
            // 
            // l_percent
            // 
            this.l_percent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_percent.Dock = System.Windows.Forms.DockStyle.Right;
            this.l_percent.Location = new System.Drawing.Point(470, 0);
            this.l_percent.Name = "l_percent";
            this.l_percent.Size = new System.Drawing.Size(55, 23);
            this.l_percent.TabIndex = 1;
            this.l_percent.Text = "0%";
            this.l_percent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // l_title
            // 
            this.l_title.AutoSize = true;
            this.l_title.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_title.Location = new System.Drawing.Point(12, 17);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(98, 21);
            this.l_title.TabIndex = 2;
            this.l_title.Text = "Starting up...";
            // 
            // l_desc
            // 
            this.l_desc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_desc.Location = new System.Drawing.Point(16, 71);
            this.l_desc.Name = "l_desc";
            this.l_desc.Size = new System.Drawing.Size(521, 58);
            this.l_desc.TabIndex = 3;
            this.l_desc.Text = "We are getting things ready for you. Please wait.";
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(462, 132);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 4;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // l_timeElapsed
            // 
            this.l_timeElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_timeElapsed.AutoSize = true;
            this.l_timeElapsed.Location = new System.Drawing.Point(9, 142);
            this.l_timeElapsed.Name = "l_timeElapsed";
            this.l_timeElapsed.Size = new System.Drawing.Size(119, 13);
            this.l_timeElapsed.TabIndex = 5;
            this.l_timeElapsed.Text = "Time Elapsed: 00:00:00";
            // 
            // tmr_updateElapsedTime
            // 
            this.tmr_updateElapsedTime.Tick += new System.EventHandler(this.tmr_updateElapsedTime_Tick);
            // 
            // f_fixing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 167);
            this.Controls.Add(this.l_timeElapsed);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.l_desc);
            this.Controls.Add(this.l_title);
            this.Controls.Add(this.p_progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "f_fixing";
            this.Text = "Legit Fix - Fixing Problems";
            this.Load += new System.EventHandler(this.f_fixing_Open);
            this.p_progress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_progress;
        private System.Windows.Forms.Panel p_progress;
        private System.Windows.Forms.Label l_percent;
        private System.Windows.Forms.Label l_title;
        private System.Windows.Forms.Label l_desc;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Timer tmr_timer;
        private System.Windows.Forms.Label l_timeElapsed;
        private System.Windows.Forms.Timer tmr_updateElapsedTime;
    }
}