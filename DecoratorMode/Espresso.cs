using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //����:Ũ������
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.description = "Espresso Ũ������";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
