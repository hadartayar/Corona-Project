using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class Learn : Form
    {
        public static int i = 1;
        List<DataItem> info = new List<DataItem>();
        public Learn()
        {
            InitializeComponent();
            LoadDataFromInfoFile();
            txtContent.Text = info[0].Content;
            lblQuestion.Text = info[0].Topic;
        }
        private void LoadDataFromInfoFile()
        {
            string path = "infoData.txt";
            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                char delimiter = ';';
                string[] data = lines[i].Split(delimiter);
                DataItem dataItem;
                dataItem = new DataItem(int.Parse(data[0]), data[1], data[2], data[3]);
                info.Add(dataItem);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (i == info.Count)
            {
                btnNext.Enabled = false;
            }
            else
            {
                lblQuestion.Text = info[i].Topic;
                txtContent.Text = info[i].Content;
                if (info[i].Image == "")
                    pictureBox1.Visible = false;
                else
                {
                    pictureBox1.Image = Image.FromFile(@"..\..\DImages\"+info[i].Image);
                    pictureBox1.Visible = true;
                }
            }
            i++;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Game gform = new Game();
            gform.Show();
            this.Hide();
            this.Dispose();
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }
    }
}
