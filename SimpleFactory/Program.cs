using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //选择在某家店购买pizza
            PizzaStore nyStore = new NyStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine(pizza.getName() + '\n');

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine(pizza.getName() + '\n');

            Console.ReadLine();
        }
    }
}
