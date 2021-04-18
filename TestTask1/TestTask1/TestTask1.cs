using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask1
{
    class TestTask1
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int minIndex = 0;
            int maxIndex = 0;
            int temp = 0;
            double sum = 0;
            double mean;
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = (int)Math.Pow(2, i);
                Console.Write(myArray[i] + " ");

                if (myArray[minIndex] > myArray[i])
                {
                    minIndex = i;
                }

                if (myArray[maxIndex] < myArray[i])
                {
                    maxIndex = i;
                }

                sum += myArray[i];
            }

            Console.WriteLine();

            temp = myArray[minIndex];
            myArray[minIndex] = myArray[maxIndex];
            myArray[maxIndex] = temp;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i] + " ");
            }

            Console.WriteLine();

            mean = sum / myArray.Length;
            Console.Write(mean);

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}