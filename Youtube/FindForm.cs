using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeLoader
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            var sourse = (this.Owner as YoutubeFine.MainForm).sourceText;
            var pos = sourse.Text.IndexOf(FindText.Text, sourse.SelectionStart);
            if (pos >= 0)
            {
                sourse.SelectionStart = pos;
                sourse.SelectionLength = FindText.Text.Length;
                this.Close();
            }
            else
            {
                //this.Hide();
                var r = MessageBox.Show("the text was not found. Do tou want to search from begin?","", 
                    MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes)
                {
                    sourse.SelectionStart = 0;
                    FindButton_Click(sender, e);
                }
                else this.Close();

                
            }

            
        }

        private void FindForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            
        }

        private void FindText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) FindButton_Click(sender, e);
        }
    }
}
