using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class CafeMenuIterator : Iterator
    {
        private Hashtable items;
        private int position = 0;

        public CafeMenuIterator(Hashtable items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if(position >= items.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }


        //此遍历无效
        public object next()
        {
            MenuItem item = (MenuItem)items[position];
            position += 1;
            return item;
        }
    }
}
