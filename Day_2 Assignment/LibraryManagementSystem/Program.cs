namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();    
            string c;
            do
            {
                
                Console.WriteLine("========================Library Management====================");
                Console.WriteLine("==============================================================");
                Console.WriteLine("1.Add Book \n"+
                                  "2.Search Book by Title \n"+
                                  "3.Search Book by Author \n"+
                                  "4.Display Books in Library \n");

                Console.WriteLine("Enter your choice: ");
                int choice =Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            library.AddBook();
                            break;
                        }
                    case 2:
                        {
                            library.SearchByTitle();
                            break;
                        }
                    case 3:
                        {
                            library.SearchByAuthor(); 
                            break;
                        }
                    case 4:
                        {
                            library.DisplayBook(); 
                            break;
                        }
                }Console.WriteLine("Do you want to continue Y/N:");
                 c = Console.ReadLine();
            }while (c == "Y" || c=="y");
        }
    }
}