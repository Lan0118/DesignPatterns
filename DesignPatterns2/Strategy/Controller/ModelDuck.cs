
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StrategyPattern.Strategy.Service;
using StrategyPattern.Strategy.ServiceImpl;

namespace StrategyPattern.Strategy.Controller
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new DesignPatterns.Strategy.ServiceImpl.Quack();
        }

        public override void display()
        {
            Console.WriteLine("ModelDuck: I'm a model duck");
        }
    }
}
