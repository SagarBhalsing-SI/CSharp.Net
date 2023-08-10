namespace Project
{
    internal class Library
    {
        public void add(string name)
        {
            List<Book> Books = new List<Book>();
            Console.WriteLine("Enter the Name of Book:");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter Book author:");
            string authorName = Console.ReadLine();
            Console.WriteLine("Enter book genre:");
            string bookGenre = Console.ReadLine();
            Book newBook = new Book(bookName, authorName, bookGenre);
            Books.Add(newBook);
        }

        public void 

    }

}
}
