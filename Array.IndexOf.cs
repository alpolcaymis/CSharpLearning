using System;
using System.Linq;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {

        static void Main(string[] args)
        {


            string[] alp = new string[] { "Sevinç", "nigar" , "cosku", "seza"};
            string[] habip = new string[] { "Habanne", "Hababa" };
            string[] hakan = new string[] { "Hakanne", " Hakbaba" };

            string[][] familyList = new string[][]
            {
                alp,
                habip,
                hakan
                
            };

            for (int i = 0; i < alp.Length; i++)
            {
                Console.WriteLine(familyList[Array.IndexOf(familyList, alp)][i]);

            }
            

            
        }
    }
}
