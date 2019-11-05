using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 抽象产品类
    /// </summary>
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected ArrayList toppings = new ArrayList();

        public string getName()
        {
            return this.name;
        }


        public void prepare()
        {
            Console.WriteLine("Preparing..." + name);
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine("  " + toppings.IndexOf(i));
            }
        }

        public void bake()
        {
            Console.WriteLine("Baking...");
        }

        public void cut()
        {
            Console.WriteLine("Cuting...");
        }

        public void box()
        {
            Console.WriteLine("Boxing...");
        }
    }

}
