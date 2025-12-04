namespace numberlator
{
    internal class main
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

                Console.WriteLine("Valid types: decimal, binary \n");

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
                    default: break;

                    case "decimal":
                        if (outType == "binary")
                        {
                            output = Binary.DecToBin(input);
                        }
                        else if (outType == "decimal")
                        {
                            output = input.ToString();
                        }

                        break;

                    case "binary":
                        Console.WriteLine("Not implemented");

                        break;
                        if (outType == "binary")
                        {
                            output = input.ToString();
                        }
                        else if (outType == "decimal")
                        {
                            output = Binary.BinToDec(input.ToString());
                        }
                }

                Console.WriteLine(output + "\n");
            }
        }
    }
}