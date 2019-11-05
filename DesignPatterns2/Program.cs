using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StrategyPattern.Strategy.Service;
using StrategyPattern.Strategy.Controller;
using StrategyPattern.Strategy.ServiceImpl;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.performFly();
            mallardDuck.performQuack();
            mallardDuck.Swim();
            mallardDuck.display();


            Console.WriteLine();

            Duck modelDuck = new ModelDuck();
            modelDuck.display();
            modelDuck.performFly();
            modelDuck.setFlyBehavior(new FlyWithRocket());
            modelDuck.performFly();

            Console.ReadLine();
        }
    }
}
