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
    class StudentUI
    {
        private string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        Student currentStudent; // Object Variable

        public void MainMethod()
        {
            currentStudent = new Student(272727, "Will Smith");
            FillHours();
            DisplayData();
            DisplayAverage();
        }

        public void FillHours()
        {
            for (int i = 0; i < days.Length; i++)
            {
                Console.Write("Enter hours for " + days[i] + "=>");

                double value;

                double.TryParse(Console.ReadLine(), out value);

                currentStudent.SetHours(value, i);
            }
        }

        public void DisplayData()
        {
            Console.WriteLine("*****************************************************");
            Console.WriteLine(currentStudent.Id + "\t" + currentStudent.Name);
            Console.WriteLine("Hours \tStudied");
            Console.WriteLine("*****************************************************");

            for (int i = 0; i < days.Length; i++)
            {
                Console.Write(days[i] + " - " + currentStudent.GetHours(i) + "\n");
            }
        }

        public void DisplayAverage()
        {

            float average;

            Console.WriteLine("*****************************************************");
            Console.WriteLine(currentStudent.Id + "\t" + currentStudent.Name);

            average = currentStudent.GetAverageHours();
            Console.WriteLine("Average study hours for the week: " + average);
            Console.WriteLine("*****************************************************");
            Console.ReadLine();
        }
    }
}
