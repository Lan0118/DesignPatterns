using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = null;
            int count = 2;
            if(args.Length > 2)
            {
                Console.WriteLine("GumballMachine <name> <inventory>");
                Environment.Exit(0);
            }
            
            count = Convert.ToInt16(args[1]);
            gumballMachine = new GumballMachine(args[0], count);
            GumballMonitor mobitor = new GumballMonitor(gumballMachine);

            mobitor.report();

            
        }
    }
}
