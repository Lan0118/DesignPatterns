using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Strategy.Service;
using DesignPatterns.Strategy.Controller;
using DesignPatterns.Strategy.ServiceImpl;

namespace DesignPatterns
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
