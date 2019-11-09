using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 加入CafeMenu，采用HashTable存储菜单项
    /// 实现Menu
    /// </summary>
    class CafeMenu : Menu
    {
        private Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            addItem("Veggie Burger and Air Fries",
            "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
            true, 3.99);
            addItem("Soup of the day",
                "A cup of the soup of the day, with a side salad",
                false, 3.69);
            addItem("Burrito",
                "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29);
        }

        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.getName(),menuItem);
        }

        public Hashtable getMenuItems()
        {
            return menuItems;
        }

        public Iterator createIterator()
        {
            return new CafeMenuIterator(menuItems);
        }

    }
}
