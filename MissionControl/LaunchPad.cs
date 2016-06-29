using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Configuration;
using RestSharp;

namespace MissionControl
{
    public class LaunchPad
    {
        public int id { get; set; }
        public int delay { get; set; }
        public string requestUrl { get; set; }

        public LaunchPad(string pad_no, string pad_delay)
        {
            id = convertToId(pad_no);
            delay = Int32.Parse(pad_delay);
            requestUrl = makeUrl(id);
        }

        private int convertToId(string pad)
        {
            string newId = pad.Replace("Pad ", "");
            return Int32.Parse(newId) - 1;

        }
        
        private string makeUrl(int id)
        {
            string tmpUrl = ConfigurationSettings.AppSettings["server"] + "/launch/" + id.ToString();
            return tmpUrl;
        }

        public void launch()
        {
            string server = ConfigurationSettings.AppSettings["server"];
            var client = new RestClient(server);
            var request = new RestRequest("launch?tube="+id, Method.GET);
            client.ExecuteAsync(request, response => {
                //do something if i want to wait
                Console.Write("test");
            });
        }
    }
}
