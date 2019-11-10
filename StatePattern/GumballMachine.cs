using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 糖果机
    /// </summary>
    public class GumballMachine
    {
        //糖果机的4个状态
        //售完
        private const int SOLD_OUT = 0;
        //等待投币
        private const int NO_QUARTER = 1;
        //已经投币
        private const int HAS_QUARTER = 2;
        //售出糖果
        private const int SOLD = 3;

        //记录糖果机状态
        private int state = SOLD_OUT;
        //记录糖果数目
        private int count = 0;

        public GumballMachine(int count)
        {
            this.count = count;
            if(count > 0)
            {
                //糖果数量不为0时，糖果机进入等待投币状态
                state = NO_QUARTER;
            }
        }

        //投币
        public void insertQuarter()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("您已经投过币啦，请勿多次投币");
                    break;
                case NO_QUARTER:
                    state = HAS_QUARTER;
                    Console.WriteLine("您投入25分，请等待糖果掉落哦！");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("无法投币，糖果已经售完啦。。。");
                    break;
                case SOLD:
                    Console.WriteLine("请耐心等待，糖果正在向您奔来！！");
                    break;
            }
        }

        //退币
        public void ejectQuarter()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("您的币已经退回了哦，请查收。");
                    state = NO_QUARTER;
                    break;
                case NO_QUARTER:
                    Console.WriteLine("您还没有投币哟~~");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("无法投币，糖果已经售完啦。。。");
                    break;
                case SOLD:
                    Console.WriteLine("抱歉，糖果已经出售，无法退款。");
                    break;
            }
        }

        //转动曲柄
        public void turnCrank()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("转动中。。。");
                    state = SOLD;
                    dispense();
                    break;
                case NO_QUARTER:                    
                    Console.WriteLine("您还没有投币哦");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("无法投币，糖果已经售完啦。。。");
                    break;
                case SOLD:
                    Console.WriteLine("您已经转过曲柄了，请等待糖果掉落。");
                    break;
            }
        }

        //发放糖果
        public void dispense()
        {
            switch (state)
            {
                case HAS_QUARTER:
                    Console.WriteLine("哦偶，崩溃了");
                    break;
                case NO_QUARTER:
                    Console.WriteLine("您还没有投币哦...");
                    break;
                case SOLD_OUT:
                    Console.WriteLine("哦偶，崩溃了");
                    break;
                case SOLD:
                    Console.WriteLine("请取出糖果");
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
            strBuilder.Append("\n温暖牌糖果机");
            strBuilder.Append("共有：" + count + " 颗糖果");
            strBuilder.Append("\n 糖果机");
            switch (state)
            {
                case HAS_QUARTER:
                    strBuilder.Append("等待曲柄转动中。。。");
                    break;
                case NO_QUARTER:
                    strBuilder.Append("等待投币中。。。");
                    break;
                case SOLD_OUT:
                    strBuilder.Append("无法进行投币，糖果已经售完啦。。。");
                    break;
                case SOLD:
                    strBuilder.Append("转动中。。。");
                    break;
            }
            strBuilder.Append("\n");
            return strBuilder.ToString();

        }
    }
}
