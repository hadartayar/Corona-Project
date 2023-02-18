using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class QuestionControl : UserControl
    {
        Questions question = new Questions();
        bool isMultiple;
        public QuestionControl()
        {
            InitializeComponent();
            question = null;
            isMultiple = false;
        }

        public bool IsMultiple
        {
            get { return isMultiple; }
            set {
                this.isMultiple = value;
                if(value)
                {
                    rbtn3.Visible = true;
                    rbtn4.Visible = true;
                } else
                {
                    rbtn3.Visible = false;
                    rbtn4.Visible = false;
                }
            }
        }
        public Questions Question{
            get { return question; }
            set {
                question = value;
                if (question != null && question.Qtype != 5)
                {
                    txtQuestion.Text = question.Question;
                    fillOptions();
                    clearRadio();
                }
            }
        }

        public void clearRadio()
        {
            //clear radio buttons
            var x = Controls.OfType<RadioButton>().ToArray();
            foreach (var radio in x)
            {
                radio.Checked = false;
            }
        }

        public void emptyRadioText()
        {
            var x = Controls.OfType<RadioButton>().ToArray();
            foreach (var radio in x)
            {
                radio.Text = "";
            }
        }

        public void emptyRadioImage()
        {
            var x = Controls.OfType<RadioButton>().ToArray();
            foreach (var radio in x)
            {
                radio.BackgroundImage = null;
            }
        }

        public void setRadioSize(int width, int height, int paddingLeft = 0)
        {
            var x = Controls.OfType<RadioButton>().ToArray();
            foreach (var radio in x)
            {
                radio.Width = width;
                radio.Height= height;
                radio.Left = paddingLeft;
            }
        }

        public void fillOptions()
        {
            string[] options = randomOptions();
            if (question.Qtype == 1 || question.Qtype == 0)
            {
                rbtn1.Text = options[0];
                rbtn2.Text = options[1];
                rbtn1.Tag = options[0]; rbtn2.Tag = options[1];
                if (IsMultiple) //4 אפשרויות
                {
                    rbtn3.Text = options[2];
                    rbtn4.Text = options[3];
                    rbtn3.Tag = options[2]; rbtn4.Tag = options[3];
                }
                emptyRadioImage();
                setRadioSize(600, 18);
            }
            else
            {
                string basedir = AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug", "QIMAGES");
                rbtn1.BackgroundImage = Image.FromFile(basedir + options[0]);
                rbtn2.BackgroundImage = Image.FromFile(basedir + options[1]);
                rbtn1.Tag = options[0]; rbtn2.Tag = options[1];
                if (IsMultiple) //4 אפשרויות
                {
                    rbtn3.BackgroundImage = Image.FromFile(basedir + options[2]);
                    rbtn4.BackgroundImage = Image.FromFile(basedir + options[3]);
                    rbtn3.Tag = options[2]; rbtn4.Tag = options[3];
                }
                emptyRadioText();
                setRadioSize(70, 60, 530);
            }
            rbtn1.Enabled = true;rbtn2.Enabled = true; rbtn3.Enabled = true; rbtn4.Enabled = true;
        }

        public string[] randomOptions()
        {
            int count = 2;
            if (IsMultiple)
            {
                count = 4;
            }
            string[] tmp = new string[count];
            tmp[0] = Question.CorrectAns;
            for (int i = 1; i < count; i++)
            {
                tmp[i] = Question.IncorrectAnswer[i - 1];
            }
            return shuffle(tmp);
        }

        private string[] shuffle(string[] array)
        {
            Random rnd = new Random();
            return array.OrderBy(x => rnd.Next()).ToArray();
        }

        public bool checkAnswer()
        {
            RadioButton selected = Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault();
            if(selected != null)
            {
                if((string)selected.Tag == Question.CorrectAns)
                {
                    return true;
                }
            }
            return false;
        }
        public string getAnswer()
        {
            RadioButton selected = Controls.OfType<RadioButton>().Where(r => r.Checked).FirstOrDefault();
            if (selected != null)
            {
                return (string)selected.Tag;
            }
            return "";
        }

        public void showAnswer()
        {
            int count = 2;
            if (IsMultiple)
            {
                count = 4;
            }
            RadioButton[] allRadio = Controls.OfType<RadioButton>().Take(count).ToArray();
            for (int i = 0; i < allRadio.Length; i++)
            {
                if ((string)allRadio[i].Tag == Question.CorrectAns)
                {
                    allRadio[i].Checked = true;
                }
                allRadio[i].Enabled = false;
            }
        }

        public void setTitle(string title)
        {
            lblTitle.Text = title;
        } 
    }
}
