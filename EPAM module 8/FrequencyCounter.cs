using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace EPAM_module_8
{
    public static class FrequencyCounter
    {

        public static Dictionary<string, int> CountFromFile(string FilePath)
        {
            var TextFromFile = "";

            if (FilePath == null)
            {
                throw new NullReferenceException();
            }
            if (!System.IO.File.Exists(FilePath))
            {
                throw new ArgumentException("File does not exists");
            }

            TextFromFile = System.IO.File.ReadAllText(FilePath);

            return Count(TextFromFile);

        }
        public static Dictionary<string,int> Count(string TextFromFile)
        {
            Dictionary <string,int> result = new Dictionary<string, int>();

            string[] textAsList = TextFromFile.Split(' ');

            foreach (var word in textAsList)
            {
                var tempword = word.ToLower();
                if (result.ContainsKey(tempword))
                {
                    result[tempword]++;
                }
                else
                    result.Add(tempword, 1);
            }

            return result;
        }

    }
}
