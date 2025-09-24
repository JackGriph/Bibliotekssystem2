using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2 {
    internal class Helpers {
        public static int ValidateInt ( string input ) {
            while( true ) {
                if ( int.TryParse( input, out int result ) ) {
                    return result;
                } else {
                    Console.WriteLine( "Invalid input. Please try again." );
                    input = Console.ReadLine();
                }
            }
        }
    }
}
