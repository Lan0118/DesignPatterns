using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DesignPatterns.Strategy.Service;

namespace DesignPatterns.ServiceImpl
{
    public class QuackSilence : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("QuackSilence: I can't make noise!");
        }
    }
}