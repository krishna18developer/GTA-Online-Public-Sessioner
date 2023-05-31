using GTA_Online_Public_Sessioner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Online_Public_Sessioner
{
    public partial class SettingsForm : Form
    {
        Dashboard dbs;
        public SettingsForm(Dashboard db)
        {
            InitializeComponent();
            dbs = db;
        }


        private void setButton_Click(object sender, EventArgs e)
        {
            Settings.Default.ProcessName = processNameBox.Text;
            Settings.Default.Duration = Int32.Parse(suspensionDurationBox.Text);

            Settings.Default.Save();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbs.Show();
            this.Hide();
        }
    }
}
