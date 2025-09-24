using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2 {
    public class Librarian : User {
        public Librarian ( string name ) : base( name ) { }

        public override void ShowMenu ( List<Book> books ) {
            bool isRunning = true;

            while ( isRunning ) {
                Helpers.ColoredText( "\n=== Bibliotekssystem ===", ConsoleColor.Yellow );
                Helpers.ColoredText( $"\nHej {Name}, Välj ett alternativ: ", ConsoleColor.Yellow );
                Console.WriteLine( "1. Lägg till en bok" );
                Console.WriteLine( "2. Lista böcker" );
                Console.WriteLine( "0. Avsluta" );
                Helpers.ColoredText( "========================", ConsoleColor.Yellow );

                Console.Write( "Ditt val: " );
                string choice = Console.ReadLine();

                switch ( choice ) {
                    case "1":
                        AddBook( books );
                        break;

                    case "2":
                        ListBooks( books );
                        break;

                    case "0":
                        isRunning = false;
                        Console.WriteLine( "Hej då!" );
                        break;

                    default:
                        Console.WriteLine( "Ogiltigt val." );
                        break;
                }
            }
        }

        private void AddBook ( List<Book> books ) {
            Console.Write( "\nBokens titel: " );
            string title = Helpers.ValidateTitle( Console.ReadLine() );

            Console.Write( "Bokens författare: " );
            string author = Helpers.ValidateName( Console.ReadLine() );

            Console.Write( "Bokens ISBN: " );
            int isbn = Helpers.ValidateInt( Console.ReadLine() );

            foreach ( var book in books ) {
                if ( book.ISBN == isbn ) {
                    Helpers.ColoredText( "\nBok finns redan.", ConsoleColor.Red );
                    return;
                }
            }

            books.Add( new Book( title, author, isbn ) );
            Helpers.ColoredText( $"\nBoken \"{title}\" lades till.", ConsoleColor.Green );
        }

        private void ListBooks ( List<Book> books ) {
            if ( books.Count == 0 ) {
                Helpers.ColoredText( "\nInga böcker ännu.", ConsoleColor.Red );
                return;
            } else {
                Helpers.ColoredText( "\n=== Böcker ===", ConsoleColor.Yellow );

                foreach ( var book in books ) {
                    Console.WriteLine( $"{book.title} - Av: {book.author} - ISBN: {book.ISBN}" );
                }

                Helpers.ColoredText( "===============\n", ConsoleColor.Yellow );
            }
        }
    }
}
