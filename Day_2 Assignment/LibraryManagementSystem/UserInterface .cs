using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class UserInterface
    {
        public string getTitle()
        {
            Console.WriteLine("Enter Title of Book: ");
            string title = Console.ReadLine();
            return title;
        }

        public string getAuthor()
        {
            Console.WriteLine("Enter Name of Author: ");
            string author = Console.ReadLine();
            return author;
        }

        public int getQuantity()
        {
            Console.WriteLine("Enter Quantity of Books: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            return quantity;
        }

        public string getGenre()
        {
            Console.WriteLine("Enter Genre of Book: ");
            string genre = Console.ReadLine();
            return genre;
        }
    }
}
