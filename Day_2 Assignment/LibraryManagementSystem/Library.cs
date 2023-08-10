using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Library
    {
        List<Book> BookList = new List<Book>()
        {
            new Book("Tales Of Demons And Gods","Tite Kubo","Fantsy",10),
            new Book("Martial Peak","Yang Kai","Fantasy",50),
        };
        UserInterface ui = new UserInterface();
        
        public void AddBook()
        {
            Book b = new Book(ui.getTitle(), ui.getAuthor(), ui.getGenre(), ui.getQuantity());
            BookList.Add(b);    
        }

        public void DisplayBook()
        {
            Console.WriteLine("---------------------------------------Book List-------------------------------------------");
            Console.WriteLine("==============================================================================================");
            foreach(Book b in BookList) 
            {
                Console.WriteLine(b);
            }
        }

        public void SearchByTitle()
        {
            string title=ui.getTitle();
            Book b = BookList.Find(e => e.bookName.Equals(title));
            Console.WriteLine(b);
        }

        public void SearchByAuthor()
        {
            string author=ui.getAuthor();
            Book b = BookList.Find(e=>e.author.Equals(author));
            Console.WriteLine(b);
        }
    }
}
