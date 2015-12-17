using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// If we don't really care about laziness we can use this simpler version
    /// http://csharpindepth.com/Articles/General/Singleton.aspx
    /// </summary>
    public class SingletonSimple
    {


        internal static readonly SingletonSimple _Instance = new SingletonSimple();

        private SingletonSimple()
        {
            // Stuff that must only happen once.
            Console.WriteLine("Singleton Ctor");
        }
        public static SingletonSimple Instance { get { return _Instance; } }

        public static void SayHi()
        {
            Console.WriteLine("Hello");
        }


        public void DoSomething()
        {

        }
    }
}
