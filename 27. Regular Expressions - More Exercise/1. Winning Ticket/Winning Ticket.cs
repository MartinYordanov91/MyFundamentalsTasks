namespace _1._Winning_Ticket
{
    using System;
    using System.Net.Sockets;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            var output = new StringBuilder();
            var validTicket = new Regex(@"([@#$^])\1{5,9}");

            var inputArg = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputArg.Length; i++)
            {
                var curentTicket = inputArg[i].Trim();

                if (curentTicket.Length != 20)
                {
                    output.AppendLine("invalid ticket");
                    continue;
                }

                string left = String.Join("", curentTicket.Take(10));
                string right = String.Join("", curentTicket.Skip(10));

                var matchleft = validTicket.Match(left);
                var matchright = validTicket.Match(right);

                if ( matchleft.Success==false || matchright.Success == false || matchleft.Value[0] != matchright.Value[0])
                {
                    output.AppendLine($"ticket \"{curentTicket}\" - no match");
                    continue;
                }



                if ( (matchleft.Value.Length < 10 || matchright.Value.Length < 10))
                {
                    output.AppendLine($"ticket \"{curentTicket}\" - {Math.Min(matchleft.Value.Length , matchright.Value.Length)}{matchleft.Value[0]}");
                }
                else if ((matchleft.Value.Length == 10 && matchright.Value.Length == 10))
                {
                    output.AppendLine($"ticket \"{curentTicket}\" - 10{matchleft.Value[0]} Jackpot!");
                }

            }
            Console.WriteLine(output);
        }
    }

}