using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompisitePattern
{
    /// <summary>
    /// ���������
    /// </summary>
    public interface MenuComponent
    {
        /// <summary>
        /// ����Ӳ˵���
        /// </summary>
        /// <param name="menuComponent"></param>
        void add(MenuComponent menuComponent);    

        /// <summary>
        /// �Ƴ��Ӳ˵���
        /// </summary>
        /// <param name="menuComponent"></param>
        void remove(MenuComponent menuComponent);

        /// <summary>
        /// ��ȡ�����ӽڵ�
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        MenuComponent getChild(int i);      

        /// <summary>
        /// ��ȡҶ�ӽڵ�����
        /// </summary>
        /// <returns></returns>
        string getName();

        /// <summary>
        /// ��ȡҶ�ӽڵ�����
        /// </summary>
        /// <returns></returns>
        string getDescription();

        /// <summary>
        /// ��ȡҶ�ӽڵ�۸�
        /// </summary>
        /// <returns></returns>
        double getPrice();

        /// <summary>
        /// ��ȡҶ�ӽڵ��Ƿ�Ϊ��ʳ
        /// </summary>
        /// <returns></returns>
        bool isVegetarian();

        /// <summary>
        /// ��ӡ��Ϣ
        /// </summary>
        void print();

        /// <summary>
        /// ��ȡ������
        /// </summary>
        IEnumerator createIterator();
    }
}
