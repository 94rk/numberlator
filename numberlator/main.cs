namespace numberlator
{
    internal class Program
    {
        // types: decimal, binary, hex

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                string inType = "none";
                string outType = "none";

                string input = "";
                string output = "";

                Console.WriteLine("Valid types: decimal (d), binary (b), hexadecimal (hex, h) \n");

                Console.Write("Enter the input type: ");
                inType = Console.ReadLine() ?? "none";

                Console.Write("Enter the output type: ");
                outType = Console.ReadLine() ?? "none";

                Console.WriteLine();

                Console.Write("Enter the input number: ");
                input = Console.ReadLine() ?? "";
                input = input.ToLower();

                Console.WriteLine();

                switch (inType)
                {
                    default:
                        output = "Error: no valid option provided";
                        break;

                    case "decimal": // fallthrough, to not cnp all the code from the case
                    case "d":
                        if (outType == "b" || outType == "binary")
                        {
                            output = Binary.DecToBin(Convert.ToInt32(input));
                        }
                        else if (outType == "d" || outType == "decimal")
                        {
                            output = input.ToString();
                        }
                        else if (outType == "h" || outType == "hex" || outType == "hexadecimal")
                        {
                            output = Hex.DecToHex(input.ToString());
                        }

                        break;

                    case "binary":
                    case "b":
                        if (outType == "b" || outType == "binary")
                        {
                            output = input;
                        }
                        else if (outType == "d" || outType == "decimal")
                        {
                            output = Binary.BinToDec(input);
                        }
                        else if (outType == "h" || outType == "hex" || outType == "hexadecimal")
                        {
                            output = Hex.BinToHex(input);
                        }

                        break;

                    case "hexadecimal":
                    case "hex":
                    case "h":
                        if (outType == "b" || outType == "binary")
                        {
                            output = Hex.HexToBin(input);
                        }
                        else if (outType == "d" || outType == "decimal")
                        {
                            output = Hex.HexToDec(input);
                        }
                        else if (outType == "h" || outType == "hex" || outType == "hexadecimal")
                        {
                            output = input;
                        }

                        break;
                }

                Console.WriteLine(output + "\n");
            }
        }
    }
}