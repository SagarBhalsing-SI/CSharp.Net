using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagement
{
    internal class Student
    {
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public int studentId { get; set; }
        public string enrolledCourse
        {
            get; 
            set ; }
        
        public double gpa { get; set; }


        public override string ToString()
        {
            return $"Name: {name}  Id: {studentId}  Age: {age}  Gender: {gender}  Enrolled Course: {enrolledCourse}  GPA:{gpa} ";
        }
    }
}
