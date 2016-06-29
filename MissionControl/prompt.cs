using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionControl
{
    public class Prompt
    {
        public static LaunchPad ShowDialog(string pad, MetroFramework.Controls.MetroTile btn)
        {
            MetroForm prompt = new MetroForm()
            {
                Width = 500,
                Height = 180,
                Text = pad,

            };

            MetroFramework.Controls.MetroTextBox timerVal = new MetroFramework.Controls.MetroTextBox();
            timerVal.Location = new System.Drawing.Point(130, 100);
            timerVal.Size = new System.Drawing.Size(25, 20);
            timerVal.Text = "0";

            // timer slider
            MetroFramework.Controls.MetroTrackBar timerSlider = new MetroFramework.Controls.MetroTrackBar();
            timerSlider.Minimum = 0;
            timerSlider.Maximum = 60;
            timerSlider.BackColor = System.Drawing.Color.Transparent;
            timerSlider.Location = new System.Drawing.Point(28, 80);
            timerSlider.Name = "pad_timer";
            timerSlider.Size = new System.Drawing.Size(237, 23);
            timerSlider.TabIndex = 4;
            timerSlider.Text = "metroTrackBar1";
            timerSlider.Value = 0;
            timerSlider.ValueChanged += (sender, e) => {
                timerVal.Text = ((MetroFramework.Controls.MetroTrackBar)sender).Value.ToString();
            };



            // enable btn
            MetroFramework.Controls.MetroButton enableBtn = new MetroFramework.Controls.MetroButton(){ Text = "Enable", Left = 350, Width = 100, Top = 100, DialogResult = DialogResult.OK };

            // disable btn
            MetroFramework.Controls.MetroButton disableBtn = new MetroFramework.Controls.MetroButton() { Text = "Disable", Left = 350, Width = 100, Top = 125, DialogResult = DialogResult.Cancel };

            enableBtn.Click += (sender, e) => { prompt.Close(); };
            disableBtn.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(timerSlider);
            prompt.Controls.Add(timerVal);
            prompt.Controls.Add(enableBtn);
            prompt.Controls.Add(disableBtn);
            prompt.AcceptButton = enableBtn;

            if(prompt.ShowDialog() == DialogResult.OK)
            {
                return new LaunchPad(pad, timerVal.Text);
            } else
            {
                return null;
            }

            //return prompt.ShowDialog() == DialogResult.OK ? "" : "";
        }
    }
}
