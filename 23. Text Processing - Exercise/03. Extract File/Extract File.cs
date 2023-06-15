namespace _03._Extract_File
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string urlAdres = Console.ReadLine();

            int indexName = urlAdres.LastIndexOf("\\");
            int indexExtension = urlAdres.LastIndexOf(".");
            string name = urlAdres.Substring(indexName + 1, indexExtension - indexName - 1);
            string extension = urlAdres.Substring(indexExtension + 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
           
        }
    }
}