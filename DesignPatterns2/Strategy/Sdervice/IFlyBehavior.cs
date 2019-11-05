using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StrategyPattern.Strategy.Service
{
    /// <summary>
    /// 飞行行为接口
    /// </summary>
    public interface IFlyBehavior
    {
        void fly();
    }
}