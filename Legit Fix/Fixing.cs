using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legit_Fix
{
    public partial class f_fixing : Form
    {
        public bool success = false; //to determine success for message on main page

        private int minMS = 1000;
        private int maxMS = 5000;
        private int stops = 0;
        private int stopped = 0;
        private string[] args;
        private string arg = "";
        public string hours, minutes, seconds;

        public f_fixing()
        {
            InitializeComponent();
            tmr_timer.Tick += new EventHandler(doStuff);
            Update();
            tmr_timer.Interval = 3000;
        }

        private void f_fixing_Open(object sender, EventArgs e)
        {
            tmr_timer.Start();
            tmr_updateElapsedTime.Start();
        }

        private void doStuff(object sender, EventArgs e)
        {
            tmr_timer.Stop();
            Random value = new Random();
            if (pb_progress.Value == 100)
            {
                pb_progress.Value = 0;
                l_percent.ResetText();
                Update();
            }
            
            switch (stops)
            {
                case 0:
                    l_title.Text = "Detecting Problems";
                    l_desc.Text = "Searching applications for problems";
                    minMS = 1000;
                    maxMS = 5000;
                    args = new string[] { "Legit Fix Console Helper", "Running Legit Fix Detector Helper..."};
                    stops = 1;
                    stopped = 2;
                    break;
                case 1:
                    if (value.Next(10) > 7)
                    {
                        foreach (string argument in args)
                        {
                            arg += "\"" + argument + "\"\n";
                        }
                        System.Diagnostics.Process.Start(@"Terminating_Console.exe", arg);
                    }
                    int newValue = pb_progress.Value + value.Next(0, 10);
                    if (newValue >= 100) { newValue = 100; stops++; stops = stopped; }
                    pb_progress.Value = newValue;
                    l_percent.Text = newValue + "%";
                    tmr_timer.Interval = value.Next(minMS, maxMS);
                    break;
                case 2:
                    l_title.Text = "Fixing Faulty Files";
                    l_desc.Text = "Fixing faulty files in problamatic applications";
                    minMS = 3000;
                    maxMS = 5000;
                    args = new string[] { "Legit Fix Console Helper", "Running Legit Fix File Helper..." };
                    stops = 1;
                    stopped = 3;
                    break;
                case 3:
                    l_title.Text = "Finalizing";
                    l_desc.Text = "Saving changes and exiting threads safely";
                    minMS = 1000;
                    maxMS = 3000;
                    args = new string[] {"Legit Fix Console Helper", "Exiting Thread"};
                    stops = 1;
                    stopped = 4;
                    break;
                default:
                    success = true;
                    l_title.Text = "Complete!";
                    l_desc.Text = "We have finished fixing your problematic applications.\nIf the problem persists, something may of went wrong and you can try again.\nKeep in mind this program is in beta so bug are likely to occur.";
                    b_cancel.Text = "Ok";
                    break;
            }
            tmr_timer.Start();
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tmr_updateElapsedTime_Tick(object sender, EventArgs e)
        {
            
            l_timeElapsed.Text = "Time Elapsed: " + hours + ":" + minutes + ":" + seconds;
        }
    }
}
