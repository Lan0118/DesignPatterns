using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    /// <summary>
    /// 适配器模式
    /// 将一只火鸡包装成一只鸭子
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //火鸡转鸭子测试代码
            MallardDuck duck = new MallardDuck();
            WildTurket wildTurkey = new WildTurket();
            Duck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            Console.WriteLine("---------The Turkey says----------");
            wildTurkey.gobble();
            wildTurkey.fly();
            Console.WriteLine("---------The Duck says----------");
            duck.quack();
            duck.fly();
            Console.WriteLine("---------The TurkeyAdapter says----------");
            turkeyAdapter.quack();
            turkeyAdapter.fly();



            Console.ReadKey();
        }
    }
}
