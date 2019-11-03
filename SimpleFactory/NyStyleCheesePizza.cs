using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// 具体产品类
    /// </summary>
    class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            name = "New York Style Pizza";
            dough = "Thin Crush Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
