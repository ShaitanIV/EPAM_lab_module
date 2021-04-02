using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_6_3
{
    public class UrlEditor
    {
        public string AddOrChangeUrlParameter(string url, string parameterKey, string newParameter)
        {
            var urlAsArray = url.Split(new char[] { '?', '=', '&' });
            var istoChange = false;
            var changingParamPosition = 0;

            for (int i = 1; i < urlAsArray.Length; i+=2)
            {
                if (parameterKey==urlAsArray[i])
                {
                    istoChange = true;
                    changingParamPosition = i + 1;
                }
            }

            if (istoChange)
            {
                urlAsArray[changingParamPosition] = newParameter;
            }

            var result = new StringBuilder();
            result.Append(urlAsArray[0]);
            result.Append("?");

            for (int i = 1; i < urlAsArray.Length; i+=2)
            {
                if (result[result.Length - 1] != '?')
                    result.Append("&");
                result.Append($"{urlAsArray[i]}={urlAsArray[i + 1]}");
            }

            if (!istoChange)
            {
                if (result[result.Length - 1] == '?')
                    result.Append($"{parameterKey}={newParameter}");
                else
                    result.Append($"&{parameterKey}={newParameter}");
            }
                return result.ToString();
        }
    }
}
