using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 服务员对象
    /// </summary>
    public class Waitress
    {
        private Menu pancakeHouseMenu;
        private Menu dinerMenu;
        //public Menu cafeMenu;

        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu)
        {
            this.pancakeHouseMenu = pancakeHouseMenu;
            this.dinerMenu = dinerMenu;
            //this.cafeMenu = cafeMenu;
        }

        public void printMenu()
        {
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();
            //Iterator cafeIterator = cafeMenu.createIterator();
            Console.WriteLine("Menu\n------\nBreakfast");
            printMenu(pancakeIterator);
            Console.WriteLine("\nLunch");
            printMenu(dinerIterator);
            //Console.WriteLine("\nDinner");
            //printMenu(cafeIterator);
        }

        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem)iterator.next();
                Console.Write(menuItem.getName() + ", ");
                Console.Write(menuItem.getPrice() + " -- ");
                Console.WriteLine(menuItem.getDescription());
            }
        }

    }
}
