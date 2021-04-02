using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EPAM_module_8
{
    class Stack<T> : IEnumerable<T>
    {
        private List<T> stack = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i > 0; i--)
            {
                yield return Dequeue();
            }
        }

        public void Enqueue(T element)
        {
            stack.Add(element);
        }

        public T Dequeue()
        {
            if (stack.Count == 0)
            {
                throw new NullReferenceException();
            }

            T result = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count-1);
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
