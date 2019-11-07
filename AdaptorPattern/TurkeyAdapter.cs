using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    /// <summary>
    /// 火鸡适配器
    /// 包装火鸡对象成为一只鸭子
    /// 实现想要转换的类型的接口
    /// </summary>
    public class TurkeyAdapter : Duck
    {
        //原对象
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        //鸭子比火鸡飞的远
        public void fly()
        {
            for(int i=0; i<5; i++)
            {
                turkey.fly();
            }
        }

        public void quack()
        {
            turkey.gobble();
        }
    }
}
