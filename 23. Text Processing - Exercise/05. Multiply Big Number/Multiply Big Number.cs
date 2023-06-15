namespace _05._Multiply_Big_Number
{
    using System;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            string nuber = Console.ReadLine();
            int multiply = int.Parse(Console.ReadLine());

            int remainder = 0;

            var sb = new StringBuilder();

            for (int i = nuber.Length -1; i >= 0; i--)
            {
                if (multiply == 0)
                {
                    sb.Append('0');
                    break;
                }

                int num = (int)nuber[i] - 48;
                num *= multiply;
                num+= remainder;

                if(num > 9)
                {
                    
                    remainder = num / 10;
                    num %= 10;
                    sb.Append(num);
                }
                else
                {
                    remainder= 0;
                    sb.Append(num);
                }
                
            }
            if(remainder > 0)
            {
                sb.Append(remainder);

            }


            Reverses(sb);
            Console.WriteLine(sb);
        }
        public static void Reverses(StringBuilder sb)
        {
            char t;
            int end = sb.Length - 1;
            int start = 0;

            while (end - start > 0)
            {
                t = sb[end];
                sb[end] = sb[start];
                sb[start] = t;
                start++;
                end--;
            }
        }
    }
}