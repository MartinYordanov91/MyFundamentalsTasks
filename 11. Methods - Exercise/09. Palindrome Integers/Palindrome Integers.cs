// Create a program that reads positive integers until you receive the "END" command. For each number, print
// whether the number is a palindrome or not. A palindrome is a number that reads the same backward as forward,
// such as 323 or 1001. 

using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while ( input != "END")
            {
                int num = int.Parse(input);

                int[] firstArray = new int[IntToIntArray(num).Length];
                int[] secondArray = new int[IntToIntArray(num).Length];
                bool isPalindrome = false;

                Array.Copy(IntToIntArray(num), firstArray, IntToIntArray(num).Length);
                Array.Copy(IntToIntArray(num), secondArray, IntToIntArray(num).Length);
                Array.Reverse(secondArray);
                isPalindrome = PalindromeTrueFalse(firstArray, secondArray, isPalindrome);

                //Console.WriteLine(string.Join(" ", firstArray));
                //Console.WriteLine(string.Join(" ", secondArray));
                Console.WriteLine(isPalindrome);
                input = Console.ReadLine();
            }
            
        }

        static bool PalindromeTrueFalse(int[] firstArray, int[] secondArray, bool isPalindrome)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    isPalindrome = true;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }

            }

            return isPalindrome;
        }

        static int[] IntToIntArray(int num)
        {
            if (num == 0)
                return new int[1] { 0 };

            List<int> digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            int[] array = digits.ToArray();
            System.Array.Reverse(array);

            return array;
        }
    }
}