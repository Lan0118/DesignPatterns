using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 工厂方法模式
    /// 抽象创建者类:子类实现此类创建产品
    /// </summary>
    public abstract class PizzaStore
    {    
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        //创建产品
        public abstract Pizza createPizza(string type);
    }
}
