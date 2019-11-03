using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignPatterns.Strategy.Service;
using DesignPatterns.Strategy.Controller;

namespace DesignPatterns.Strategy.Test
{
    public class MiniDuckSimulator
    {
        public static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.performFly();
            mallardDuck.performQuack();
            mallardDuck.Swim();
            mallardDuck.display();
        }
    }
}