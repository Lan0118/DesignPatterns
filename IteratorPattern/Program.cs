using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();
            //CafeMenu cafeMenu = new CafeMenu();

            //Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu, cafeMenu);
            Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);
            waitress.printMenu();

            Console.ReadKey();
        }
    }
}
