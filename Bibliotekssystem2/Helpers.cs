using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public static string ValidateName( string input ) {
            while ( true ) {
                if ( !string.IsNullOrWhiteSpace( input ) && Regex.IsMatch( input, @"^[A-Za-z\ ]+$" ) ) {
                    input = input.Trim();

                    return char.ToUpper( input[0] ) + input.Substring( 1 ).ToLower();
                } else {
                    Console.WriteLine( "Invalid input. Please try again." );
                    input = Console.ReadLine();
                }
            }
        }

        public static string ValidateTitle( string input ) {
            while ( true ) {
                if ( !string.IsNullOrWhiteSpace( input ) && Regex.IsMatch( input, @"^[A-Za-z\ ]+$" ) ) {
                    input = input.Trim();

                    TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

                    return textInfo.ToTitleCase( input.ToLower() );
                }
            }
        }

        public static void ColoredText ( string text, ConsoleColor color ) {
            Console.ForegroundColor = color;
            Console.WriteLine( text );
            Console.ResetColor();
        }
    }
}
