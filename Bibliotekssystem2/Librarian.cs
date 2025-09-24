using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2 {
    public class Librarian : User {
        public Librarian ( string name ) : base( name ) { }

        public override void ShowMenu () {
            bool isRunning = true;

            while ( isRunning ) {
                Console.WriteLine( "Librarian Menu" );
                Console.WriteLine( "1. Add book" );
                Console.WriteLine( "2. List books" );
                Console.WriteLine( "0. Exit" );

                string choice = Console.ReadLine();

                switch ( choice ) {
                    case "1":
                        AddBook();
                        break;

                    case "2":
                        ListBooks();
                        break;

                    case "0":
                        isRunning = false;
                        Console.WriteLine( "Goodbye!" );
                        break;

                    default:
                        Console.WriteLine( "Invalid choice. Please try again." );
                        break;
                }
            }
        }

        private void AddBook () {
            Console.WriteLine( "Enter book title:" );
            string title = Console.ReadLine();

            Console.WriteLine( "Enter book author:" );
            string author = Console.ReadLine();

            Console.WriteLine( "Entere ISBN: " );
            int isbn = Helpers.ValidateInt( Console.ReadLine() );

            foreach ( var book in Library.Books ) {
                if ( book.ISBN == isbn ) {
                    Console.WriteLine( "Book already exists." );
                    return;
                }
            }

            Library.Books.Add( new Book( title, author, isbn ) );
            Console.WriteLine( "Book added successfully." );
        }

        private void ListBooks () {
            Console.WriteLine( "\nAll books in the lirbrary" );

            if ( Library.Books.Count == 0 ) {
                Console.WriteLine( "No books in the library." );
                return;
            } else {
                foreach ( var book in Library.Books ) {
                    Console.WriteLine( book.ToString() );
                }
            }
        }
    }
}
