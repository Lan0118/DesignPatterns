using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StrategyPattern.Strategy.Service;

namespace StrategyPattern.Strategy.ServiceImpl
{
    /// <summary>
    /// 实现IFlyBehavior接口
    /// 飞行行为的一种：FlyWithWings
    /// </summary>
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FlyWithWings: I'm flying");
        }
    }

}