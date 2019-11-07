using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.EnumToIterator
{
    /// <summary>
    /// 适配器对象
    /// 将Enumeration转成Iterator
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
