using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_1_1
{
    public class ConverterToByte
    {
        const int maxArrayLenght=32;

        public int[] ToByteArray(int Number)
        {
            var numberofbits = 1;
            var cloneofnumber = Number;

            while(cloneofnumber/2>0)
            {
                cloneofnumber = cloneofnumber / 2;
                numberofbits++;
            }

            cloneofnumber = Number;
            int[] array = new int[32];

            for (int i = 0; i < 32; i++)
            {
                array[i] = 0;
            }

            for (int i = 0; i < numberofbits; i++)
            {
                if (cloneofnumber % 2 == 1)
                    array[i] = 1;
                cloneofnumber = cloneofnumber / 2;
            }

            return array;
        }
    }
}
