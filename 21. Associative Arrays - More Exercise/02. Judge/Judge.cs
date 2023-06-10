namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var individualStatus = new SortedDictionary<string, int>();

            var contestes = new Dictionary<string, Dictionary<string, int>>();

            FillColections(individualStatus, contestes);
            PrintColection(contestes);
            PrintColection(individualStatus);


        }
        public static void PrintColection(SortedDictionary<string, int> individualStatus)
        {
            int num = 1;
            Console.WriteLine("Individual standings:");
            foreach (var student in individualStatus.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{num}. {student.Key} -> {student.Value}");
                num++;
            }
        }
        public static void PrintColection(Dictionary<string, Dictionary<string, int>> contestes)
        {
            foreach (var conte in contestes)
            {
                int n = 1;
                Console.WriteLine($"{conte.Key}: {conte.Value.Count} participants");

                foreach (var item in conte.Value.OrderByDescending(x => x.Value).ThenBy(n => n.Key))
                {
                    Console.WriteLine($"{n}. {item.Key} <::> {item.Value}");
                    n++;
                }
            }
        }

        public static void FillColections (SortedDictionary<string , int> individualStatus , Dictionary<string , Dictionary<string , int>> contestes)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] curentArg = input
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = curentArg[0];
                string contest = curentArg[1];
                int points = int.Parse(curentArg[2]);

                if (contestes.ContainsKey(contest) == false)
                {
                    contestes.Add(contest, new Dictionary<string, int>());
                    contestes[contest].Add(name, points);

                    if (individualStatus.ContainsKey(name))
                    {
                        individualStatus[name] += points;
                    }
                    else
                    {
                        individualStatus.Add(name, points);
                    }
                }
                else
                {
                    if (contestes[contest].ContainsKey(name))
                    {
                        if (contestes[contest][name] < points)
                        {
                            int diferent = points - contestes[contest][name];
                            contestes[contest][name] = points;
                            individualStatus[name] += diferent;
                        }
                    }
                    else
                    {
                        contestes[contest].Add(name, points);

                        if (individualStatus.ContainsKey(name))
                        {
                            individualStatus[name] += points;
                        }
                        else
                        {
                            individualStatus.Add(name, points);
                        }
                    }

                }

            }
        }
    }
}