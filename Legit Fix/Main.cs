using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legit_Fix
{
    public partial class f_main : Form
    {
        f_fixing fixing = new f_fixing();
        DateTime startDateTime;
        bool done = true;

        public f_main()
        {
            InitializeComponent();
            tmr_reset.Tick += Tmr_reset_Tick;
            tmr_updateElapsedTime.Tick += UpdateElapsedTime;
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            fixing.Show();
            fixing.FormClosing += Fixing_FormClosing;
            fixing.FormClosed += Fixing_FormClosed;
            startDateTime = DateTime.Now;
            l_info.Text = "Legit Fixer Started. Elapsed Time: 00:00:00";
            done = false;
            b_start.Enabled = false;
            tmr_updateElapsedTime.Start();
        }

        private void Fixing_FormClosed(object sender, FormClosedEventArgs e)
        {
            fixing = new f_fixing();
        }

        private void Fixing_FormClosing(object sender, FormClosingEventArgs e)
        {
            done = true;
            b_start.Enabled = true;

            if (fixing.success)
            {
                l_info.Text = "Success! All apps that were not working should now work!";
            }
            else
            {
                l_info.Text = "Operation canceled.";
            }

            tmr_reset.Start();
        }

        private void Tmr_reset_Tick(object sender, EventArgs e)
        {
            tmr_reset.Stop();
            l_info.ResetText();
        }

        private void UpdateElapsedTime(object sender, EventArgs e)
        {
            Console.WriteLine(Math.Floor(4.99));
            if (!done)
            {
                TimeSpan elapsedTime = DateTime.Now.Subtract(startDateTime);
                string hours, minutes, seconds;
                if (elapsedTime.Hours.ToString().Length < 2) { hours = "0" + elapsedTime.Hours; } else { hours = elapsedTime.Hours.ToString(); }
                if (elapsedTime.Minutes.ToString().Length < 2) { minutes = "0" + elapsedTime.Minutes; } else { minutes = elapsedTime.Minutes.ToString(); }
                if (elapsedTime.Seconds.ToString().Length < 2) { seconds = "0" + elapsedTime.Seconds; } else { seconds = elapsedTime.Seconds.ToString(); }
                if (elapsedTime.Days > 1) { hours = Math.Floor(elapsedTime.TotalHours).ToString(); }

                l_info.Text = "Legit Fixer Started. Elapsed Time: " + hours + ":" + minutes + ":" + seconds;
                Update();
            }
            else
            {
                tmr_updateElapsedTime.Stop();
            }
        }
    }
}
