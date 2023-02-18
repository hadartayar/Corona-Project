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
    public partial class Game : Form
    {
        public static int j = 1;
        // move file reading and queastionBank to another class
        public static int numberOfQuestions = 10;
        public static int scorePerAnswer = 10;
        ArrayList questions = new ArrayList();
        Questions[] gameQuestions = new Questions[numberOfQuestions];
        string[] gameAnswers = new string[numberOfQuestions];
        int currentQuestionIndex = 0;
        int score = 0;
        int time = 0;
        string playerName = "";

        public Game(string playerName = "", Questions[] lastGameQuestions = null)
        {
            InitializeComponent();
            this.playerName = playerName;
            questionControl.Visible = false;
            LoadDataFromGameFile();
            startGame(lastGameQuestions);
            questionControl.Visible = true;
            btnNextQues.Enabled = true;
        }

        private void LoadDataFromGameFile()
        {
            string path = "gameData.txt";
            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                char delimiter = ';';
                string[] data = lines[i].Split(delimiter);
                string[] incorrectAns = new string[data.Length - 4];
                for (int j = 4; j < data.Length; j++)
                {
                    incorrectAns[j-4] = data[j];
                }
                Questions ques = new Questions(int.Parse(data[0]), int.Parse(data[1]), data[2], data[3], incorrectAns);
                questions.Add(ques);
            }
        }

        private void startGame(Questions[] lastGameQuestions = null)
        {
            score = 0; time = 0;
            lblScore.Text = score.ToString();
            if (lastGameQuestions != null)
                gameQuestions = lastGameQuestions;
            else
                gameQuestions = pickRandom();
            LoadNextQuestion();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void LoadNextQuestion()
        {
            if(gameQuestions[currentQuestionIndex].Qtype == 1 || (gameQuestions[currentQuestionIndex].Qtype == 3)){
                questionControl.IsMultiple = true;
                questionControl.setTitle("בחר את האפשרות הנכונה בין ארבעת האפשרויות");
            } else
            {
                questionControl.IsMultiple = false;
                questionControl.setTitle("האם המשפט שלפניך הוא אמת, או שקר?");
            }
            questionControl.Question = gameQuestions[currentQuestionIndex];
            currentQuestionIndex++;
        }

        private Questions[] pickRandom()
        {
            Random rnd = new Random();
            return questions.OfType<Questions>()
                .OrderBy(x => rnd.Next()).
                Take(numberOfQuestions)
                .ToArray();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saveStatistics();
            EndGame endGameForm = new EndGame(playerName, score, gameQuestions, gameAnswers);
            endGameForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnNextQues_Click(object sender, EventArgs e)
        {
            //check answer
            this.gameAnswers[currentQuestionIndex-1] = questionControl.getAnswer();
            if (questionControl.checkAnswer())
            {
                score += scorePerAnswer;
                lblScore.Text = score.ToString();
            }
            //load next question
            if(currentQuestionIndex == numberOfQuestions)
            {
                btnNextQues.Enabled = false;
            } else
            {
                LoadNextQuestion();
            }
        }

        private void saveStatistics()
        {
            //ליצור קובץ שיקח את הנתונים שנאספו
            StreamWriter sw = new StreamWriter("outdata_"+ DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH'_'mm'_'ss") + ".txt");
            int numberOfErrors = countNumberOfErrors(gameAnswers);
            string statistics = string.Format(playerName + ";" + score + ";" + numberOfErrors + ";" + time + "\n");
            sw.WriteLine(statistics);
            sw.Flush();
            sw.Close();
        }

        public int countNumberOfErrors(string[] answers)
        {
            int numberOfErrors = 0;
            for (int i = 0; i < gameQuestions.Length; i++)
            {
                if (gameQuestions[i].CorrectAns != answers[i] && answers[i] != null)
                {
                    numberOfErrors++;
                }
            }
            return numberOfErrors;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            HomePage hm = new HomePage();
            hm.Show();
            this.Hide();
        }
    }
}
