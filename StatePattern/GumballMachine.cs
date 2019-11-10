using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// �ǹ���
    /// </summary>
    public class GumballMachine
    {
        //�ǹ�����4��״̬
        //����
        private const int SOLD_OUT = 0;
        //�ȴ�Ͷ��
        private const int NO_QUARTER = 1;
        //�Ѿ�Ͷ��
        private const int HAS_QUARTER = 2;
        //�۳��ǹ�
        private const int SOLD = 3;

        //��¼�ǹ���״̬
        private int state = SOLD_OUT;
        //��¼�ǹ���Ŀ
        private int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if(count > 0)
            {
                //�ǹ�������Ϊ0ʱ���ǹ�������ȴ�Ͷ��״̬
                state = NO_QUARTER;
            }
        }

        //Ͷ��
        public void insertQuarter()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("���Ѿ�Ͷ��������������Ͷ��");
                    break;
                case NO_QUARTER:
                    state = HAS_QUARTER;
                    Console.WriteLine("��Ͷ��25�֣���ȴ��ǹ�����Ŷ��");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("�޷�Ͷ�ң��ǹ��Ѿ�������������");
                    break;
                case SOLD:
                    Console.WriteLine("�����ĵȴ����ǹ�����������������");
                    break;
            }
        }

        //�˱�
        public void ejectQuarter()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("���ı��Ѿ��˻���Ŷ������ա�");
                    state = NO_QUARTER;
                    break;
                case NO_QUARTER:
                    Console.WriteLine("����û��Ͷ��Ӵ~~");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("�޷�Ͷ�ң��ǹ��Ѿ�������������");
                    break;
                case SOLD:
                    Console.WriteLine("��Ǹ���ǹ��Ѿ����ۣ��޷��˿");
                    break;
            }
        }

        //ת������
        public void turnCrank()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("ת���С�����");
                    state = SOLD;
                    dispense();
                    break;
                case NO_QUARTER:                    
                    Console.WriteLine("����û��Ͷ��Ŷ");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("�޷�Ͷ�ң��ǹ��Ѿ�������������");
                    break;
                case SOLD:
                    Console.WriteLine("���Ѿ�ת�������ˣ���ȴ��ǹ����䡣");
                    break;
            }
        }

        //�����ǹ�
        public void dispense()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("Ŷż��������");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("����û��Ͷ��Ŷ...");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("Ŷż��������");
                    break;
                case SOLD:
                    Console.WriteLine("��ȡ���ǹ�");
                    count = count - 1;
                    if(count == 0)
                    {
                        state = SOLD_OUT;
                    }
                    else
                    {
                        state = NO_QUARTER;
                    }
                    break;
            }
        }

        public void refill(int num)
        {
            this.count = num;
        }

        public string toString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\n��ů���ǹ���");
            strBuilder.Append("���У�" + count + " ���ǹ�");
            strBuilder.Append("\n �ǹ���");
            switch (state)
            {
                case HAS_QUARTER:
                    strBuilder.Append("�ȴ�����ת���С�����");
                    break;
                case NO_QUARTER:
                    strBuilder.Append("�ȴ�Ͷ���С�����");
                    break;
                case SOLD_OUT:
                    strBuilder.Append("�޷�����Ͷ�ң��ǹ��Ѿ�������������");
                    break;
                case SOLD:
                    strBuilder.Append("ת���С�����");
                    break;
            }
            strBuilder.Append("\n");
            return strBuilder.ToString();

        }
    }
}
