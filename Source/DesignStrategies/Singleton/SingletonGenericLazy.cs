using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonGenericLazy
    {
        private static readonly Lazy<SingletonGenericLazy> lazy =
            new Lazy<SingletonGenericLazy>(() => new SingletonGenericLazy(), isThreadSafe: true);

        public static SingletonGenericLazy Instance { get { return lazy.Value; } }
        private SingletonGenericLazy()
        {

        }
    }
}
