using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    class CoffeeWithHook : CaffeineBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("adding Milk and Sugar...");
        }

        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        public override bool customerWantsCondiments()
        {
            string answer = getUserInput();
            if (answer.ToLower().Equals("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string getUserInput()
        {
            string answer = null;
            Console.WriteLine("Would you like some milk and sugar with your coffee(y/n)");
            answer = Console.ReadLine();
            if(answer == null)
            {
                return "no";
            }
            return answer;
        }
    }
}
