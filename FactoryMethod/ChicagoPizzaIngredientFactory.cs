using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /// <summary>
    /// 具体工厂者
    /// 芝加哥原料工厂
    /// </summary>
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return  new Mozzarella();
        }

        public Clams createClam()
        {
            return new FrozenClam();
        }

        public Dough createDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni createPepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] createVeggies()
        {
            Veggies[] veggies = {
                new BlackOlives(),
                new Spinach(),
                new EggPlant()
            };
            return veggies;
        }
    }
}
