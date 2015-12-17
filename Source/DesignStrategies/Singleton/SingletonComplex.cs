using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// This will force laziness
    /// http://csharpindepth.com/Articles/General/Singleton.aspx
    /// </summary>
    public class SingletonComplex
    {
        private static class SingletonHolder
        {
            internal static readonly SingletonComplex _Instance = new SingletonComplex();
            //Empty static constructor = forces laziness
            static SingletonHolder() { }
        }



        private SingletonComplex()
        {
            // Stuff that must only happen once.
            Console.WriteLine("Singleton Ctor");
        }
        public static SingletonComplex Instance { get { return SingletonHolder._Instance; } }

        public static void SayHi()
        {
            Console.WriteLine("Hello");
        }


        public void DoSomething()
        {

        }
    }
}
