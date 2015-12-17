using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //manual dependency injection
            var logger1 = new Logger1();
            var logger2 = new Logger2();
            Item item1 = new Item(logger1);
            Item item2 = new Item(logger2);


            //DI with unity
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ILogger, Logger1>();

            Item item3 = container.Resolve<Item>();

            Console.ReadKey();
        }
    }
}
