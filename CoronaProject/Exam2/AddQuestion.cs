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
    public partial class AddQuestion : Form
    {
        public enum QuestionType
        {
            rbtn0 = 0, rbtn1, rbtn2, rbtn3
        }
        int lastQtype = 5;
        public AddQuestion()
        {
            InitializeComponent();
        }

        private void btnAddTxt_Click(object sender, EventArgs e)
        {
            if (isImageType())
            {
                string image = insertImageFromExplorer();
                if (image != "")
                    listBoxIncorrectAns.Items.Add(image);
            }
            else
            {
                string incorretAns = txtIncorrectAns1.Text;
                listBoxIncorrectAns.Items.Add(incorretAns);
                txtIncorrectAns1.Clear();
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            if (allGood())
            {
                string newQuestion = this.buildQuestion();
                if (File.Exists("gameData.txt"))
                {
                    File.AppendAllText("gameData.txt", newQuestion);
                }
                else
                {
                    StreamWriter sw = new StreamWriter("gameData.txt");
                    sw.WriteLine(newQuestion);
                    sw.Flush();
                    sw.Close();
                }
                lblAttention.ForeColor = Color.Green;
                lblAttention.Text = "השאלה התווספה בהצלחה";
                this.clearAll();
            }
        }

        private bool allGood()
        {
            if (txtBoxQuestoion.Text == "")
            {
                lblAttention.ForeColor = Color.Red;
                lblAttention.Text = "צריך למלא את שדה השאלה";
                return false;
            }
            if (txtCorrectAns.Text == "")
            {
                lblAttention.ForeColor = Color.Red;
                lblAttention.Text = "צריך למלא תשובה נכונה";
                return false;
            }
            if (listBoxIncorrectAns.Items.Count == 0)
            {
                lblAttention.ForeColor = Color.Red;
                lblAttention.Text = "צריך להוסיף לרשימה תשובות לא נכונות בעזרת הכפתור המתאים";
                return false;
            }
            var radio = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            string radioName = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            int qtype = (int)Enum.Parse(typeof(QuestionType), radioName);
            if (listBoxIncorrectAns.Items.Count != 1 && (qtype == 0 || qtype == 2))
            {
                lblAttention.ForeColor = Color.Red;
                lblAttention.Text = "בשאלות אמת ושקר צריכות להיות 2 תשובות, אחת נכונה ואחת לא נכונה";
                return false;
            }
            if (listBoxIncorrectAns.Items.Count != 3 && (qtype == 1 || qtype == 3))
            {
                lblAttention.ForeColor = Color.Red;
                lblAttention.Text = "בשאלות מרובות בחירה צריכות להיות 4 אפשרויות, אחת נכונה ושלוש לא נכונות";
                return false;
            }
            return true;
        }

        private void clearAll()
        {
            var x = Controls.OfType<RadioButton>().Where(r => r.Checked);
            foreach (var radio in x)
            {
                radio.Checked = false;
            }
            txtBoxQuestoion.Clear();
            txtCorrectAns.Clear();
            txtIncorrectAns1.Clear();
            listBoxIncorrectAns.Items.Clear();
        }

        private string buildQuestion()
        {
            int qnumber = this.getLastLineNumberOfFile("gameData.txt");
            string radioName = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            int qtype = (int)Enum.Parse(typeof(QuestionType), radioName);
            string question = txtBoxQuestoion.Text;
            string correctAns = txtCorrectAns.Text;
            string[] IncorrectAns = new string[listBoxIncorrectAns.Items.Count];
            for (int i = 0; i < listBoxIncorrectAns.Items.Count; i++)
            {
                IncorrectAns[i] = listBoxIncorrectAns.Items[i].ToString();
            }
            if(isImageType(qtype)){
                File.Copy(correctAns, Path.Combine(@"..\..\QIMAGES", qnumber + "." + Path.GetFileName(correctAns)), true);
                for (int i = 0; i < IncorrectAns.Length; i++)
                {
                    File.Copy(IncorrectAns[i], Path.Combine(@"..\..\QIMAGES", qnumber + "." + Path.GetFileName(IncorrectAns[i])), true);
                }
            }

            return string.Format(qnumber + ";" + qtype + ";" + question + ";" + getCorrectFormat(correctAns, qnumber) + ";" + getIncorrectFormat(IncorrectAns, qnumber) +"\n");
        }

        private string getCorrectFormat(string correct, int qnumber)
        {
            if (isImageType())
                return qnumber + "." + Path.GetFileName(correct);
            return correct;
        }

        private string getIncorrectFormat(string[] array, int qnumber)
        {
            string format = "";
            if (isImageType())
            {
                format = qnumber + "." + Path.GetFileName(array[0]);
                for (int i = 1; i < array.Length; i++)
                {
                    format += ";" + qnumber + "." + Path.GetFileName(array[i]);
                }
            } else {
                format = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    format += ";" + array[i];
                }
            }
            return format;
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
            string image = insertImageFromExplorer();
            if(image != "")
                txtCorrectAns.Text = image;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null && rb.Checked)
            {
                if (isImageType())
                {
                    btnAddPic.Visible = true;
                    txtCorrectAns.Enabled = false;
                    lblIncorrectAns.Visible = false;
                    txtIncorrectAns1.Visible = false;
                }
                else
                {
                    btnAddPic.Visible = false;
                    txtCorrectAns.Enabled = true;
                    lblIncorrectAns.Visible = true;
                    txtIncorrectAns1.Visible = true;
                }
                if (isCheckedModeChanged())
                {
                    txtCorrectAns.Clear();
                    txtIncorrectAns1.Clear();
                    listBoxIncorrectAns.Items.Clear();
                }
            }
        }

        private string insertImageFromExplorer()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "ImageFiles(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                return open.FileName;
            }
            return "";
        }

        private bool isImageType(int qtype = 5)
        {
            if (qtype == 5)
            {
                var radio = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (radio != null)
                {
                    string radioName = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
                    qtype = (int)Enum.Parse(typeof(QuestionType), radioName);
                }
            }
            return qtype == 2 || qtype == 3;
        }

        private bool isCheckedModeChanged()
        {
            bool result = true;
            string radioName = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name;
            int qtype = (int)Enum.Parse(typeof(QuestionType), radioName);
            if (lastQtype != 5)
            {
                result = ((qtype == 2 || qtype == 3) && (lastQtype == 0 || lastQtype == 1)) ||
                    ((qtype == 0 || qtype == 1) && (lastQtype == 2 || lastQtype == 3));
            }
            lastQtype = qtype;
            return result;
        }

        private void btnHm_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }
    }
}
