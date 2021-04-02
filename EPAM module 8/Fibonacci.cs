using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_module_8
{
    public class Fibonacci
    {
        public static IEnumerable<int> Count(int amountOfNumbers)
        {
            var previous = 0;
            var next = 1;

            for (int i = 0; i < amountOfNumbers; i++)
            {
                var summary = previous + next;
                previous = next;
                next = summary;
                yield return summary;
            }
        }
    }
}
