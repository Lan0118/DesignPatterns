using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("08042号订单内容:");
            Console.WriteLine("第一杯");
            Beverage beverage1 = new Espresso();

            Console.WriteLine(beverage1.getDescription() + " $" + beverage1.cost());

            Console.WriteLine("第二杯");
            Beverage beverage2 = new HouseBlend();
            beverage2.setSize(0);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());

            Console.ReadLine();


        }
    }
}
