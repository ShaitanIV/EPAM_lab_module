using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace EPAM_module_8
{
    class Set<T> : IEnumerable<T>
    {
        private List<T> set = new List<T>();

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < set.Count; i++)
            {
                yield return set[i];
            }
        }

        public void Add(T element)
        {
            if (!set.Contains(element))
            {
                set.Add(element);
            }
        }

        public void Remove(T element)
        {
            if (set.Contains(element))
                set.Remove(element);
            else
                Console.WriteLine("Element does not exist in this set");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
