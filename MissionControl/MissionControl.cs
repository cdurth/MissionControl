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
using RestSharp;

namespace MissionControl
{
    public partial class MissionControl : MetroForm
    {

        // TODO: need to fix bug where clicking on already enabled pad will create new OBJ vs modifiy existing.

        static System.Windows.Forms.Timer launchTimer = new System.Windows.Forms.Timer();
        List<LaunchPad> padList = new List<LaunchPad>();

        public MissionControl()
        {
            InitializeComponent();
            loadSettings();
        }

        private void MissionControl_Load(object sender, EventArgs e)
        {
            btn_launch.Enabled = false;
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
            // do things here
            if (launchGET())
            {
                btn_launch.Enabled = false;
            } else
            {
                MessageBox.Show("There was an issue launching.");
            }
        }

        private void resetForm()
        {
            foreach(MetroFramework.Controls.MetroTile tile in tileList)
            {
                tile.Style = MetroFramework.MetroColorStyle.Silver;
            }
            padList.Clear();
            btn_launch.Enabled = false;
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
            config.Save(ConfigurationSaveMode.Minimal);


        }

        private void loadSettings()
        {
            tb_server.Text = ConfigurationManager.AppSettings["server"];
            tb_port.Text = ConfigurationManager.AppSettings["port"];
            tb_armcode.Text = ConfigurationManager.AppSettings["armcode"];
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

        private void btn_load_Click(object sender, EventArgs e)
        {
            string loadPadsReqStr = "[";
            int numPads = padList.Count;
            int padIndex = 0;
            foreach (LaunchPad pad in padList)
            {
                padIndex++;
                if(padIndex == numPads)
                {
                    // last pad, dont append comma
                    loadPadsReqStr += padToJSON(pad) + "]";
                }
                else
                {
                    loadPadsReqStr += padToJSON(pad) + ",";
                }
            }

            if (loadPOST(loadPadsReqStr))
            {
                btn_launch.Enabled = true;
            } else
            {
                MessageBox.Show("There was a problem loading.");
            }
        }

        private bool loadPOST(string body)
        {
            bool retVal = false;
            string url = "http://" + ConfigurationSettings.AppSettings["server"] + ":" + ConfigurationSettings.AppSettings["port"] + "/api/v1/launch";
            var client = new RestClient(url);
            var request = new RestRequest();
            request.Method = Method.POST;
            request.AddHeader("Accept", "application/json");
            request.Parameters.Clear();
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                retVal = true;
            }

            return retVal;
        }

        private bool launchGET()
        {
            bool retVal = false;

            bool retval = false;
            string url = "http://" + ConfigurationSettings.AppSettings["server"] + ":" + ConfigurationSettings.AppSettings["port"];
            var client = new RestClient(url);
            var request = new RestRequest("api/v1/launch?armCode=" + tb_armcode.Text, Method.GET);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                retVal = true;
            }
            return retVal;
        }

        public string padToJSON(LaunchPad pad)
        {
            return "{\"tubeId\":\""+ pad.id + "\",\"delayTime\":\"" + pad.delay + "\"}";
        }
    }
}
