using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //����:�ǰ��ȿ���
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.description = "House Blend Coffee �ǰ��ȿ���";
        }

        public override double cost()
        {
            return 1.89;
        }
    }
}
