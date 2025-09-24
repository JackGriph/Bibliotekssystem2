using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2
{
    public class Borrower : User, ISearchable { }// Implementerar ISearchable interfacet

    {
        public Borrower( string name) : base(name) { } 
        public override void ShowMenu(List<Book> books)
        {
            while (true) {
            Console.WriteLine($"\nVälkommen, {name}! Välj ett alternativ:");
                Console.WriteLine("1. Sök Bok:");
            Console.WriteLine("2. Låna bok");
            Console.WriteLine("3. Lämna tillbaka bok");
            Console.WriteLine("4. Logga ut");
            Console.WriteLine("Val: ");
                var choice = Console.ReadLine();

            switch (choice) // Switch-sats för att hantera användarens val
            {
                case "1":
                    Console.WriteLine("Sökterm (titel eller författare): ");
                    var term = Console.ReadLine();
                    var found = Search(books, term);
                    if (found.Any())
                        found.forEach(b => Console.WriteLine($"{b.Title} av {b.Author} (ISBN: {b.ISBN})"));
                    else
                        Console.WriteLine("Inga böcker hittades.");
                    break;
                    case "2":
                    BorrowBook (books);
                    break;
                    case "3":
                    ReturnBook(books);
                    break;
                    case "4":
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

    
}
