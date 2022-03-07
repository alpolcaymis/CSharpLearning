using System;
using System.Linq;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5, 6},
                new int[] { 7, 8, 9},
            };


            foreach (int[] jagged in jaggedArray)
            {
                foreach (int i in jagged)
                    Console.WriteLine(i);
            }


        }
    }
}
