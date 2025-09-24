namespace Bibliotekssystem
{
    using System;

    public class HeadMenu
    {
        public void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Välkommen till Bibliotekssystemet");
                Console.WriteLine("1. Logga in som bibliotekarie");
                Console.WriteLine("2. Logga in som låntagare");
                Console.WriteLine("0. Avsluta");
                Console.Write("Välj ett alternativ: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Ange ditt namn: ");
                        string librarianName = Console.ReadLine();
                        // TODO: Skapa instans av Librarian och visa dess meny
                        // new Librarian(librarianName).ShowMenu();
                        Console.WriteLine("(Librarian-meny skulle visas här)");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Ange ditt namn: ");
                        string borrowerName = Console.ReadLine();
                        // TODO: Skapa instans av Borrower och visa dess meny
                        // new Borrower(borrowerName).ShowMenu();
                        Console.WriteLine("(Borrower-meny skulle visas här)");
                        Console.ReadKey();
                        break;
                    case "0":
                        Console.WriteLine("Avslutar programmet...");
                        return;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen!");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    // TODO: Implementera klasserna Librarian och Borrower som ärver från User
    // TODO: Implementera klassen User (abstract) med Name och abstrakt metod ShowMenu()
    // TODO: Implementera klassen Book och interface ISearchable

    class Program
    {
        static void Main(string[] args)
        {
            new HeadMenu().Show();
        }
    }
}

