namespace numberlator
{
    internal class Program
    {
        // types: decimal, binary

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                string inType = "none";
                string outType = "none";

                int input = 0;
                string output = "";

                Console.WriteLine("Valid types (can use first letter only): decimal, binary \n");

                Console.Write("Enter the input type: ");
                inType = Console.ReadLine() ?? "none";

                Console.Write("Enter the output type: ");
                outType = Console.ReadLine() ?? "none";

                Console.WriteLine();

                Console.Write("Enter the input number: ");
                float.TryParse(Console.ReadLine(), out float f);
                input = (int)Math.Floor(f);

                Console.WriteLine();

                switch (inType)
                {
                    default:
                        output = "Error: no valid option provided";
                        break;

                    case "decimal": // fallthrough, to not cnp all the code from the case
                    case "d":
                        if (outType == "b")
                        {
                            output = Binary.DecToBin(input);
                        }
                        else if (outType == "d")
                        {
                            output = input.ToString();
                        }

                        break;

                    case "binary": // same here
                    case "b":
                        if (outType == "b")
                        {
                            output = input.ToString();
                        }
                        else if (outType == "d")
                        {
                            output = Binary.BinToDec(input.ToString());
                        }

                        break;
                }

                Console.WriteLine(output + "\n");
            }
        }
    }
}