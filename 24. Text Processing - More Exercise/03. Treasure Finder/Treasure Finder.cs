namespace _03._Treasure_Finder
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string criptetText = string.Empty;
            while ((criptetText = Console.ReadLine()) != "find")
            {
                int n = 0;
                var sb = new StringBuilder();
                char[] charsARG = criptetText.ToCharArray();

                for (int i = 0; i < charsARG.Length; i++)
                {
                    if (n == key.Length)
                    {
                        n = 0;
                    }

                    int curent = charsARG[i] - (key[n]);
                    sb.Append((char)(curent));
                    n++;
                }

               
                int indexsymbol = sb.ToString().IndexOf("&");
                var sbOut = new StringBuilder();
                sbOut.Append("Found ");
                indexsymbol += 1;
                while (true)
                {
                    sbOut.Append(sb[indexsymbol]);
                    indexsymbol += 1;
                    if (sb[indexsymbol] == '&')
                    {
                        break;
                    }
                }
                sbOut.Append(" at ");

                indexsymbol = sb.ToString().IndexOf("<");
                indexsymbol += 1;

                while (true)
                {
                    sbOut.Append(sb[indexsymbol]);
                    indexsymbol += 1;
                    if (sb[indexsymbol] == '>')
                    {
                        break;
                    }
                }

                Console.WriteLine(sbOut);
            }
        }
    }
}