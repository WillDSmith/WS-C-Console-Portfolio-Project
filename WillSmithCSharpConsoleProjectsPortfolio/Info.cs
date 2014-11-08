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
    class Info
    {
        //Display student information
        public void DisplayInfo(string assignment)
        {
            Console.WriteLine("************************************************************************");
            Console.WriteLine("Student Name:     Will Smith");
            Console.WriteLine("Course Name:      ITDEV115 - Intermediate Object-Oriented Programming");
            Console.WriteLine("Instructor Name:  Ms. Judy Ligocki");
            Console.WriteLine("Assignment:       " + assignment);
            Console.WriteLine("Date:             " + System.DateTime.Today.ToShortDateString());
            Console.WriteLine("************************************************************************\n");

        }
    }
}
