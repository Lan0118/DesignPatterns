using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StrategyPattern.Strategy.Service;

namespace StrategyPattern.Strategy.ServiceImpl
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FlyNoWay: I can't fly");
        }
    }
}