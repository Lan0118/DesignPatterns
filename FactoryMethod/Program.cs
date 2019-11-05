using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYPizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            Pizza pizza = nyPizzaStore.orderPizza("cheese");
            Console.WriteLine("Van order a " + pizza + '\n');
            pizza = chicagoPizzaStore.orderPizza("cheese");
            Console.WriteLine("Bob order a " + pizza + '\n');

            pizza = nyPizzaStore.orderPizza("clam");
            Console.WriteLine("Van order a " + pizza + '\n');
            pizza = chicagoPizzaStore.orderPizza("clam");
            Console.WriteLine("Bob order a " + pizza + '\n');

            pizza = nyPizzaStore.orderPizza("veggies");
            Console.WriteLine("Van order a " + pizza + '\n');
            pizza = chicagoPizzaStore.orderPizza("veggies");
            Console.WriteLine("Bob order a " + pizza + '\n');

            pizza = nyPizzaStore.orderPizza("pepperoni");
            Console.WriteLine("Van order a " + pizza + '\n');
            pizza = chicagoPizzaStore.orderPizza("pepperoni");
            Console.WriteLine("Bob order a " + pizza + '\n');

            Console.ReadKey();
        }
    }
}
