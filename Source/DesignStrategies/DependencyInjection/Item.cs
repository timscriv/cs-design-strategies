using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public class Item
    {
        public Item(ILogger logger)
        {
            logger.WriteToLog("New Item");
        }
    }
}
