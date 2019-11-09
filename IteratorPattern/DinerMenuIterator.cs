using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 餐厅菜单迭代器对象
    /// </summary>
    class DinerMenuIterator : Iterator
    {
        private MenuItem[] items;
        private int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if(position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        public object next()
        {
            MenuItem menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
    }
}
