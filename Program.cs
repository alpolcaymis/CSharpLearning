using System;
using System.Linq;
using System.Threading;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Enter a value : ");
                string input = Console.ReadLine();

                Console.WriteLine(" Select the Data type to validate the input you have entered\n" +
                                                                        " Press 1 for String \n" +
                                                                        " Press 2 for integer \n" +
                                                                        " Press 3 for Boolean");
                
                bool checkInputTypeValue = int.TryParse(Console.ReadLine(), out int inputType);
                if (!checkInputTypeValue)
                {
                    //if input not integer then ask again
                    Console.WriteLine("ONLY INTEGER TYPE ENTRY ACCEPTED \n PLEASE TRY AGAIN.");
                    continue;
                }
                string validOrNot;

                switch (inputType)
                {
                    case 1:
                        // String code block
                        Console.WriteLine("You have entered a value: " + input);
                        bool containsInt = input.Any(char.IsDigit);

                        if (containsInt)
                            validOrNot = "invalid";
                        else
                            validOrNot = "valid";                        
                        Console.WriteLine("It is an {0}: String", validOrNot);
                        break;
                    case 2:
                        // Integer code block
                        Console.WriteLine("You have entered a value: " + input);
                        bool isIntString = input.All(char.IsDigit);

                        if (isIntString)
                            validOrNot = "valid";
                        else
                            validOrNot = "invalid";

                        Console.WriteLine("It is an {0}: Integer", validOrNot);
                        break;

                    case 3:
                        // Boolean code block
                        Console.WriteLine("You have entered a value: " + input);

                        if (input.ToUpper().Equals("TRUE") || input.ToUpper().Equals("FALSE"))
                            validOrNot = "valid";
                        else
                            validOrNot = "invalid";

                        Console.WriteLine("It is an {0}: Boolean", validOrNot);
                        break;
                    default:
                        // Wrong code block
                        Console.WriteLine("Wrong number entered! PLEASE TRY AGAIN");
                        //while continue to ask again
                        continue;
                        break;
                }
                //while break
                break;
            }


            

        }



    }
}
