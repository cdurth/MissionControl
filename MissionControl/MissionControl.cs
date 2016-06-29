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
            string promptValue = Prompt.ShowDialog(tile.Text,tile);
            if(promptValue != null)
            {
                tile.Style=MetroFramework.MetroColorStyle.Blue;
            }
        }

    }
}
