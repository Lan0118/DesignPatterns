using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.EnumToIterator
{
    /// <summary>
    /// ö�ٽӿ�
    /// </summary>
    public interface Enumeration
    {
        bool hasMoreElements();
        object nextElement();
    }
}
