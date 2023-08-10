using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagement
{
    internal class UserInterface
    {
        List<double> Grades = new List<double>();
        public int getId()
        {
            Console.WriteLine("Enter Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            return id;
        }
        public string getName()
        {
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();
            return firstName;
        }

        public int getAge()
        {
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        public string getGender()
        {
            Console.WriteLine("Enter Gender:");
            string gender = Console.ReadLine();
            return gender;
        }

        public string getenrolledCourse()
        {
            Console.WriteLine("Enter Enrolled Course:");
            string course = Console.ReadLine();
            return course;
        }

        public  List<double> getGrades()
        {
            Console.WriteLine("Enter your current Semester:");
            int sem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Grades:");
            for (int i = 0; i < sem-1; i++)
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                Grades.Add(grade);
            }

            return Grades;


        }

    }
}
