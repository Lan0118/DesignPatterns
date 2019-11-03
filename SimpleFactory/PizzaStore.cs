using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// ��������ģʽ
    /// ���󴴽�����:����ʵ�ִ��ഴ����Ʒ
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

        //������Ʒ
        public abstract Pizza createPizza(string type);
    }
}
