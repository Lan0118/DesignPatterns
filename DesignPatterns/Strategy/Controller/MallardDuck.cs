using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignPatterns.Strategy.ServiceImpl;

/// <summary>
/// Duck的派生类
/// </summary>
namespace DesignPatterns.Strategy.Controller
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            //利用IQuackBehavior对象决定MallardDuck的呱呱叫行为
            quackBehavior = new Quack();
            //利用IFlyBehavior对象决定MallardDuck的飞行行为
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("display: I'm a MallardDuck!");
        }
    }
}