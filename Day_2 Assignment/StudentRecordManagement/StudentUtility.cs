using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagement
{
    internal class StudentUtility
    {
        Student s = new Student();
        UserInterface ui = new UserInterface();
        List<Student> studentList = new List<Student>()
        {
            new Student(){name="Sagar" , studentId=100, age=21,enrolledCourse="EXTC",gender="Male",gpa=4.0}
        };

        public void AddStudent()
        {
            List<double> grades = new List<double>(); 
            s.name=ui.getName();
            s.age=ui.getAge();
            s.studentId = ui.getId();
            s.gender = ui.getGender();
            s.enrolledCourse =ui.getenrolledCourse();
            grades=ui.getGrades();
            s.gpa=grades.Sum()/grades.Count;
            studentList.Add(s);
        }

        public void DisplayStudent()
        {
            Console.WriteLine("---------------------------------------Student List-------------------------------------------");
            Console.WriteLine("==============================================================================================");
            foreach (Student a in studentList)
            {
                Console.WriteLine(a);
            }
        }
    }
}
