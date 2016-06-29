using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;


namespace MissionControl
{
    public partial class MissionControl : MetroForm
    {
        static System.Windows.Forms.Timer launchTimer = new System.Windows.Forms.Timer();
        static bool exitFlag = false;
        static int seconds = 0;
        List<LaunchPad> padList = new List<LaunchPad>();
        List<LaunchPad> removedPads = new List<LaunchPad>();

        public MissionControl()
        {
            InitializeComponent();
        }

        private void MissionControl_Load(object sender, EventArgs e)
        {
        }

        private void timer_dialog(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = ((MetroFramework.Controls.MetroTile)sender);
            LaunchPad tmpPad = Prompt.ShowDialog(tile.Text,tile);
            if(tmpPad != null)
            {
                padList.Add(tmpPad);
                tile.Style=MetroFramework.MetroColorStyle.Blue;
            }
        }

        private void btn_launch_Click(object sender, EventArgs e)
        {
            launchTimer.Tick += new EventHandler(TimerEventProcessor);
            launchTimer.Interval = 1000;
            launchTimer.Start();
            seconds = 0;
            removedPads.Clear();
            while(!exitFlag)
            {
                Application.DoEvents();
            }
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if(padList.Count > 0)
            {
                // loop thorough active pads, fire, and remove
                foreach (LaunchPad pad in padList)
                {
                    if(pad.delay == seconds)
                    {
                        //make launch requests here
                        pad.launch();
                        removedPads.Add(pad);
                    }
                }
                foreach(LaunchPad pad in removedPads)
                {
                    padList.Remove(pad);
                }

            } else
            {
                launchTimer.Stop();
                exitFlag = true;
            }
            seconds++;

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void powerToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (((MetroFramework.Controls.MetroToggle)sender).Checked)
            {
                tb_powerendpoint.Enabled = true;
            } else
            {
                tb_powerendpoint.Enabled = false;
            }
        }
    }
}
