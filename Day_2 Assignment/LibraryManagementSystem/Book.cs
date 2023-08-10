using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Book
    {
        public string bookName{ get; set; }
        public string author { get; set; }
        public string genre { get; set; }
        public int quantity { get; set; }
        public Book( string bookName, string author, string genre,int quantity)
        {
            this.quantity = quantity;   
            this.bookName = bookName;
            this.author = author;
            this.genre = genre;
        }

 
       
        public override string ToString() 
        {
            return $"Title:{bookName}     Genre:{genre}    Author:{author}    Stock:{quantity}";
        }
    }
}
