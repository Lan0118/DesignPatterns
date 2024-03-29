using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// �����Ʒ��
    /// </summary>
    public abstract class Pizza
    {
        protected string name;
        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Clams clams;
        protected Pepperoni pepperoni;
        protected Cheese cheese;

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Baking...");
        }

        public void cut()
        {
            Console.WriteLine("Cutiing...");
        }

        public void box()
        {
            Console.WriteLine("Boxing...");
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string toString()
        {
            return null;
        }
    }
}
