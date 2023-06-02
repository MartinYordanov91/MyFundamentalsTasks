// It's time for the teamwork projects and you are responsible for gathering the teams. First, you will receive an integer
// – the count of the teams you will have to register. You will be given a user and a team, separated with "-". The
// user is the creator of the team. For every newly created team you should print a message:
// "Team {teamName} has been created by {user}!".
// Next, you will receive а user with a team, separated with "->", which means that the user wants to join that team.
// Upon receiving the command: "end of assignment", you should print every team, ordered by the count of its
// members (descending) and then by name (ascending). For each team, you have to print its members sorted by
// name (ascending). However, there are several rules:
// • If а user tries to create a team more than once, a message should be displayed:
// - "Team {teamName} was already created!"
// • A creator of a team cannot create another team – the following message should be thrown:
// - "{user} cannot create another team!"
// • If а user tries to join a non-existent team, a message should be displayed:
// - "Team {teamName} does not exist!"
// • A member of a team cannot join another team – the following message should be thrown:
// - "Member {user} cannot join team {team Name}!"
// • In the end, teams with zero members (with only a creator) should disband and you have to print them
// ordered by name in ascending order.
// • Every valid team should be printed ordered by name (ascending) in the following format:

namespace _05._Teamwork_Projects
{
    using System;
    internal class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();
            InitializeTeam(teams);
            JoinTeam(teams);
            PrintValidTeams(teams);
            PrintDisbandTeam(teams);

        }
        static void PrintDisbandTeam(List<Team> teams)
        {
            List<Team> teamDisband = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();
            Console.WriteLine("Teams to disband:");
            foreach (Team disbanTeam in teamDisband)
            {
                Console.WriteLine($"{disbanTeam.Name}");
            }
        }

        static void PrintValidTeams(List<Team> teams)
        {
            List<Team> teamWithMenmbers = teams // copy list
                 .Where(t => t.Members.Count > 0) // filter team with members
                 .OrderByDescending(t => t.Members.Count) // sort from max to min by members count
                 .ThenBy(t => t.Name) // sort them by name 
                 .ToList();

            foreach (var team in teamWithMenmbers)
            {
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }

        static void JoinTeam(List<Team> teams)
        {
            string comand;
            while ((comand = Console.ReadLine()) != "end of assignment")
            {
                string[] comandArgs = comand.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string user = comandArgs[0];
                string teamName = comandArgs[1];

                if (!TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (AlreadyAMemberOfATeam(teams, user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    Team teamToJoin = teams
                        .First(t => t.Name == teamName);
                    teamToJoin.AddMember(user);
                }
            }
        }

        static void InitializeTeam(List<Team> teams)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] teamArgs = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries);

                string creator = teamArgs[0];
                string teamName = teamArgs[1];

                if (TeamExists(teams, teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (AlreadyCreatedATeam(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team newTeam = new Team(teamName, creator);
                    teams.Add(newTeam);

                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }
        }

        static bool AlreadyAMemberOfATeam(List<Team> teams, string user)
        {
            return teams.Any(t => t.Creator == user || t.Members.Contains(user));
        }
        static bool AlreadyCreatedATeam(List<Team> teamm, string creator)
        {
            return teamm.Any(t => t.Creator == creator);
        }
        static bool TeamExists(List<Team> team, string teamName)
        {
            return team.Any(t => t.Name == teamName);
        }
    }

    public class Team
    {
        //fild
        private readonly List<string> members;
        // constructor
        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;

            this.members = new List<string>();
        }
        //property
        public string Name { get; set; }

        public string Creator { get; set; }

        //get only property
        public IReadOnlyCollection<string> Members
            => this.members;

        // methods
        public void AddMember(string memberName)
        {
            this.members.Add(memberName);
        }
    }
}