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
            string reversed = new string(input.Reverse().ToArray());
            int result = 0;

            for (int i = 0; i < reversed.Length; i++)
            {
                char bit = reversed[i];

                if (bit == '1')
                    result += (int)Math.Pow(2, i);
                else if (bit != '0')
                    throw new ArgumentException("Invalid character in binary string");
            }

            return result.ToString();
        }
    }
}
