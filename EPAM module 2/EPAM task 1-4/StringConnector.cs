using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EPAM_task_1_4
{
    public class StringConnector
    {
        //<summary>
        //Method for finding string, which contains unique symbols from both strings
        //</summary>
        public string Unite(string FirstString, string SecondString)
        {
            string result= FirstString+SecondString;

            for (int i = result.Length - 1; i >= 0; i--)
            {
                var isDuplicate = false;
                for (int j = result.Length-1; j >= 0; j--)
                {
                    if (result[j] == result[i]&&i!=j)    
                    isDuplicate = true;
                }
                if(isDuplicate)
                {
                    result = result.Remove(i, 1);
                }
            }
            return result;
        }
    }
}
