namespace _3._Post_Office
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            var firstStep = new Regex(@"(\$|%|\*|&|#)(?<chars>[A-z]+)\1");
            var secondStep = new Regex(@"(?<asciiCode>\d{2}):(?<length>\d{2})");
            var thirdStep = new Regex(@"^[A-Z][!-~]+");
            var inputText = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();

            //First Steps
            var leatterMach = firstStep.Match(inputText[0]);
            var chars = leatterMach.Groups["chars"].Value.ToCharArray();

            // Second Steps
            var asciiLetterFind = secondStep.Matches(inputText[1]);
            var wordLenght = new List<int>();

            for (int i = 0; i < chars.Length; i++)
            {
                foreach (Match match in asciiLetterFind)
                {
                    int curent =int.Parse(match.Groups["asciiCode"].Value);

                    if(curent == chars[i])
                    {
                        wordLenght.Add(int.Parse(match.Groups["length"].Value)+1);
                        break;
                    }

                }
            }

            // Third Step
            var text = inputText[2]
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int m = 0; m < chars.Length; m++)
            {
                foreach (var item in text)
                {
                    var curentWord = thirdStep.Match(item);
                    if (curentWord.Success == false)
                    {
                        continue;
                    }

                    if (chars[m] == curentWord.Value[0] && wordLenght[m] == curentWord.Value.Length)
                    {
                        sb.AppendLine(curentWord.Value);
                        break;
                    }
                }
            }

            // print
            Console.WriteLine(sb);
        }
    }
}