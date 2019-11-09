using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class MenuItem
    {
        private string name;
        private string description;
        private bool vegetarian;
        private double price;

        public MenuItem(string name,string description,bool vegetarian,double price)
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
    }

}
