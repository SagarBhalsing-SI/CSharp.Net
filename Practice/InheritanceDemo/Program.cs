namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee e1 = new Employee(10, "Sagar");
            Employee e2 = new Employee(10, "Sagar");
            Employee e3 = e2;

            Student s1 = new Student();
            DaySchooler d1 = new DaySchooler();
            Console.WriteLine(e1);
            Console.WriteLine(s1);
           /* Console.WriteLine("Enter if 1:Day Schooler and 2:Hostller");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        DaySchooler s1 = new DaySchooler();
                        Console.WriteLine("Enter Name:");
                        s1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Depratement:");
                        s1.Department = Console.ReadLine();
                        Console.WriteLine("Enter Bus Route");
                        s1.busRoute = Console.ReadLine();
                        s1.Display();
                    }
                    break;

                case 2:
                    {
                        Hostel h1 = new Hostel();
                        Console.WriteLine("Enter Name:");
                        h1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Depratement:");
                        h1.Department = Console.ReadLine();
                        h1.Display();
                    }
                    break;*/
            }
        }
    }
