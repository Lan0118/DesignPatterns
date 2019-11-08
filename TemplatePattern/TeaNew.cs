using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class TeaNew : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("adding lemon...");
        }

        public override void brew()
        {
            Console.WriteLine("Stepping the tea");
        }
    }
}
