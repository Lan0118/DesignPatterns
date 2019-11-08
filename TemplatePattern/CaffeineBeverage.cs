using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    /// <summary>
    /// 提取咖啡和茶的制作方法中相同的方法作为模板方法
    /// </summary>
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            //煮水
            boilWater();
            //冲泡
            brew();
            //倒进杯子
            pourInCup();
            //使用钩子
            if (customerWantsCondiments())
            {
                //加入调料
                addCondiments();
            }
           
        }

        public abstract void brew();
        public abstract void addCondiments();
        public void boilWater()
        {
            Console.WriteLine("boiling water...");
        }

        public void pourInCup()
        {
            Console.WriteLine("pouring in cup...");
        }

        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}
