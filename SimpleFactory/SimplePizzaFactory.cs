using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// ����������:���𴴽�����ʵ��
    /// �����Ʒ�Ĵ���,���޸Ŀ���
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
