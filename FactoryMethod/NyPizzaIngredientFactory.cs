using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    /// <summary>
    /// 具体工厂类
    /// 纽约原料工厂
    /// </summary>
    class NyPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new ReggianoCheese();
        }

        public Clams createClam()
        {
            return new FreshClam();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new MarinaraSause();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
            return veggies;
        }
    }
}
