using System;
using System.Numerics;
namespace Programmering_2_Första_lektion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test the Collatz conjecture!");
            Console.WriteLine("if you wish to find out more about the Collatz conjectue then press ?");
            string inputValue = Console.ReadLine();
            if (inputValue[0] == '?')
            {
                Console.WriteLine("The Collatz conjectue claims that any number no matter how big will if an even number is divided by 2 and the odd numbers " +
                    "are multiplied by 3 and gets a 1 added to it the number will eventually reach the value of 1, were it wil then be stuck in a loop.");
            }
            else 
            { 
                if (BigInteger.TryParse(inputValue, out BigInteger BResult) && BResult > 0)
                {
                    Collatz c = new Collatz();
                    c.Calculate(BResult);
                    Console.WriteLine("You've reached the infinite loop");
                }

                else
                {
                    Console.WriteLine("Input not valid as an integer value bigger than zero. Try again");
                }
            }
            Console.ReadKey();
        }   
    }
}
