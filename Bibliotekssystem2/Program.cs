namespace Bibliotekssystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian = new Librarian( "Felix" );
            librarian.ShowMenu( new List<Book>() );
        }
    }
}
