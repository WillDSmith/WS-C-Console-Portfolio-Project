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
    class HoodTalkTriviaGame
    {
       
        QuestionBank myQuestions;

        public void PlayAgain()
        {
            String response = "Y";
            do
            {
                Play();
                Console.WriteLine("\nDo you want to try again? Enter (Y)es or (N)o");
                response = Console.ReadLine();
                if (response.Length > 0)
                    response = response.Substring(0, 1);
                response = response.ToUpper();
            }
            while (response == "Y");
        }

        public void Play()
        {
            const int NUM = 5;
            myQuestions = new QuestionBank();
            string responseBack = "";
            int score = 5;
            bool result;

            Console.SetWindowSize(80, 50);
            

            result = myQuestions.ReadQuestionFile();


            if (result == true)
            {
                for (int i = 0; i < myQuestions.GetNumberOfQuestions; i++)
                {
                    Console.WriteLine(myQuestions.GetQuestion(i) + "\n");

                    var answers = myQuestions.GetAnswer(i);
                    for (int j = 0; j < myQuestions.GetNumberOfAnswers; j++)
                    {
                        Console.WriteLine(answers[j]);
                    }
                    Console.WriteLine("");
                    responseBack = PromptForGuess();

                    if (responseBack.Length > 0)
                        responseBack = responseBack.Substring(0, 1);
                    responseBack = responseBack.ToUpper();

                    if (responseBack == myQuestions.GetCorrectAnswer(i))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("That is correct\t\t\t" + "SCORE: " + score + "\n");
                        score += NUM;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is incorrect!!!!!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(myQuestions.GetExplanation(i) + "\n");
                        Console.ResetColor();
                    }
                }
            }
            if (result == false)
            {
                Console.WriteLine("There was an IO error, check to make sure file exists", "IO Error");
            }

        }

        public string PromptForGuess()
        {
            string response = " ";

            Console.Write("Make a selection, A - D-> ");
            response = Console.ReadLine();
            return response;
        }
    }
}
