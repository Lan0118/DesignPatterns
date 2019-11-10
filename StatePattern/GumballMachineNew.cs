using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class GumballMachineNew
    {
        State soldOutState;
        State noQuarterState;
        State hasQuarterState;
        State soldState;
        State winnerState;

        State state ;
        //��¼�ǹ���Ŀ
        private int count = 0;

        public GumballMachineNew(int count)
        {
            
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarteState(this);
            hasQuarterState = new HasQuarteState(this);
            soldState = new SoldState(this);
            winnerState = new WinnerState(this);
            state = soldOutState;
            this.count = count;
            if (count > 0)
            {
                //�ǹ�������Ϊ0ʱ���ǹ�������ȴ�Ͷ��״̬
                state = noQuarterState;
            }
        }

        public void insertQuarter()
        {
            state.insertQuarter();
        }

        public void ejectQuarter()
        {
            state.ejectQuarter();
        }

        public void turnCrank()
        {
            state.turnCrank();
            state.dispense();
        }

        public void setState(State state)
        {
            this.state = state;
        }

        public void releaseBall()
        {
            Console.WriteLine("�ǹ��Ѿ�������");
            if(count != 0)
            {
                count = count - 1;
            }
        }

        public int getCount()
        {
            return count;
        }

        public void refill(int count)
        {
            this.count += count;
            Console.WriteLine("�ǹ����Ѿ�������������" + count + "���ǹ�");
            state.refill();
        }

        public State getState()
        {
            return state;
        }


        public State getSoldOutState()
        {
            return soldOutState;
        }
        public State getSoldState()
        {
            return soldState;
        }

        public State getNoQuarterState()
        {
            return noQuarterState;
        }
        public State getHasQuarterState()
        {
            return hasQuarterState;
        }
        public State getWinnerState()
        {
            return winnerState;
        }

        public string toString()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("\n��ů���ǹ���");
            strBuilder.Append("���У�" + count + " ���ǹ�");
            strBuilder.Append("\n �ǹ���" + state);
            strBuilder.Append("\n");
            return strBuilder.ToString();

        }

    }
}
