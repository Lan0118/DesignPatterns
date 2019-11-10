using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompisitePattern
{
    /// <summary>
    /// 抽象组合类
    /// </summary>
    public interface MenuComponent
    {
        /// <summary>
        /// 添加子菜单项
        /// </summary>
        /// <param name="menuComponent"></param>
        void add(MenuComponent menuComponent);    

        /// <summary>
        /// 移除子菜单项
        /// </summary>
        /// <param name="menuComponent"></param>
        void remove(MenuComponent menuComponent);

        /// <summary>
        /// 获取单个子节点
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        MenuComponent getChild(int i);      

        /// <summary>
        /// 获取叶子节点名称
        /// </summary>
        /// <returns></returns>
        string getName();

        /// <summary>
        /// 获取叶子节点描述
        /// </summary>
        /// <returns></returns>
        string getDescription();

        /// <summary>
        /// 获取叶子节点价格
        /// </summary>
        /// <returns></returns>
        double getPrice();

        /// <summary>
        /// 获取叶子节点是否为素食
        /// </summary>
        /// <returns></returns>
        bool isVegetarian();

        /// <summary>
        /// 打印信息
        /// </summary>
        void print();

        /// <summary>
        /// 获取迭代器
        /// </summary>
        IEnumerator createIterator();
    }
}
