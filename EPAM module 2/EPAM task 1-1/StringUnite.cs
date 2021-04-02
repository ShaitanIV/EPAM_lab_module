using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_1_1
{
    public class StringUnite
    {
        const int maxArrayLenght = 32;

        //<summary>
        //Method for uniting numbers, inserting n bits of the second number into j-i bites of the first number
        //Where n = j-i bites, j - end position, i - start position
        //</summary>
        public int Unite(int numbersource, int numberin, int startposition, int endposition)
        {
            var converterByte = new ConverterToByte();
            var converterInt = new ConverterToInt();

            if(startposition>endposition)
            {
                var temp = startposition;
                startposition = endposition;
                endposition = temp;
            }

            if(numbersource<0||numberin<0)
            {
                throw new System.ArgumentException("Both numbers must be greater then 0");
            }

            var numberSource = converterByte.ToByteArray(numbersource);
            var numberIn = converterByte.ToByteArray(numberin);

            int[] result = new int[maxArrayLenght];

            for(int i=0;i<maxArrayLenght;i++)
            {
                result[i] = numberSource[i];
            }

            for (int i = startposition; i <= endposition; i++)
            {
                result[i] = numberIn[i - startposition];
            }

            return converterInt.ToInt(result);
        }
    }
}
