using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_6_2
{
    public class StringFormater
    {
        public string ToTitle(string originalString, string wordsToIgnore = null)
        {
            if (originalString == null)
            {
                throw new ArgumentNullException("String must not be empty");
            }

            var originalStringArray = originalString.Split(new char[] { ' ' });
            var wordToIgnoreArray = new string[0];

            if (wordsToIgnore!=null)
            {
                wordToIgnoreArray = wordsToIgnore.Split(new char[] { ' ' });
            }

            originalStringArray[0] = ToUpperFirstLetter(originalStringArray[0]);

            for (int i = 1; i < originalStringArray.Length; i++)
            {
                var markedToChange = true;

                    for (int j = 0; j < wordToIgnoreArray.Length; j++)
                    {
                        if (originalStringArray[i].Equals(wordToIgnoreArray[j], StringComparison.InvariantCultureIgnoreCase))
                        {
                            markedToChange = false;
                        }
                    }

                if (markedToChange)
                {
                    originalStringArray[i] = ToUpperFirstLetter(originalStringArray[i]);
                }
                else
                    originalStringArray[i] = ToLowerAll(originalStringArray[i]);
            }

            return string.Join(" ", originalStringArray);
        }

        public string ToUpperFirstLetter(string str)
        {
            char[] charArray = str.ToCharArray();
            charArray[0] = char.ToUpper(charArray[0]);

            for (int i = 1; i < charArray.Length; i++)
            {
                charArray[i] = char.ToLower(charArray[i]);
            }

            return new string(charArray);
        }

        public string ToLowerAll(string str)
        {
            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = char.ToLower(charArray[i]);
            }

            return new string(charArray);
        }
    }
}
