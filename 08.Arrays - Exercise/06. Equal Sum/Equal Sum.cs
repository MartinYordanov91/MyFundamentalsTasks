// Create a program that determines if an element exists in an array for which the sum of all elements to its left is
// equal to the sum of all elements to its right. If there are no elements to the left or right, their sum is considered to
// be 0. Print the index of the element that satisfies the condition or "no" if there is no such element.


using System;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArry = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSaid = 0, rightSaid = 0 , positon;
            bool no = true;

            for (int i = 0; i < intArry.Length; i++)
            {
                leftSaid = 0;

                for (int left = 0; left < i; left++)
                {
                    leftSaid += intArry[left];
                }

                positon = i;

                for (int right = i+1; right < intArry.Length; right++)
                {
                    rightSaid += intArry[right];
                }

                if (leftSaid == rightSaid )
                {
                    Console.WriteLine(positon);
                    no = false;
                    break;
                   
                }
                
                leftSaid =0; rightSaid=0 ;
            }
            if (no) { Console.WriteLine("no"); }

        }
    }
}