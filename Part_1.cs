using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS205_HW_3
{
    public class Part_1
    {
        public static bool IsAbecedarian(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 == s.Length)
                {
                    return true;
                }
                else if (s[i] <= s[i + 1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
