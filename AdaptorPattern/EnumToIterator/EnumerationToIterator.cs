using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.EnumToIterator
{
    /// <summary>
    /// ����������
    /// ��Enumerationת��Iterator
    /// </summary>
    public class EnumerationToIterator : Iterator
    {
        Enumeration enumeration;
        public EnumerationToIterator(Enumeration enumeration)
        {
            this.enumeration = enumeration;
        }

        public bool hasNext()
        {
            return enumeration.hasMoreElements();
        }

        public object next()
        {
            return enumeration.nextElement();
        }

        public bool remove()
        {
            throw new NotImplementedException();
        }
    }
}
