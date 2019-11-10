using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompisitePattern
{
    /// <summary>
    /// ²Ëµ¥Ïî
    /// </summary>
    class MenuItem: MenuComponent
    {
        private string name;
        private string description;
        private double price;
        private bool vegetarian;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public string getName()
        {
            return name;
        }
        public string getDescription()
        {
            return description;
        }
        public double getPrice()
        {
            return price;
        }
        public bool isVegetarian()
        {
            return vegetarian;
        }
        public void print()
        {
            Console.Write("  " + getName());
            if (isVegetarian())
            {
                Console.Write("(v)");
            }
            Console.Write(", " + getPrice());
            Console.WriteLine("    --  " + getDescription());
        }

        public void add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public void remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public MenuComponent getChild(int i)
        {
            throw new NotImplementedException();
        }

        public IEnumerator createIterator()
        {
            return new NullableIterator(); 
        }
    }
}
