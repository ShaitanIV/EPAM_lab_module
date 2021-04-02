using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EPAM_module_8
{
    public class Queue<T> : IEnumerable<T>
    {
        private List<T> queue = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < queue.Count; i++)
            {
                yield return Dequeue();
            }
        }

        public void Enqueue(T element)
        {
            queue.Add(element);
        }

        public T Dequeue ()
        {
            if (queue.Count == 0)
            {
                throw new NullReferenceException();
            }

            T result = queue[0];
            queue.RemoveAt(0);
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
