using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2
{
    public abstract class User //skapat en user abstract class
    {
        public string Name { get; }
        protected User(string name)
        {
            Name = name;
        }
        public abstract void ShowMenu(List<Book> books); //abstract method for showing menu
    }
}
