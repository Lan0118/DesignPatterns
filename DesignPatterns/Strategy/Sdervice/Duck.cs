using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DesignPatterns.Strategy.Service;

namespace DesignPatterns.Strategy.Controller
{
    /// <summary>
    /// 鸭子类
    /// 鸭子具有飞行行为和呱呱叫行为
    /// </summary>
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;

        //公共行为
        public void Swim()
        {
            Console.Write("Swim");
        }
        public abstract void display();

        //不同鸭子有不同的飞行行为,由flyBehavior对象决定具体某类鸭子的飞行行为
        public void performFly()
        {
            flyBehavior.fly();
        }
        //不同鸭子有不同的呱呱叫行为,由quackBehavior对象决定具体某类鸭子的呱呱叫行为
        public void performQuack()
        {
            quackBehavior.quack();
        }
        
    }
}