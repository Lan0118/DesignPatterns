using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //ÒûÁÏ:Å¨Ëõ¿§·È
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "Espresso Å¨Ëõ¿§·È";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
