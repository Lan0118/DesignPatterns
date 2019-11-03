using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// ����װ����
    /// ����:Ħ��
    /// </summary>
    class Mocha : CondimentDecorator
    {
        //����ʵ��:��װ����
        Beverage beverage;
        //����װ���߼�¼��ʵ����¼��
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
