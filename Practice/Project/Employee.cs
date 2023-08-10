using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Employee
    {
        int id;
        string name;
        double bPay;
        double salary;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double BPay
        {
            get { return bPay; }
            set
            {
                if (value < 1000)
                { bPay = 1000; }
                else { bPay = value; }
            }
        }
         public double Salary
        {
            get { return salary; }
            
        }
         public void CalculateSalary( double bPay,double deduction)
        {
            this.salary = bPay-deduction;
        }
        public   string Ranking {  get;  set; }
        public static void Main()
        {
            Employee e1 = new Employee();
            e1.Name = "Sagar";
            e1.id = 610;
            e1.CalculateSalary(30000.0 , 2000.0);

            Console.WriteLine($"{e1.Name}'s salary is {e1.salary}");

        }
    } }

