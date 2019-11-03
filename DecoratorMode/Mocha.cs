using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 具体装饰者
    /// 配料:摩卡
    /// </summary>
    class Mocha : CondimentDecorator
    {
        //饮料实例:被装饰者
        Beverage beverage;
        //将被装饰者记录到实例记录中
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            this.description = this.getDescription();
        }

        public override double cost()
        {
            return this.beverage.cost() + 0.2;
        }

        public override string getDescription()
        {
            return this.beverage.getDescription() + ",Mocha";
        }

        public override int getSize()
        {
            throw new NotImplementedException();
        }
    }
}
