using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    /// <summary>
    /// 咖啡冲泡方法
    /// </summary>
    class Coffee
    {
        public void prepareRecipe()
        {
            boilWater();
            brewCoffeeGrinds();
            pourInCup();
            addSugarandMilk();
        }

        public void addSugarandMilk()
        {
            Console.WriteLine("adding Sugar and Milk");
        }

        private void pourInCup()
        {
            Console.WriteLine("pouring In Cup");
        }

        public void brewCoffeeGrinds()
        {
            Console.WriteLine("Brewing CoffeeGrinds...");
        }

        public void boilWater()
        {
            Console.WriteLine("Boilling Water...");
        }


    }
}
