using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Grading
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Number of students to be registered");
            int numb = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int [numb];
            string[] name = new string [numb];
            string[] grade = new string[numb];
            for (int i = 0; i < numb; i++)
            {
                Console.WriteLine("Enter name:");
                name[i]= Console.ReadLine();
                Console.WriteLine("Enter Marks");
                marks[i]= Convert.ToInt32(Console.ReadLine());
                if (marks[i] >= 91 || marks[i] <= 100)
                {
                    grade[i] = "A1";
                }
                else if (marks[i] >= 81 || marks[i] <= 90)
                {
                    grade[i] = "A2";
                }
                else if (marks[i] >= 71 || marks[i] <= 80)
                {
                    grade[i] = "B1";
                }
                else if (marks[i] >= 61 || marks[i] <= 70)
                {
                    grade[i] = "B2";
                }
                else if (marks[i] >= 51 || marks[i] <= 60)
                {
                    grade[i] = "C1";
                }
                else if (marks[i] >= 41 || marks[i] <= 50)
                {
                    grade[i] = "C2";
                }
                else if (marks[i] >= 33 || marks[i] <= 40)
                {
                    grade[i] = "D1";
                }
                else if (marks[i] >= 21 || marks[i] <= 32)
                {
                    grade[i] = "D2";
                }
                else if (marks[i] >= 11 || marks[i] <= 20)
                {
                    grade[i] = "E1";
                }

            }
            Console.WriteLine("Name      Marks    Grade");
            for (int i = 0;i < numb; i++)
            {
                Console.WriteLine(name[i]+"      "+ marks[i]+"     " + grade[i]);
            }

        }
    }
}
