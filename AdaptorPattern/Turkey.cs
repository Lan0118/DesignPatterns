using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    /// <summary>
    /// 火鸡抽象对象
    /// </summary>
    public interface Turkey
    {
        /// <summary>
        /// 火鸡的叫声
        /// </summary>
        void gobble();

        void fly();
    }
}
