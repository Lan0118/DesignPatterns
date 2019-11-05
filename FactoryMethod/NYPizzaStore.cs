using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory factory = new NyPizzaIngredientFactory();

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.setName("New York Style Cheese Pizza");
                    break;
                case "clam":
                    pizza = new ClamPizza(factory);
                    pizza.setName("New York Style Clams Pizza");
                    break;
                case "veggies":
                    pizza = new VeggiesPizza(factory);
                    pizza.setName("New York Style Veggies Pizza");
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(factory);
                    pizza.setName("New York Style Pepperoni Pizza");
                    break;
                default:
                    break;
            }
            

            return pizza;
        }
    }
}
