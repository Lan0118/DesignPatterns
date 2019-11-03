using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignPatterns.Strategy.Service;

namespace DesignPatterns.Strategy.ServiceImpl
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FlyNoWay: I can't fly");
        }
    }
}