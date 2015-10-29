using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RearrangeArray
{
    public class Rearrange
    {
        public static string ReArray(string s)
        {
            var len = s.Length;
            var map = new Dictionary<char, int>();
            var lastSymbol = s[0];
            map.Add(s[0], 0);
            string result = s[0] + "";

            for (var i = 1; i < len; i++)
            {
                if (s[i] != lastSymbol)
                {
                    result += s[i];

                    if (map[lastSymbol] != 0)
                    {
                        result += lastSymbol;
                        map[lastSymbol]--;
                    }
                    else
                    {
                        lastSymbol = s[i];
                        map.Add(lastSymbol, 0);
                    }
                }
                else
                {
                    map[lastSymbol]++;
                }
            }

            if (result.Length != len)
            {
                return "No valid output";
            }

            return result;
        }
    }
}
