namespace _04._Morse_Code_Translator
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class Program
    {
        static void Main(string[] args)
        {
            var morseCode = new Dictionary<string, string>();
            morseCode.Add(".-", "A");
            morseCode.Add("-...", "B");
            morseCode.Add("-.-.", "C");
            morseCode.Add("-..", "D");
            morseCode.Add(".", "E");
            morseCode.Add("..-.", "F");
            morseCode.Add("--.", "G");
            morseCode.Add("....", "H");
            morseCode.Add("..", "I");
            morseCode.Add(".---", "J");
            morseCode.Add("-.-", "K");
            morseCode.Add(".-..", "L");
            morseCode.Add("--", "M");
            morseCode.Add("-.", "N");
            morseCode.Add("---", "O");
            morseCode.Add(".--.", "P");
            morseCode.Add("--.-", "Q");
            morseCode.Add(".-.", "R");
            morseCode.Add("...", "S");
            morseCode.Add("-", "T");
            morseCode.Add("..-", "U");
            morseCode.Add("...-", "V");
            morseCode.Add(".--", "W");
            morseCode.Add("-..-", "X");
            morseCode.Add("-.--", "Y");
            morseCode.Add("--..", "Z");
            morseCode.Add("-----", "0");
            morseCode.Add(".----", "1");
            morseCode.Add("..---", "2");
            morseCode.Add("...--", "3");
            morseCode.Add("....-", "4");
            morseCode.Add(".....", "5");
            morseCode.Add("-....", "6");
            morseCode.Add("--...", "7");
            morseCode.Add("---..", "8");
            morseCode.Add("----.", "9");

            string[] tex = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
            var output = new StringBuilder();
            for (int i = 0; i < tex.Length; i++)
            {
                string[] word = tex[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (string c in word)
                {
                    output.Append(morseCode.First(v => v.Key == c).Value);
                }
                output.Append(" ");
            }

            Console.WriteLine(output);
        }
    }
}