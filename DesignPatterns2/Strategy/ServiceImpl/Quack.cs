using StrategyPattern.Strategy.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DesignPatterns.Strategy.ServiceImpl
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack: I can quack");
        }
    }
}