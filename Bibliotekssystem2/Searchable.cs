using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekssystem2
{
    public interface  ISearchable 
    {
        List<Book> Search(List<Book> books, string keyword);
    }
}
