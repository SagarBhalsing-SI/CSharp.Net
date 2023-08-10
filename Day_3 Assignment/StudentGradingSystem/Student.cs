using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradingSystem
{
    internal class Student
    {
        List<int> grade =new List<int>();
        public void TakeInput()
        {
            Console.WriteLine("Enter name of student:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter number of grades to be entered: ");
            int noGrades = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < noGrades; i++)
            {
                Console.WriteLine($"{1} Enter Grade: ");
                try
                {
                    int gradee = Convert.ToInt32(Console.ReadLine());
                    grade.Add(gradee);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine(e.Message);
                    i = i - 1;


                }
               
            } 
            Console.WriteLine($"Average grades obtained by {name} is {grade.Sum()/grade.Count()}");

            
        }
    }
}
