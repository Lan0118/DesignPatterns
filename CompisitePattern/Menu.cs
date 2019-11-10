using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompisitePattern
{
    /// <summary>
    /// 实现组合菜单
    /// </summary>
    public class Menu: MenuComponent
    {
        private ArrayList menuComponents = new ArrayList();
        private string name;
        private string description;
        private IEnumerator enumerator = null;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public  void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public MenuComponent getChild(int i)
        {
            return (MenuComponent)menuComponents[i];
        }

        public  string getName()
        {
            return name;
        }
        public string getDescription()
        {
            return description;
        }
        public void print()
        {
            Console.Write("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("----------------------------");

            IEnumerator enumerator = menuComponents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                menuComponent.print();
            }
        }

        public double getPrice()
        {
            throw new NotImplementedException();
        }

        public bool isVegetarian()
        {
            throw new NotImplementedException();
        }

        public IEnumerator createIterator()
        {
            if(enumerator == null)
            {
                enumerator = new CompositeIterator(menuComponents.GetEnumerator());
            }
            return enumerator;
        }
    }
}
