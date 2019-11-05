using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Strategy.Service
{
    /// <summary>
    /// 鸭子类
    /// 鸭子具有飞行行为和呱呱叫行为
    /// 『策略模式』 定义了算法族，分别封装起来，让它们之间可以互相替换 ，此模式让算法的变化独立于使用算法的客户。
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

        //动态修改鸭子的行为
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }
        public void setQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
        
    }
}