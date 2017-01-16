using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class Polindrom
    {
        public static bool IsPolindrom (this int value)
        {
            int count = 0, temp1;
            value = Math.Abs(value);
            temp1 = value;
            while (temp1 > 0)
            {
                count++;
                temp1 /= 10;
            }
            if (count == 1)
            {
                return true;
            }

            int result = 0, temp2 = value;
            for (int i = 0; i < count; i++)
            {
                result = result * 10 + temp2 % 10;
                temp2 /= 10;
            }
            if (value == result)
                return true;
            else return false;
        }
    }
}
