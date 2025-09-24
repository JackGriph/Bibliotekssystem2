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
        public Borrower( string name) : base (name) { } 
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
            }
    }
}
