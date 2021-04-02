using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace EPAM_task_3_3
{
    public static class NullableExtension
    {
        /// <summary>
        /// Method for value types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool isNull<T> (this Nullable<T> target) where T:struct 
        {
            var result = false;
            if (!target.HasValue)
                result = true;
            return result;
        }

        /// <summary>
        /// Method for reference types
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool isNull(this object target) 
        {
            var result = false;
            if (target==null)
                result = true;
            return result;
        }
    }
}
