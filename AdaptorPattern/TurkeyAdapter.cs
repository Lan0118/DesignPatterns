using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptorPattern
{
    /// <summary>
    /// ��������
    /// ��װ�𼦶����ΪһֻѼ��
    /// ʵ����Ҫת�������͵Ľӿ�
    /// </summary>
    public class TurkeyAdapter : Duck
    {
        //ԭ����
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        //Ѽ�ӱȻ𼦷ɵ�Զ
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
