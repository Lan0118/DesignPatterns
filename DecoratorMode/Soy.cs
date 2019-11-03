using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 具体装饰者
    /// 配料:豆浆
    /// </summary>
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = this.getDescription();
        }

        public override double cost()
        {
            double cost = this.beverage.cost();
            if(getSize() == 0)
            {
                cost += 0.10;
            }else if(getSize() == 1)
            {
                cost += 0.20;
            }
            else
            {
                cost += 0.30;
            }
            return cost;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + ", Soy";
        }

        public override int getSize()
        {
            return this.beverage.getSize();
        }
    }
}
