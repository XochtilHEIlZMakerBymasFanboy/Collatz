using System;
using System.Numerics;

namespace Programmering_2_Första_lektion
{
    public class Collatz
    {
        bool foundTwo = false;
        bool foundFour = false;

        public void Calculate(BigInteger value)
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
                return;

            }
            Calculate(calculatedValue);
        }

        private bool IsEven(BigInteger inputValue)
        {
            if (inputValue % 2 == 0)
            {
                return true;
            }
            return false;
        }

        private void PrintNum(BigInteger inputValue)
        {
            Console.WriteLine(inputValue);
        }

        private bool CheckInfinityLoop(BigInteger inputValue) 
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
} 
