using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern.EnumToIterator
{
    /// <summary>
    /// µü´úÆ÷½Ó¿Ú
    /// </summary>
    public interface Iterator
    {
        bool hasNext();
        object next();
        bool remove();
    }
}
