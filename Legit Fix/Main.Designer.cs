namespace Legit_Fix
{
    partial class f_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_main));
            this.l_Title = new System.Windows.Forms.Label();
            this.l_desc = new System.Windows.Forms.Label();
            this.b_start = new System.Windows.Forms.Button();
            this.l_info = new System.Windows.Forms.Label();
            this.tmr_reset = new System.Windows.Forms.Timer(this.components);
            this.l_disclaimer = new System.Windows.Forms.Label();
            this.l_version = new System.Windows.Forms.Label();
            this.tmr_updateElapsedTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // l_Title
            // 
            this.l_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_Title.Font = new System.Drawing.Font("Franklin Gothic Medium", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Title.Location = new System.Drawing.Point(0, 0);
            this.l_Title.Name = "l_Title";
            this.l_Title.Size = new System.Drawing.Size(726, 81);
            this.l_Title.TabIndex = 0;
            this.l_Title.Text = "Legit Fix (Beta 1.0)";
            this.l_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // l_desc
            // 
            this.l_desc.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_desc.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_desc.Location = new System.Drawing.Point(0, 81);
            this.l_desc.Name = "l_desc";
            this.l_desc.Size = new System.Drawing.Size(726, 43);
            this.l_desc.TabIndex = 1;
            this.l_desc.Text = "The fixing tool to solve all your problems!";
            this.l_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_start
            // 
            this.b_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_start.Location = new System.Drawing.Point(639, 307);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(75, 23);
            this.b_start.TabIndex = 4;
            this.b_start.Text = "Start!";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // l_info
            // 
            this.l_info.BackColor = System.Drawing.SystemColors.Control;
            this.l_info.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.l_info.Location = new System.Drawing.Point(0, 333);
            this.l_info.Name = "l_info";
            this.l_info.Size = new System.Drawing.Size(726, 18);
            this.l_info.TabIndex = 5;
            this.l_info.Text = "Thank you for using our app! We are currently in beta so please understand that y" +
    "ou may encounter bugs.";
            // 
            // tmr_reset
            // 
            this.tmr_reset.Interval = 5000;
            // 
            // l_disclaimer
            // 
            this.l_disclaimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_disclaimer.Location = new System.Drawing.Point(154, 140);
            this.l_disclaimer.Name = "l_disclaimer";
            this.l_disclaimer.Size = new System.Drawing.Size(425, 168);
            this.l_disclaimer.TabIndex = 6;
            this.l_disclaimer.Text = resources.GetString("l_disclaimer.Text");
            // 
            // l_version
            // 
            this.l_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.l_version.AutoSize = true;
            this.l_version.Location = new System.Drawing.Point(636, 333);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(85, 13);
            this.l_version.TabIndex = 7;
            this.l_version.Text = "Version Beta 1.0";
            // 
            // f_main
            // 
            this.AcceptButton = this.b_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 351);
            this.Controls.Add(this.l_version);
            this.Controls.Add(this.l_disclaimer);
            this.Controls.Add(this.l_info);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.l_desc);
            this.Controls.Add(this.l_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(742, 390);
            this.MinimumSize = new System.Drawing.Size(742, 390);
            this.Name = "f_main";
            this.Text = "Legit Fix - Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Title;
        private System.Windows.Forms.Label l_desc;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label l_info;
        private System.Windows.Forms.Timer tmr_reset;
        private System.Windows.Forms.Label l_disclaimer;
        private System.Windows.Forms.Label l_version;
        private System.Windows.Forms.Timer tmr_updateElapsedTime;
    }
}

