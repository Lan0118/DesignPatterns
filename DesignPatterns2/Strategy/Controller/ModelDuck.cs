
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Strategy.Service;
using DesignPatterns.Strategy.ServiceImpl;

namespace DesignPatterns.Strategy.Controller
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("ModelDuck: I'm a model duck");
        }
    }
}
