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
    public partial class EndGame : Form
    {
        string playerName;
        int score;
        Questions[] lastGameQuestions;
        string[] lastGameAnswers;
        public EndGame(string playerName, int score, Questions[] lastGameQuestions, string[] lastGameAnswers)
        {
            InitializeComponent();
            this.playerName = playerName;
            this.score = score;
            lblScoere.Text = score.ToString();

            this.lastGameQuestions = lastGameQuestions;
            this.lastGameAnswers = lastGameAnswers;
        }

        private void EndGame_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void BtnLearn_Click(object sender, EventArgs e)
        {
            Learn lf = new Learn();
            lf.Show();
            this.Hide();
        }

        private void BtnAddContent_Click(object sender, EventArgs e)
        {
            AddInstructions addInsForm = new AddInstructions();
            addInsForm.Show();
            this.Hide();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Game gform = new Game();
            gform.Show();
            this.Hide();
        }

        private void BtnSeeAns_Click(object sender, EventArgs e)
        {
            ViewAnswers eform = new ViewAnswers(lastGameQuestions, lastGameAnswers);
            eform.Show();
            this.Hide();
        }

        private void BtnSameGameAgain_Click(object sender, EventArgs e)
        {
            Game gform = new Game(playerName, lastGameQuestions);
            gform.Show();
            this.Hide();
        }
    }
}
