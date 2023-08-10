namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EmployeeUtility emput = new EmployeeUtility();
            UserInterface ui = new UserInterface();
            string option;
            do
            {
                Console.WriteLine("----------------------Employees----------------------");
                Console.WriteLine(" 1:Add Employee \n " +
                                "2:Search By Name \n " +
                                "3:Search By Id  \n " +
                                "4:Search All Employees Of Department \n " +
                                "5:Display Employees \n ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            string name = ui.getName();
                            int id = ui.getId();
                            string department = ui.getDepartment();
                            double salary = ui.getSalary();
                            Employee emp = emput.CreateEmployee(id, name, department, salary);
                            bool isAdded = emput.AddEmployee(emp);
                            if (isAdded) { Console.WriteLine("Employee Added Succesfully"); }
                            else
                            {
                                Console.WriteLine("Employee not Added");
                            }
                            emput.DisplayEmployees();
                            break;
                        }
                    case 2:
                        {
                            string name = ui.getName();
                            emput.SearchByName(name);
                            break;

                        }
                    case 3:
                        {
                            int id = ui.getId();
                            emput.SearchById(id);
                            break;
                        }

                    case 4:
                        {
                            string department = ui.getDepartment();
                            emput.SearchByDepartment(department);
                            break;
                        }
                    case 5:
                        {
                            emput.DisplayEmployees();
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue Y/N:");
                option = Console.ReadLine();
            } while (option == "Y");
            //Find Employee by Name ,Id, Same departement

            /* ArrayList list = new ArrayList();
             list.Add(1);
             list.Add(2);
             list.Add(3);
             list.Add("Sagar");
             list.Add("Anas");
             list.Add(new Array[4]);
             list.Add(new Hero());

             foreach (object item in list)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("\n");

             List<int> list1 = new List<int>();
             list1.Add(1);
             list1.Add(2);
             list1.Add(3);

             foreach(object item in list1)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("\n");

             List<double> list2 = new List<double>();
             list2.Add(1.90);
             list2.Add(20.45);
             list2.Add(90.21);

             foreach(object item in list2)
             {
                 Console.WriteLine(item);
             }

             Console.WriteLine("\n");

             List<string> list3 = new List<string>()
             { "Sagar","Anas","Jay","Anchal","Jay","Jay"};

             foreach(string item in list3)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine($"Count:{list3.Count}");
             Console.WriteLine($"Capacity:{list3.Capacity}");
             //Console.WriteLine(list3.Remove(list3[2]));
             Console.WriteLine(list3.Contains("Jay"));

             string name = Console.ReadLine();
             Console.WriteLine(" Predicate Methods\n");
             var result = list3.Find(ele => ele.Equals(name));

             list3.RemoveAll(ele => ele.Equals("Jay"));
             foreach (string item in list3)
             {
                 Console.WriteLine(item);*/
        }
    }
}

