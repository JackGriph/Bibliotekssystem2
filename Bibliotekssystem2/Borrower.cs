using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2
{
    public class Borrower : User, ISearchable // Implementerar ISearchable interfacet

    {
        public Borrower(string name) : base(name) { }
        public override void ShowMenu(List<Book> books)
        {
            while (true)
            {
                Console.WriteLine($"\nVälkommen, {Name}! Välj ett alternativ:");
                Console.WriteLine("1. Sök Bok:");
                Console.WriteLine("2. Låna bok");
                Console.WriteLine("3. Lista böcker");
                Console.WriteLine("4. Lämna tillbaka bok");
                Console.WriteLine("5. Logga ut");
                Console.WriteLine("Val: ");
                var choice = Console.ReadLine();

                switch (choice) // Switch-sats för att hantera användarens val
                {
                    case "1":
                        Console.WriteLine("Sökterm (titel eller författare): ");
                        var term = Console.ReadLine();
                        var found = Search(books, term);
                        if (found.Any())
                            found.ForEach(b => Console.WriteLine($"{b.title} av {b.author} (ISBN: {b.ISBN})"));
                        else
                            Console.WriteLine("Inga böcker hittades.");
                        break;
                    case "2":
                        BorrowBook(books);
                        break;
                    case "3":
                        ListBooks(books);
                        break;
                    case "4":
                        ReturnBook(books);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;

                }

            }

        }

        public List<Book> Search(List<Book> books, string keyword) // Implementering av Search-metoden från ISearchable interfacet
        {
            return books
        .Where(b => b.title.Contains(keyword, StringComparison.OrdinalIgnoreCase)
        || b.author.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        private void BorrowBook(List<Book> books) // Metod för att låna en bok
        {
            // genererad med Copilot
            Console.WriteLine("Ange ISBN för boken du vill låna: ");
            var isbn = Console.ReadLine();
            var book = books.FirstOrDefault(b => b.ISBN.ToString() == isbn);
            if (book == null)
            {
                Console.WriteLine("Boken finns inte i systemet.");

            }
            else if (book.isBorrowed)
            {
                Console.WriteLine("Boken är redan utlånad.");
            }
            else
            {
                book.isBorrowed = true;
                Console.WriteLine($"Du har lånat '{book.title}' av {book.author}. Lycka till med läsningen!");
            }
        }
        private void ListBooks(List<Book> books) 
        {
            Console.WriteLine("\nTillgängliga böcker:");
            foreach (var book in books)
            {
                
                Console.WriteLine($"{book.title} av {book.author} (ISBN: {book.ISBN})");
            }
        }
        private void ReturnBook(List<Book> books)
        {
            Console.Write("Ange ISBN för återlämning: ");
            var isbn = Console.ReadLine();
            var book = books.FirstOrDefault(b => b.ISBN.ToString() == isbn);
            if (book == null)
            {
                Console.WriteLine("Boken finns inte i systemet.");
            }
            else if (!book.isBorrowed)
            {
                Console.WriteLine("Boken är inte utlånad.");
            }
            else
            {
                book.isBorrowed = false;
                Console.WriteLine($"Tack för att du återlämnade '{book.title}'. Välkommen åter!"); // Tack-meddelande vid återlämning


            }
        }
    }
}


    

