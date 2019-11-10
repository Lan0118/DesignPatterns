using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompisitePattern
{
    public class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            allMenus.print();
        }

        public void printVegetarianMenu()
        {
            IEnumerator enumerator = allMenus.createIterator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (menuComponent.isVegetarian())
                    {
                        menuComponent.print();
                    }
                }
                catch (NotImplementedException e) { }
            }
        }

    }
}
