namespace Bibliotekssystem2
{
    public class Book
    {
        public string author { get; set; }
        public string title { get; set; }
        public int ISBN { get; set; }
        public bool isBorrowed { get; set; } = false;

        public Book(string title, string author, int ISBN)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
        }

    }
}