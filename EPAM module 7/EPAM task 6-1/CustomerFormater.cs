using System;
using System.Collections.Generic;
using System.Text;

namespace EPAM_task_6_1
{
    public static class CustomerExtension
    {
        public static string CustomerToString(this Customer customer, bool includeName = true, bool includePhone = true, bool includeRevenue = true)
        {
            if (customer == null)
                return null;

            if (!includeName && !includePhone && !includeRevenue)
                return null;

            StringBuilder result = new StringBuilder();

            result.Append("Customer record:");

            if (includeName && customer.Name != null)
                result.Append(customer.Name);

            if (includePhone && customer.ContactPhone != null)
            {
                if (includeName && customer.Name != null)
                    result.Append(",");
                result.Append(customer.ContactPhone);
            }

            if (includeRevenue)
            {
                if ((includePhone && customer.ContactPhone != null)||(includeName && customer.Name != null))
                    result.Append(",");
                result.Append(customer.Revenue);
            }

            return result.ToString();
        }
    }
}
