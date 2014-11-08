// Portfolio Program
// Programmer: Willie D Smith
// 05/12/2014

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WillSmithCSharpConsoleProjectsPortfolio
{
    class QuestionBank
    {
        List<QuestionUnit> theQuestionsList = new List<QuestionUnit>();


        const int NUM_ANSWERS = 4;
        const int NUM_QUESTIONS = 5;

        public int GetNumberOfAnswers
        {
            get { return NUM_ANSWERS; }
        }
        public int GetNumberOfQuestions
        {
            get { return NUM_QUESTIONS; }
        }
        public string GetCorrectAnswer(int index)
        {
            return theQuestionsList[index].CorrectAnswer;
        }
        public string GetExplanation(int index)
        {
            return theQuestionsList[index].Explanation;
        }
        public string GetQuestion(int index)
        {
            return theQuestionsList[index].Question;
        }
        public string[] GetAnswer(int index)
        {
            return theQuestionsList[index].Answer;
        }
        public bool ReadQuestionFile()
        {
            bool success = true;

            FileInfo httSourceFile = new FileInfo("Questions.txt");
            string line;
            string[] fields;
            char[] delimiter = { System.Convert.ToChar(",") };
            QuestionUnit httQuestionUnit;
            //int i = 0;

            try
            {
                StreamReader httReader = httSourceFile.OpenText();

                line = httReader.ReadLine();

                while (line != null)
                {
                    httQuestionUnit = new QuestionUnit();

                    fields = line.Split(delimiter);

                    httQuestionUnit.Question = fields[0];

                    string[] aArray = new string[4];

                    aArray[0] = fields[1];
                    aArray[1] = fields[2];
                    aArray[2] = fields[3];
                    aArray[3] = fields[4];

                    httQuestionUnit.Answer = aArray;
                    httQuestionUnit.CorrectAnswer = fields[5];
                    httQuestionUnit.Explanation = fields[6];


                    theQuestionsList.Add(httQuestionUnit);

                    line = httReader.ReadLine();
                }

            }
            catch
            {
                success = false;
            }
            return success;
        }

    }
}
