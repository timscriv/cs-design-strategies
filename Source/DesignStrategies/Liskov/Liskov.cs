using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Liskov
    {
        static void PrintSequence<T>(IEnumerable<T> items)
        {
            //Kinda breaks the principle
            //if(items is IList<T>)
            //{
            //    //Do something
            //}
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
