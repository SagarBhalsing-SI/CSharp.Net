using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    internal abstract class Employee
    {
        public string employeeName { get; set; }
        public int employeeId{get; set;}
        public double employeeSalary { get; set; }

        public abstract void CalculateBonus();
    }

    class Manager:Employee
    {
        public override void CalculateBonus()
        {
            double bonus = (employeeSalary*0.15);
            Console.WriteLine($"Name: {employeeName}   Id: {employeeId}   Salary: {employeeSalary}   Bonus:{bonus}");
        }
    }
    class Developer:Employee
    {
        public override void CalculateBonus()
        {
            double bonus = (employeeSalary * 0.10);
            Console.WriteLine($"Name: {employeeName}   Id: {employeeId}   Salary: {employeeSalary}   Bonus:{bonus}");

        }
    }
    class SalesPerson:Employee
    {
        public override void CalculateBonus()
        {
            double bonus  = ((employeeSalary *0.05));
            Console.WriteLine($"Name: {employeeName}   Id: {employeeId}   Salary: {employeeSalary}   Bonus:{bonus}");
        }
    }
}
