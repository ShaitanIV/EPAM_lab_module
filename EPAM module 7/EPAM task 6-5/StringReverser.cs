using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_6_5
{
    public class StringReverser
    {
        public string Reverse(string originalString)
        {
            var reversedString = new StringBuilder();
            var stringAsArray = originalString.Split(' ');

            for (int i = stringAsArray.Length-1; i >= 0; i--)
            {
                reversedString.Append($"{stringAsArray[i]} ");
            }
            reversedString.Length--;

            return reversedString.ToString();
        }
    }
}
