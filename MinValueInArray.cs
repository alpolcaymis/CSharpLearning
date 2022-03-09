using System;
using System.Linq;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int min = MinV2(5, 8, 2, 6, -44, -0093, 732423, 864, 31121, 8453, 20, 00001);

            Console.WriteLine("The minimum is {0} : " , min);
            
             
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < min)
                    min = number;

            }
            return min;
        }


        
    }
}
