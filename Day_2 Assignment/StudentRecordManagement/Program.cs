namespace StudentRecordManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentUtility s = new StudentUtility();
            string c;
            do
            {
                Console.WriteLine("---------------Student Console-------------");
                Console.WriteLine("1.Add Student\n" +
                                  "2.Display Student List\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            s.AddStudent();
                            break;
                        }
                    case 2:
                        {
                            s.DisplayStudent();
                            break;
                        }
                }
                Console.WriteLine("Do you want to exit:");
                c = Console.ReadLine();
            }while (c=="N");
        }
    }
}