using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 具体创建者
    /// 工厂方法模式 NyStylePizzaStore
    /// </summary>
    class NyStylePizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new NyStyleCheesePizza();
            }else if (type.Equals("veggie"))
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
