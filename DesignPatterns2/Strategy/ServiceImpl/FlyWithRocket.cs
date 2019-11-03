using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Strategy.Service;

namespace DesignPatterns.Strategy.ServiceImpl
{
    class FlyWithRocket : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("FlyWithRocket: I'm flying with a Rocket!");
        }
    }
}
