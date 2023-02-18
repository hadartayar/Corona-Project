using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2
{
    public partial class ViewAnswers : Form
    {
        Questions[] lastGameErrors;
        string[] lastGameAnswers;
        int currentErrorIndex = 0;
        int numberOfErrors;

        public ViewAnswers(Questions[] lastGameQuestions, string[] lastGameAnswers)
        {
            InitializeComponent();
            questionControl1.Visible = false;
            fillErrors(lastGameQuestions, lastGameAnswers);
            LoadNextQuestion();
            questionControl1.Visible = true;
        }

        public void fillErrors(Questions[] questions, string[] answers)
        {
            numberOfErrors = 0;
            this.lastGameErrors = new Questions[questions.Length];
            this.lastGameAnswers = new string[answers.Length];
            for (int i = 0; i < questions.Length; i++)
            {
                if(questions[i].CorrectAns != answers[i] && answers[i] != null)
                {
                    this.lastGameErrors[numberOfErrors] = questions[i];
                    this.lastGameAnswers[numberOfErrors] = answers[i];
                    numberOfErrors++;
                }
            }
        }

        private void LoadNextQuestion()
        {
            if (lastGameErrors[currentErrorIndex].Qtype == 1 || (lastGameErrors[currentErrorIndex].Qtype == 3))
            {
                questionControl1.IsMultiple = true;
            }
            else
            {
                questionControl1.IsMultiple = false;
            }
            questionControl1.setTitle("טעית בשאלה זו, התשובה הנכונה מסומנת");
            questionControl1.Question = lastGameErrors[currentErrorIndex];
            if (lastGameAnswers[currentErrorIndex] == null || lastGameAnswers[currentErrorIndex] == "")
                textBox1.Text = "לא ענית על שאלה זו..";
            else
                textBox1.Text = lastGameAnswers[currentErrorIndex];
            currentErrorIndex++;

            questionControl1.showAnswer();
        }

        private void btnNextQues_Click(object sender, EventArgs e)
        {
            if (currentErrorIndex == numberOfErrors)
            {
                btnNextQues.Enabled = false;
            }
            else
            {
                LoadNextQuestion();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
