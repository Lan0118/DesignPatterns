using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----old Coffe and tea------");
            Coffee coffeeOld = new Coffee();
            Tea teaOld = new Tea();
            coffeeOld.prepareRecipe();
            Console.WriteLine();
            teaOld.prepareRecipe();

            Console.WriteLine("\n-------new Coffee and Tea---------");
            CoffeeNew coffeeNew = new CoffeeNew();
            TeaNew teaNew = new TeaNew();
            coffeeNew.prepareRecipe();
            Console.WriteLine();
            teaNew.prepareRecipe();

            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();
            Console.WriteLine("-------Making Coffee--------");
            coffeeWithHook.prepareRecipe();

            Console.ReadKey();

        }
    }
}
