using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class TornikesShaurma : IShaurma
    {
        public void GetShaurma()
        {
            Console.WriteLine("Yvelaze yleoba shaurma");
        }
    }
}
