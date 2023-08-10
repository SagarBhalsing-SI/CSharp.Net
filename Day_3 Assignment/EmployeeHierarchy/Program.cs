namespace EmployeeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.employeeName = "Sagar";
            manager.employeeId = 99;
            manager.employeeSalary = 30000;
            manager.CalculateBonus();

            Console.WriteLine("\n");

            Developer developer = new Developer();
            developer.employeeName = "Anchal";
            developer.employeeId = 89;
            developer.employeeSalary = 30000;
            developer.CalculateBonus();

            Console.WriteLine("\n");

            SalesPerson salesPerson = new SalesPerson();
            salesPerson.employeeName = "Sapna";
            salesPerson.employeeId = 29;
            salesPerson.employeeSalary = 25000;
            salesPerson.CalculateBonus();

        }
    }
}