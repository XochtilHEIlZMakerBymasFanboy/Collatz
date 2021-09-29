using System;
using System.Numerics;
namespace Programmering_2_Första_lektion
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Test the Collatz conjecture! Please be sure to input a number smaller than 114 digits");
            Console.WriteLine("To learn about the collatz conjecture enter '?' and enter 'e' if you wish to exit the program");
            do
            {
                string inputValue = Console.ReadLine();


                if (String.IsNullOrEmpty(inputValue))
                {
                    Console.WriteLine("I'm sorry, but we can't process this number. Try again.");
                }
                else
                { 

                    if (inputValue[0] == '?')
                    {
                        Console.WriteLine("The Collatz conjectue claims that any number no matter how big will end up at 1 if the even numbers are divided by 2 and the odd numbers " +
                            "are multiplied by 3 and gets a 1 added to it. After it reaches 1 it wil then be stuck in a loop between 1, 2 and 4.");
                        Console.WriteLine();
                        Console.WriteLine("To continue enter any number");
                    }
                    else if (inputValue[0] == 'e')
                    {
                        return;
                    }
                    else
                    {
                        if (BigInteger.TryParse(inputValue, out BigInteger BResult) && BResult > 0)
                        {

                          
                            BigInteger? result = BResult;
                            do
                            {
                                result = Collatz.Calculate((BigInteger)result);
                            } while (result != null);


                            Console.WriteLine("You've reached the infinite loop");
                        }

                        else
                        {
                            Console.WriteLine("Input not valid as an integer value bigger than zero. Try again");
                        }
                    }

                }
                
            } while ( true);  
        }
    }
}
