using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy.Service
{
    /// <summary>
    /// 呱呱叫行为
    /// </summary>
    public interface IQuackBehavior
    {
        void quack();
    }
}
