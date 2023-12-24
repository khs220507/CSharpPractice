using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    
    class SortObject
    {
        int[] numbers;

        public SortObject(int[] numbers)
        {
            this.numbers=numbers;
        }

        public void Sort()
        {
            int temp;
            for(int i=0; i<numbers.Length; i++)
            {
                int lowPos = i;

                for (int j = i+1; j<numbers.Length; j++)
                {
                    if (numbers[j] < numbers[lowPos])
                    {
                        lowPos = j;
                    }
                }

                    temp = numbers[lowPos];
                    numbers[lowPos] = numbers[i];
                    numbers[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i<numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + ", ");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

                SortObject so = new SortObject(intArray);
                so.Sort();
                so.Display();
            }
        }
    }
}
