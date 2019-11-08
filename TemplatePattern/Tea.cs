using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    /// <summary>
    /// 茶的冲泡方法
    /// </summary>
    class Tea
    {
        public void prepareRecipe()
        {
            boilWater();
            steepTeaBag();
            pourInCup();
            addLemon();
        }

        private void addLemon()
        {
            Console.WriteLine("adding Lemon...");
        }

        private void pourInCup()
        {
            Console.WriteLine("pouring in cup...");
        }

        private void steepTeaBag()
        {
            Console.WriteLine("steeping teabag...");
        }

        private void boilWater()
        {
            Console.WriteLine("boiling water...");
        }
    }
}
