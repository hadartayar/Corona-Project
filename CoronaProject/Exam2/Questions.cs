using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    public class Questions
    {
        int qnumber;
        int qtype;
        string question;
        string correctAns;
        string[] incorrectAnswer;

        public Questions()
        {
            this.Qnumber = 0;
            this.Qtype = 5;
            this.Question = "";
            this.CorrectAns = "";
            this.IncorrectAnswer = new string[0];
        }

        public Questions(int qnumber, int qtype, string question, string correctAns, string[] incorrectAnswer)
        {
            this.Qnumber = qnumber;
            this.Qtype = qtype;
            this.Question = question;
            this.CorrectAns = correctAns;
            this.IncorrectAnswer = incorrectAnswer;
        }

        public int Qnumber { get => qnumber; set => qnumber = value; }
        public int Qtype { get => qtype; set => qtype = value; }
        public string Question { get => question; set => question = value; }
        public string CorrectAns { get => correctAns; set => correctAns = value; }
        public string[] IncorrectAnswer { get => incorrectAnswer; set => incorrectAnswer = value; }
    }
}
