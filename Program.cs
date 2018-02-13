using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu MenuGe;

            MenuGe = new Menu(new BalusShaurma());
            MenuGe.CreateShaurma();

            MenuGe = new Menu(new GldanisShaurma());
            MenuGe.CreateShaurma();

            
            MenuGe = new Menu(new MayvalasShaurma());
            MenuGe.CreateShaurma();

            Console.WriteLine();


            var derivedTypes = (from t in Assembly.GetExecutingAssembly().GetTypes()
                               where t.GetInterfaces().Any(x => x== typeof(IShaurma))
                               select t).ToList();

            foreach (var item in derivedTypes)
            {
                Console.WriteLine(item.Name + " ");
            }

            Console.Read();

        }
    }
}
