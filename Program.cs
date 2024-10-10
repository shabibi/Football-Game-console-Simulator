using System.Data.SqlTypes;

namespace FotballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flage = false;

            Console.WriteLine("Welcome to the Soccer Game Simulator!\n\n");
            bool flag = false;
            string[] Teem1Names = { "Alex", "Jordan", "Taylor", "Casey", "Morgan", "Jamie", "Riley", "Avery", "Cameron", "Sydney", "Dakota" };
            string[] Teem2Names = { "Quinn", "Skylar", "Robin", "Sam", "Jordan", "Bailey", "Charlie", "Drew", "Reese", "Avery", "Jessie" };
            Match match = new Match();
            //Match match = new Match();
            Console.Write($"Enter name of Teame 1 : ");
            string Team1 = match.team1.getTeamName(Console.ReadLine());

            Console.Write($"Enter name of Teame 2 : ");
            string Team2 = Console.ReadLine();
            //not Accept to Add same teams name.
            do
            {
                if (Team1 == Team2)
                {
                    Console.WriteLine("Not Accept to Assign same teams names..\nPlease enter another name..");
                    Team2 = Console.ReadLine();
                    flag = true;
                }
                else
                    flag = false;

            } while (flag == true);

            Team2= match.team2.getTeamName(Team2);
            Console.WriteLine();

            Console.WriteLine("Generating player for both teams...\n");

            //Assign Names to Team1 and Display players information
            match.team1.AssignPlayer(Teem1Names);
            Console.WriteLine($"Team: {Team1}");
            match.team1.DisplayingPlayersInfo();
            Console.WriteLine("***********************************************************\n");

            //Assign Names to Team2 and Display players information
            match.team2.AssignPlayer(Teem2Names);
            Console.WriteLine($"Team: {Team2}");
            match.team2.DisplayingPlayersInfo();
            //Start the Game
            Console.WriteLine("***********************************************************\n");
            //Get and Display The Starting Team
            match.getStartingTeam();

            Console.WriteLine("***********************************************************\n");
            //Starting First Half
            Console.WriteLine("\n----First Half----");
            match.firstHalf();

            //Starting Second Half
            Console.WriteLine("----Second Half----\n");
            match.secondHalf();
            Console.WriteLine("***********************************************************\n");
            //final score
            match.DisplayResult();


        }


    }

}
