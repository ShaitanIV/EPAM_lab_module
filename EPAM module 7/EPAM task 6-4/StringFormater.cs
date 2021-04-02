using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_6_4
{  
    public class StringFormater
    {
        public List<T> UniqueInOrder<T> (IEnumerable<T> consistencyToModify) 
        {
            var result = new List<T>();
            if (consistencyToModify.GetEnumerator().MoveNext() == false)
                throw new ArgumentNullException("Sequence must be longer than 1 element");

            using (var enumerator = consistencyToModify.GetEnumerator())
            {
                enumerator.MoveNext();
                result.Add(enumerator.Current);
                var previous = enumerator.Current;

                while (enumerator.MoveNext())
                {
                    var current = enumerator.Current;

                    if ((dynamic)current != (dynamic)previous)
                    {
                        result.Add(current);
                    }

                    previous = current;
                }
            }
            return result;
        }


    }
    
}
