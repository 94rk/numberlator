using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberlator
{
    internal class Binary
    {
        public static string DecToBin(int input)
        {
            string result = "";
            List<int> cache = new();

            while (input != 0)
            {
                bool even = input % 2 == 0;
                cache.Add(even ? 0 : 1);

                input /= 2;
            }

            cache.Reverse();

            foreach (int num in cache)
                result += num.ToString();

            int targetLength = (int)Math.Pow(2, Math.Ceiling(Math.Log2(Math.Max(result.Length, 4))));
            int missingLength = targetLength - result.Length;

            for (int i = 0; i < missingLength; i++)
                result = "0" + result;

            return result;
        }

        public static string BinToDec(string input)
        {
            string result = "";
            int nearestPow2 = (int)Math.Pow(2, Math.Ceiling(Math.Log2(Math.Max(input, 4))));

            return nearestPow2.ToString();
        }
    }
}
