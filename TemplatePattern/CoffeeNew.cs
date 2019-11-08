using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class CoffeeNew : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("adding Milk and Sugar...");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
