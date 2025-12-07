using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberlator
{
    internal class Hex
    {
        public static string DecToHex(string input)
        {
            int.TryParse(input, out int parsed);

            string result = parsed.ToString("X");
            return result;
        }

        public static string HexToDec(string input)
        {
            input = input.ToUpper();
            long result = 0;
            int power = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];
                int value = 0;

                switch (c)
                {
                    case '0': value = 0; break;
                    case '1': value = 1; break;
                    case '2': value = 2; break;
                    case '3': value = 3; break;
                    case '4': value = 4; break;
                    case '5': value = 5; break;
                    case '6': value = 6; break;
                    case '7': value = 7; break;
                    case '8': value = 8; break;
                    case '9': value = 9; break;
                    case 'A': case 'a': value = 10; break;
                    case 'B': case 'b': value = 11; break;
                    case 'C': case 'c': value = 12; break;
                    case 'D': case 'd': value = 13; break;
                    case 'E': case 'e': value = 14; break;
                    case 'F': case 'f': value = 15; break;
                }

                result += value * (int)Math.Pow(16, power);
                power++;
            }

            return result.ToString();
        }


        public static string BinToHex(string input)
        {
            string _int = Binary.BinToDec(input);
            int.TryParse(_int, out int parsed);

            string result = parsed.ToString("X");
            return result;
        }

        public static string HexToBin(string input)
        {
            input = input.ToUpper();
            string result = "";
            int power = 0;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                char c = input[i];
                int value = 0;

                switch (c)
                {
                    case '0': value = 0; break;
                    case '1': value = 1; break;
                    case '2': value = 2; break;
                    case '3': value = 3; break;
                    case '4': value = 4; break;
                    case '5': value = 5; break;
                    case '6': value = 6; break;
                    case '7': value = 7; break;
                    case '8': value = 8; break;
                    case '9': value = 9; break;
                    case 'A': case 'a': value = 10; break;
                    case 'B': case 'b': value = 11; break;
                    case 'C': case 'c': value = 12; break;
                    case 'D': case 'd': value = 13; break;
                    case 'E': case 'e': value = 14; break;
                    case 'F': case 'f': value = 15; break;
                }

                result += Binary.DecToBin(value);
                power++;
            }

            return result;
        }
    }
}
