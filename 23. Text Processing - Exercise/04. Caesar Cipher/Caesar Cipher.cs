namespace _04._Caesar_Cipher
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string curentInput = Console.ReadLine();
            var sb = new StringBuilder();

            for (int i = 0; i < curentInput.Length; i++)
            {
                int c = curentInput[i];
                c += 3;
                char b = (char)c;

               
                sb.Append(b);
            }

            Console.WriteLine(sb);
           
        }
    }
}