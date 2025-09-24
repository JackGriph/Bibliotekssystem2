using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2 {
    public class Librarian : User {
        public Librarian ( string name ) : base( name ) { }

        public override void ShowMenu (List<Book> books) {
            bool isRunning = true;

            while ( isRunning ) {
                Helpers.ColoredText( "=== Bibliotekssystem ===", ConsoleColor.Yellow );
                Helpers.ColoredText( $"\nHej {Name}, Välj ett alternativ: ", ConsoleColor.Yellow );
                Console.WriteLine( "1. Lägg till en bok" );
                Console.WriteLine( "2. Lista böcker" );
                Console.WriteLine( "0. Avsluta" );
                Helpers.ColoredText( "=======================", ConsoleColor.Yellow );

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
            Console.Write( "\nBokens titel:" );
            string title = Console.ReadLine();

            Console.Write( "Bokens författare:" );
            string author = Console.ReadLine();

            Console.Write( "Bokens ISBN: " );
            int isbn = Helpers.ValidateInt( Console.ReadLine() );

            foreach ( var book in books ) {
                if ( book.ISBN == isbn ) {
                    Console.WriteLine( "Bok finns redan." );
                    return;
                }
            }

            books.Add( new Book( title, author, isbn ) );
            Console.WriteLine( "Boken lades till." );
        }

        private void ListBooks ( List<Book> books ) {
            Console.WriteLine( "\nBöcker:" );

            if ( books.Count == 0 ) {
                Console.WriteLine( "Inga böcker inlagda ännu." );
                return;
            } else {
                foreach ( var book in books ) {
                    Console.WriteLine( $"{book.ISBN} - {book.title} - {book.author}" );
                }
            }
        }
    }
}
