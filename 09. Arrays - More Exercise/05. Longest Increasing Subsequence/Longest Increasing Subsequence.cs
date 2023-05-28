// Read a list of integers and find the longest increasing subsequence (LIS). If several such exist, print the leftmost
// • Assume we have n numbers in an array nums[0…n-1].
// • Let len[p] hold the length of the longest increasing subsequence (LIS) ending at position p.
// • In a for loop, we shall calculate len[p] for p = 0 … n-1 as follows:
// o Let left be the leftmost position on the left of p (left < p), such that len[left] is the largest
// possible.
// o Then, len[p] = 1 + len[left]. If left does not exist, len[p] = 1.
// o Also, save prev[p] = left (we hold in prev[] the previous position, used to obtain the best
// length for position p).
// • Once the values for len[0…n-1] are calculated, restore the LIS starting from position p such that len[p]
// is maximal and go back and back through p = prev[p].
// • The table below illustrates these computations:


using System;

namespace _05._Longest_Increasing_Subsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] lis;
            int[] len = new int[numberList.Length];
            int[] prev = new int[numberList.Length];
            int maxLength = 0;
            int lastIndex = -1;

            // обхождам поредицата
            for (int i = 0; i < numberList.Length; i++)
            {
                // len && prev съответно = 1 && -1
                len[i] = 1;
                prev[i] = -1;

                // обхождам поредицата и сравнявам за най-добра дължина на поредица
                // if i == j -> цикъл j няма да се изпълни
                for (int j = 0; j < i; j++)
                {
                    // ако текущата стойност j/в ляво/ е по-малка от i/в дясно/
                    // && текущия брой елементи j >= броя елементи на i -> броя на елементите /поредицата/ ще нараства
                    if (numberList[j] < numberList[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j; // запазваме индекса на най добрия елемент от поредицата
                    }
                }
                // запазвам максималния брой елементи
                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = numberList[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}