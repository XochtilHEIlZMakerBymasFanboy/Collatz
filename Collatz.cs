using System;
using System.Numerics;

namespace Programmering_2_Första_lektion
{
    public static class Collatz
    {
        static bool foundTwo = false;
        static bool foundFour = false;

        public static BigInteger? Calculate(BigInteger value)
        {
            BigInteger calculatedValue;
            if (IsEven(value))
            {
                calculatedValue = value / 2;
            }
            else
            {
                calculatedValue = value * 3 + 1;
            }
            PrintNum(calculatedValue);
            if (CheckInfinityLoop(calculatedValue))
            {
                return null;
            }
            return calculatedValue;
        }

        private static bool IsEven(BigInteger inputValue)
        {
            if (inputValue % 2 == 0)
            {
                return true;
            }
            return false;
        }

        private static void PrintNum(BigInteger inputValue)
        {
            Console.WriteLine(inputValue);
        }

        private static bool CheckInfinityLoop(BigInteger inputValue)
        {

            if (!foundFour && inputValue == 4)
            {
                foundFour = true;
                return false;
            }
            else if (foundFour && !foundTwo && inputValue == 2)
            {
                foundTwo = true;
                return false;
            }
            else if (foundFour && foundTwo && inputValue == 1)
            {
                return true;
            }
            return false;
        }
    }
    public class Stats
    {
    public void length(var Value)
        {
            if (Console.ReadLine()) 
            { 
            
            }
        }

    }
}   
