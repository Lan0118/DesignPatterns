using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    public class DuckAdapter : Turkey
    {
        Duck duck;
        public DuckAdapter(Duck duck)
        {
            this.duck = duck;
        }

        public void fly()
        {
            duck.fly();
        }

        public void gobble()
        {
            duck.quack();
        }
    }
}
