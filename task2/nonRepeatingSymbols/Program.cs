using System;

namespace nonRepeatingSymbols
{
    class Program
    {
        static void Main(string[] args)
        {           
            if(args.Length == 0)
            {
                Console.WriteLine("Your string is empty or null");
            }

            else
            {
                Console.WriteLine(SymbolsCounter(args[0].ToLower()));
            }

            Console.ReadKey();
        }

        public static int SymbolsCounter(string myString)
        {
            int counter = 1;
            int resultCounter = 1;
            int cuttedLength = myString.Length - 1;
            for (int i = 0; i < cuttedLength; i++)
            {
                if (myString[i] != myString[i + 1])
                {
                    counter++;
                }          
                
                else
                {
                    if (counter > resultCounter)
                    {
                        resultCounter = counter;
                    }

                    counter = 1;
                }
            }

            return Math.Max(resultCounter, counter);
        }
    }
}
