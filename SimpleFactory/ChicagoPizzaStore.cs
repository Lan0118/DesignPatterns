using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// ���崴����
    /// ��������ģʽ
    /// ����:��ͬ�ط��ļ��˵�
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
