using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.EnumToIterator
{
    /// <summary>
    /// Ã¶¾Ù½Ó¿Ú
    /// </summary>
    public interface Enumeration
    {
        bool hasMoreElements();
        object nextElement();
    }
}
