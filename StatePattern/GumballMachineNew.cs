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
        //记录糖果数目
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
                //糖果数量不为0时，糖果机进入等待投币状态
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
            Console.WriteLine("糖果已经掉落啦");
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
            Console.WriteLine("糖果机已经填满啦，共有" + count + "颗糖果");
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
            strBuilder.Append("\n温暖牌糖果机");
            strBuilder.Append("共有：" + count + " 颗糖果");
            strBuilder.Append("\n 糖果机" + state);
            strBuilder.Append("\n");
            return strBuilder.ToString();

        }

    }
}
