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
    class Student
    {
        private int id;
        private string name;
        private double[] hours = new double[7];


        public Student()
        {
        }

        public Student(int sId, string sName)
        {
            id = sId;
            name = sName;

            // Initialize Array
            for (int i = 0; i < hours.Length; i++)
            {
                hours[i] = 0;
            }
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void SetHours(double v, int i)
        {
            hours[i] = v;
        }

        public double GetHours(int i)
        {
            return hours[i];
        }

        // Calculate total hours
        public double GetNumberHours()
        {
            double total = 0;

            for (int i = 0; i < hours.Length; i++)
            {
                total += GetHours(i);
            }
            return total;
        }

        public float GetAverageHours()
        {

            float average = (float)GetNumberHours() / hours.Length;
            return average;
        }

    }
}
