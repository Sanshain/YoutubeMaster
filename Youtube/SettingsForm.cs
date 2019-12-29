using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void setOK_Click(object sender, EventArgs e)
        {
            YoutubeLoader.Properties.Settings.Default.LastVideo = textLast.Text;

            this.Close();
        }

        private void VideoSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("В разработке");
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textLast.Text = YoutubeLoader.Properties.Settings.Default.LastVideo;
        }
    }
}
