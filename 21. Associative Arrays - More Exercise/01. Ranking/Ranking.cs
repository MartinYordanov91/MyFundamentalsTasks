namespace _01._Ranking
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    internal class Program
    {
        static void Main(string[] args)
        {
            var contests = new List<Contests>();
            var candidates = new List<Candidate>();

            ListedContests(contests);
            EmplementateCandidates(contests, candidates);
            PrintWinre(candidates);
            PrintEvryone(candidates);
        }
        public static void PrintEvryone(List<Candidate> candidates)
        {
            foreach (var candidate in candidates.OrderBy(n => n.Name))
            {
                Console.Write(candidate);
            }
        }

        public static void PrintWinre(List<Candidate> candidates)
        {
            string winName = string.Empty;
            int winPoint = 0;

            for (int i = 0; i < candidates.Count; i++)
            {
                string curent = candidates[i].Name;
                int point = candidates[i].candidatesss.Sum(v => v.Value);
                if (point > winPoint)
                {
                    winPoint = point;
                    winName = curent;
                }
            }
            Console.WriteLine($"Best candidate is {winName} with total {winPoint} points.");
            Console.WriteLine("Ranking: ");
        }



        public static void EmplementateCandidates(List<Contests> contests, List<Candidate> candidates)
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] comandArg = input
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string contest = comandArg[0];
                string password = comandArg[1];
                string name = comandArg[2];
                int point = int.Parse(comandArg[3]);

                if (IsPasswordCorect(contests, comandArg))
                {
                    if (IsCandidateContains(contests, comandArg))
                    {
                        if (contests.First(n => n.Contest == contest).person.Any(x => x.Value < point))
                        {
                            contests.First(n => n.Contest == contest).person[name] = point;
                            candidates.First(n => n.Name == name).candidatesss[contest] = point;
                        }
                    }
                    else
                    {
                        contests.First(n => n.Contest == contest).person.Add(name, point);


                        if (candidates.Any(n => n.Name == name) == false)
                        {
                            var candidate = new Candidate(name);
                            candidates.Add(candidate);
                            candidates.First(n => n.Name == name).candidatesss.Add(contest, point);
                        }
                        else
                        {

                            if (candidates.First(n => n.Name == name).candidatesss.ContainsKey(contest) == false)
                            {

                                candidates.First(n => n.Name == name).candidatesss.Add(contest, point);

                            }

                        }
                    }
                }
            }
        }

        public static bool IsPasswordCorect(List<Contests> contests, string[] comandArg)
        {
            string contest = comandArg[0];
            string password = comandArg[1];
            string name = comandArg[2];
            int point = int.Parse(comandArg[3]);

            return contests.Any(n => n.Contest == contest && n.Password == password);
        }

        public static bool IsCandidateContains(List<Contests> contests, string[] comandArg)
        {
            string contest = comandArg[0];
            string password = comandArg[1];
            string name = comandArg[2];
            int point = int.Parse(comandArg[3]);
            return contests.First(n => n.Contest == contest).person.ContainsKey(name);
        }

        public static void ListedContests(List<Contests> contests)
        {
            string curentArg = string.Empty;
            while ((curentArg = Console.ReadLine()) != "end of contests")
            {
                string[] contestArg = curentArg
                    .Split(":", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string contName = contestArg[0];
                string password = contestArg[1];

                if (contests.Any(n => n.Contest == contName) == false)
                {
                    var contest = new Contests(contName, password);
                    contests.Add(contest);
                }
            }
        }
    }

    public class Contests
    {
        public Dictionary<string, int> person = new Dictionary<string, int>();

        public Contests(string contest, string password)
        {
            Contest = contest;
            Password = password;

            this.person = new Dictionary<string, int>();
        }

        public string Contest { get; set; }

        public string Password { get; set; }

        public void AddCandidate(string key, int value)
        {
            this.person.Add(key, value);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Contest);
            foreach (var candidate in person)
            {
                sb.AppendLine($"# {candidate.Key} -> {candidate.Value}");
            }

            return sb.ToString();
        }
    }

    public class Candidate
    {
        public Dictionary<string, int> candidatesss = new Dictionary<string, int>();
        public static void SortMeMe(Dictionary<string, int> candidatesss)
        {
            candidatesss.OrderByDescending(x => x.Value).ToList();
        }

        public Candidate(string name)
        {
            Name = name;

            candidatesss = new Dictionary<string, int>();
        }

        public string Name { get; set; }

        public void AddCandidate(string key, int value)
        {
            this.candidatesss.Add(key, value);
        }

        public override string ToString()
        {

            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            foreach (var candidate in candidatesss.OrderByDescending(x =>x.Value))
            {
                

                sb.AppendLine($"#  {(candidate.Key)} -> {candidate.Value}");
            }

            return sb.ToString();
        }
    }
}