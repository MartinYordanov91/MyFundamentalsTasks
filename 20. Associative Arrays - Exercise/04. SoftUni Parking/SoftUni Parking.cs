namespace _04._SoftUni_Parking
{
    using System;
    using System.Runtime.ConstrainedExecution;
    using System.Security.Cryptography.X509Certificates;

    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            RegisterUnregister(users);
            Print(users);
            
        }

        public static void Print (Dictionary<string, string> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        public static void RegisterUnregister (Dictionary<string, string> users)
        {
            int countUsers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countUsers; i++)
            {
                string[] comandArg = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (comandArg[0] == "register")
                {
                    if (users.ContainsKey(comandArg[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users.First(x => x.Key == comandArg[1]).Value}");
                    }
                    else
                    {
                        users.Add(comandArg[1], comandArg[2]);
                        Console.WriteLine($"{comandArg[1]} registered {comandArg[2]} successfully");
                    }
                }
                else if (comandArg[0] == "unregister")
                {
                    if (users.ContainsKey(comandArg[1]))
                    {
                        users.Remove(comandArg[1]);
                        Console.WriteLine($"{comandArg[1]} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {comandArg[1]} not found");
                    }
                }
            }
        }
    }
}