using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// ¼å±ý²Ëµ¥µü´úÆ÷
    /// </summary>
    public class PancakeHouseIterator: Iterator
    {
        private ArrayList items;
        private int position = 0;
        public PancakeHouseIterator(ArrayList items)
        {
            this.items = items;
        }

        public object next()
        {
            MenuItem item = (MenuItem)items[position];
            position += 1;
            return item;
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
    }
}
