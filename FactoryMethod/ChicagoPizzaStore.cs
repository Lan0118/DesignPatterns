using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory factory = new ChicagoPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.setName("Chicago Style Cheese Pizza");
                    break;
                case "clam":
                    pizza = new ClamPizza(factory);
                    pizza.setName("Chicago Style Clams Pizza");
                    break;
                case "veggies":
                    pizza = new VeggiesPizza(factory);
                    pizza.setName("Chicago Style Veggies Pizza");
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(factory);
                    pizza.setName("Chicago Style Pepperoni Pizza");
                    break;
                default:
                    break;
            }
            return pizza;
        }
    }
}
