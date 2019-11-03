using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //ÒûÁÏ:ÐÇ°Í×È¿§·È
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend Coffee ÐÇ°Í×È¿§·È";
        }

        public override double cost()
        {
            return 1.89;
        }
    }
}
