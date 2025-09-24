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
                var choice = Console.ReadLine();

                User user = choice switch
                {
                    "1" => CreateUser<Librarian>("Bibliotekarie"),
                    "2" => CreateUser<Borrower>("Låntagare"),
                    "3" => null,
                    _ => null
                };

                if (user == null)
                {
                    if (choice == "3") break;
                    Console.WriteLine("Ogiltigt val, försök igen.");
                    continue;
                }

                user.ShowMenu(books);
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
