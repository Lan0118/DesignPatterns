using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    /// <summary>
    /// �����Ʒ��
    /// </summary>
    class ChicagoCheesePizza : Pizza
    {
        public ChicagoCheesePizza()
        {
            name = "Chicago Cheese Pizza";
            dough = "Extra Thick Crush Dough";
            sauce = "Plum tamato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
