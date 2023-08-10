namespace Project
{
    internal class Book
    {
        string bookName;
        int bookPrice;
        string author;
        string genre;
        int quantity;
        public Book(int bookPrice,string bookName,string author, string genre)
        {
            this.bookPrice = bookPrice;
            this.bookName = bookName;
            this.author = author;
            this.genre = genre;
        }

        public int bookPrice
        {
            get { return bookPrice; }
            set {; }
        }
        public string BookName
        {
            get { return bookName; }
            set {; }
        }
        
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


    }

}

