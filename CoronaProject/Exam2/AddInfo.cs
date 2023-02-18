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
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num = this.getLastLineNumberOfFile("infoData.txt");
            string topic = txtTopic.Text;
            string content = txtContent.Text;
            string newInfo = num + ";" + topic + ";" + content;
            string img = (num) + "." + Path.GetFileName(txtImage.Text);
            if (txtImage.Text != "")
                newInfo += ";" + img;
            newInfo += "\n";

            if (File.Exists("InfoData.txt"))
            {
                File.AppendAllText("InfoData.txt", newInfo);
            }
            else
            {
                StreamWriter sw = new StreamWriter("InfoData.txt");
                sw.WriteLine(newInfo);
                sw.Flush();
                sw.Close();
            }
            if (txtImage.Text != "")
                File.Copy(txtImage.Text, Path.Combine(@"..\..\DIMAGES", img), true);
            lblSucceed.Visible = true;
            txtTopic.Clear();
            txtContent.Clear();
            txtImage.Clear();
            pictureBox1.Image = null;
        }
        
        private int getLastLineNumberOfFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            return lines.Length + 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "ImageFiles(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if(open.ShowDialog()==DialogResult.OK)
            {
                txtImage.Text = open.FileName;
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }
    }
}
