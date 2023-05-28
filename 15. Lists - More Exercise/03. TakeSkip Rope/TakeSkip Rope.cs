// Write a program, which reads a string and skips through it, extracting a hidden message. The algorithm you have to
// implement is as follows:
// Let's take the string "skipTest_String044170" as an example.
// Take every digit from the string and store it somewhere. After that, remove all the digits from the string. After this
// operation, you should have two lists of items: the numbers list and the non-numbers list:
// • Numbers list: [0, 4, 4, 1, 7, 0]
// • Non-numbers: [s, k, i, p, T, e, s, t, _, S, t, r, i, n, g]
// After that, take every digit in the numbers list and split it up into a take list and a skip list, depending on whether
// the digit is in an even or an odd index:
// • Numbers list: [0, 4, 4, 1, 7, 0]
// • Take list: [0, 4, 7]
// • Skip list: [4, 1, 0]
// Afterward, iterate over both lists and skip {skipCount} characters from the non-numbers list, then take
// {takeCount} characters and store it in a result string. Note that the skipped characters are summed up as they go.
// The process would look like this on the aforementioned non-numbers list:
// 1. Take 0 characters ➔ Taken: "", skip 4 characters (total 0) ➔ Skipped: "skipTest_String"➔ Result: ""
// 2. Take 4 characters➔ Taken: "Test", skip 1 character (total 4) ➔ Skipped: "skip" ➔ Result: "Test"
// 3. Take 7 characters➔ Taken: "String", skip 0 characters (total 9)➔ Skipped: "" ➔ Result: "TestString"
// After that, just print the result string on the console.
// Input
// • First line: The encrypted message as a string
// Output
// • First line: The decrypted message as a string
// Constraints
// • The count of digits in the input string will always be even.
// • The encrypted message will contain any printable ASCII character.


using System;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            List<char> inputList = stringInput.ToList();

            List<char> nonNumber = new List<char>();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            string outPutString = "";
            int count = 0;

            for (int i = 0; i < inputList.Count; i++)
            {
                if (char.IsDigit(inputList[i]))
                {

                    int curentDigit = int.Parse(inputList[i].ToString());
                    numbers.Add(curentDigit);
                }
                else
                {
                    nonNumber.Add(inputList[i]);
                }
            }

            for (int i = 1; i <= numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    skipList.Add(numbers[i - 1]);
                }
                else
                {
                    takeList.Add(numbers[i - 1]);
                }
            }

            for (int i = 1; i <= numbers.Count; i++)
            {
                if (i % 2 != 0)
                {
                    int curentNumber = takeList[0];

                    if(count +curentNumber > nonNumber.Count)
                    {
                       curentNumber = nonNumber.Count - count ;
                    }
                    for (int n = 0; n < curentNumber; n++)
                    {
                        outPutString += nonNumber[count].ToString();
                        count++;
                    }

                    takeList.RemoveAt(0);
                }
                else
                {
                    int curentNumber = skipList[0];

                    for (int n = 0; n < curentNumber; n++)
                    {

                        count++;
                    }

                    skipList.RemoveAt(0);
                }
            }

           
            Console.WriteLine(outPutString);
        }
    }
}