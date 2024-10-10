namespace FotballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Soccer Game Simulator!\n\n");

            string[] Teem1Names = { "Alex", "Jordan", "Taylor", "Casey", "Morgan", "Jamie", "Riley", "Avery", "Cameron", "Sydney", "Dakota" };
            string[] Teem2Names = { "Quinn", "Skylar", "Robin", "Sam", "Jordan", "Bailey", "Charlie", "Drew", "Reese", "Avery", "Jessie" };

            Match match = new Match();
            Console.Write($"Enter name of Teame 1 : ");
            string Team1 = match.team1.getTeamName(Console.ReadLine());
           
            Console.Write($"Enter name of Teame 2 : ");
            string Team2 = match.team2.getTeamName(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Generating player for both teams...\n");
            match.team1.AssignPlayer(Teem1Names);
            Team team1Player = new Team();
            team1Player.PlayerList = match.team1.PlayerList;
            Console.WriteLine(Team1);
            for (int i = 0; i < team1Player.PlayerList.Length; i++)
            {
                Console.WriteLine($"{ i + 1}.{team1Player.PlayerList[i].playerName} - {team1Player.PlayerList[i].position} (Skill: {team1Player.PlayerList[i].skillLevel}) ");
            }
            Console.WriteLine();
            match.team2.AssignPlayer(Teem2Names);
            Team team2Player = new Team();
            team2Player.PlayerList = match.team2.PlayerList;
            Console.WriteLine(Team2);
            for (int i = 0; i < team2Player.PlayerList.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{team2Player.PlayerList[i].playerName} - {team2Player.PlayerList[i].position} (Skill: {team2Player.PlayerList[i].skillLevel}) ");
            }

            match.StartGame();
        }
    }
}
