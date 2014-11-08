// Portfolio Program
// Programmer: Willie D Smith
// 05/12/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WillSmithCSharpConsoleProjectsPortfolio
{
    class QuestionUnit
    {
        private string correctAnswer;
        private string explanation;
        private string question;
        private string[] answer = new string[4];

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
        public string Explanation
        {
            get { return explanation; }
            set { explanation = value; }
        }
        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        public string[] Answer
        {
            get { return answer; }
            set { answer = value; }
        }
    }
}
