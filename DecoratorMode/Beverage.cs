using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //“˚¡œ≥ÈœÛ¿‡
    public abstract class Beverage
    {
        protected string description = "Unkown Coffee";
        protected int size;
        
        public string getDescription()
        {
            return this.description;
        }

        public int getSize()
        {
            return this.size;
        }

        public void setSize(int size)
        {
            this.size = size;
        }


        public abstract double cost();
    }
}
