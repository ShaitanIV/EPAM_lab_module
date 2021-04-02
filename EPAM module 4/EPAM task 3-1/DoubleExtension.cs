using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_3_1
{
    public static class DoubleExtension
    {
        public static string ToIEEE754(this double number)
        {
            string result = null;
            var expNum = 1023;
            string sign = "";
            char[] exponent = { '0','0','0','0','0','0','0','0','0','0','0' };
            char[] significand = new char[52];
            var tempnumber = number;

            if (double.IsNegative(number))
                sign = "0";
            else sign = "1";

            if (number/1>0)
                while (tempnumber / 10 > 0)
                {
                    expNum++;
                    tempnumber = tempnumber / 10;
                }
            else
                while (tempnumber / 10 < 0)
                {
                    expNum++;
                    tempnumber = tempnumber * 10;
                }

            //exp to binary
            for (int i = 0; tempnumber > 0 ; i++)
            {
                if (tempnumber % 2 == 1)
                    exponent[i] = '1';
                tempnumber = tempnumber / 2;
            }

            string exponentStr = new string(exponent);

            tempnumber = number % 1.0;

            //mant to binary
            for (int i = 0; i < significand.Length; i++)
            {
                tempnumber *= 2.0;
                if (tempnumber / 1 == 0)
                {
                    significand[i] = '1';
                    tempnumber = tempnumber % 1.0;
                }
                else significand[i] = '0';
            }

            string significandStr = new string(significand);

            result = sign + exponentStr + significandStr;
            return result;
        }

    }
}
