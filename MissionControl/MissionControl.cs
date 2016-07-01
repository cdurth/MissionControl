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
using System.Configuration;
using MissionControl.Properties;
using System.Net.NetworkInformation;

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
            loadSettings();
            launchTimer.Tick += new EventHandler(TimerEventProcessor);
            launchTimer.Interval = 1000;
        }

        private void MissionControl_Load(object sender, EventArgs e)
        {
        }

        private void timer_dialog(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tile = ((MetroFramework.Controls.MetroTile)sender);
            LaunchPad tmpPad = TimerPrompt.ShowDialog(tile.Text,tile);
            if(tmpPad != null)
            {
                padList.Add(tmpPad);
                tile.Style=MetroFramework.MetroColorStyle.Blue;
            }
        }

        private void btn_launch_Click(object sender, EventArgs e)
        {
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
            launchTimer.Stop();
            if (padList.Count > 0)
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
                resetForm();
            }
            seconds++;
            launchTimer.Enabled = true;

        }

        private void resetForm()
        {
            foreach(MetroFramework.Controls.MetroTile tile in tileList)
            {
                tile.Style = MetroFramework.MetroColorStyle.Silver;
            }
            removedPads.Clear();
            padList.Clear();
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings.Remove("server");
            config.AppSettings.Settings.Add("server", tb_server.Text);
            config.AppSettings.Settings.Remove("port");
            config.AppSettings.Settings.Add("port", tb_port.Text);
            config.AppSettings.Settings.Remove("armcode");
            config.AppSettings.Settings.Add("armcode", tb_armcode.Text);
            config.AppSettings.Settings.Remove("powerendpoint");
            config.AppSettings.Settings.Add("powerendpoint", tb_powerendpoint.Text);
            config.Save(ConfigurationSaveMode.Minimal);


        }

        private void loadSettings()
        {
            tb_server.Text = ConfigurationManager.AppSettings["server"];
            tb_port.Text = ConfigurationManager.AppSettings["port"];
            tb_armcode.Text = ConfigurationManager.AppSettings["armcode"];
            tb_powerendpoint.Text = ConfigurationManager.AppSettings["powerendpoint"];
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            if (PingHost(tb_server.Text))
            {
                MessageBox.Show("Ping Succeeded");
            } else
            {
                MessageBox.Show("Ping failed");
            }
            
        }

        public static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = new Ping();
            try
            {
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException)
            {
                // Discard PingExceptions and return false;
            }
            return pingable;
        }
    }
}
