namespace _02._A_Miner_Task
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            FillingResources(resources);
            PrintResources(resources);
        }
        public static void PrintResources(Dictionary<string, int> resources)
        {
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        public static void FillingResources(Dictionary<string, int> resources)
        {
            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());


                if (resources.ContainsKey(resource) == false)
                {
                    resources.Add(resource, 0);
                }
                resources[resource] += quantity;

            }
        }
    }
}