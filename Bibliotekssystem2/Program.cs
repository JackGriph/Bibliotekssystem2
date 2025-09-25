namespace Bibliotekssystem2
{
    class Program
    {
        static void Main()
        {
            var books = new List<Book>();
            while (true)
            {
                Console.WriteLine("\nVälkommen till Bibliotekssystemet");
                Console.WriteLine("1. Logga in som Bibliotekarie");
                Console.WriteLine("2. Logga in som Låntagare");
                Console.WriteLine("3. Avsluta");
                Console.Write("Val: ");

                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Librarian librarian = CreateUser<Librarian>( "Bibliotekarie" );
                        librarian.ShowMenu( books );
                        break;

                    case "2":
                        Borrower borrower = CreateUser<Borrower>( "Låntagare" );
                        borrower.ShowMenu( books );
                        break;

                    case "3":
                        Environment.Exit( 0 );
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        continue;
                };
            }

            Console.WriteLine("Hejdå!");
        }

        private static T CreateUser<T>(string role) where T : User
        {
            Console.Write($"Ange ditt namn ({role}): ");
            var name = Console.ReadLine();
            return (T)Activator.CreateInstance(typeof(T), name);
        }
    }
}
