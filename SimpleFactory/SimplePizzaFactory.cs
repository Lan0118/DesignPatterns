using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 简单披萨工厂:负责创建披萨实例
    /// 负责产品的创建,对修改开放
    /// </summary>
    class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }else if (type.Equals("veggie"))
            {
                pizza = new VeggiePizza();
            }else if (type.Equals("clam"))
            {
                pizza = new ClamPizza();
            }
            return pizza;
        }

    }
}
