using System;
using System.Collections;
using System.Collections.Generic;

namespace CompisitePattern
{
    public class NullableIterator : IEnumerator
    {
        public object Current
        {
            get
            {
                return null;
            }
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}