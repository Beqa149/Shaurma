using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Menu
    {
        private IShaurma _shaurma;

        public Menu(IShaurma shaurma)
        {
            this._shaurma = shaurma;
        }

        public void CreateShaurma()
        {
            _shaurma.GetShaurma();
        }
    }
}
