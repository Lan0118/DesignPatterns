using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 具体装饰者
    /// 配料:奶泡
    /// </summary>
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = this.getDescription();
        }

        public override double cost()
        {
            return this.beverage.cost() + 0.35;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + ",Whip";
        }

        public override int getSize()
        {
            throw new NotImplementedException();
        }
    }
}
