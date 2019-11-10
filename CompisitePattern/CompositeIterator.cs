using System;
using System.Collections;
using System.Collections.Generic;

namespace CompisitePattern
{
    public class CompositeIterator : IEnumerator
    {
        private Stack<IEnumerator> stack = new Stack<IEnumerator>();

        public CompositeIterator(IEnumerator enumerator)
        {
            stack.Push(enumerator);
        }

        public object Current
        {
            get
            {
                if (MoveNext())
                {
                    //返回栈顶元素但不删除
                    IEnumerator enumerator = stack.Peek();
                    MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                    stack.Push(menuComponent.createIterator());
                    return menuComponent;
                }
                else
                {
                    return null;
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator enumerator = stack.Peek();
                if (!enumerator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}