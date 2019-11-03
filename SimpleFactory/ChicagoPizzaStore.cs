using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 具体创建者
    /// 工厂方法模式
    /// 场景:不同地方的加盟店
    /// </summary>
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoCheesePizza();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            return pizza;
        }
    }
}
