using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FotballGame.Player;

namespace FotballGame
{
    public class Team
    {
        //Attributes:
        public string Name;
        public Player[] PlayerList = new Player[11];
        public int score = 0;

        //Constructor
        public string getTeamName(string name)
        {
            return Name = name;
        }

        //Method
        public void AssignPlayer(string[] TeamNames)
        {
            Random random = new Random();

            //Assign values for Goalkeeper
            Positions PlayerPostion = Positions.Goalkeeper;
            int skillLevel = random.Next(1, 100);
            PlayerList[0] = new Player(TeamNames[0], skillLevel, PlayerPostion);

            //Assign values for Midfielder
            for (int i = 1; i < 4; i++)
            {
                PlayerPostion = Positions.Midfielder;
                //generate Random Skill level for Team1 player
                skillLevel = random.Next(1, 100);
                PlayerList[i] = new Player(TeamNames[i], skillLevel, PlayerPostion);

            }

            //Assign values for Forward
            for (int i = 4; i < 7; i++)
            {
                PlayerPostion = Positions.Forward;
                //generate Random Skill level for Team1 player
                skillLevel = random.Next(1, 101);
                PlayerList[i] = new Player(TeamNames[i], skillLevel, PlayerPostion);
            }

            //Assign values for Defender
            for (int i = 7; i < 11; i++)
            {
                PlayerPostion = Positions.Defender;
                //generate Random Skill level for Team1 player
                skillLevel = random.Next(1, 100);
                PlayerList[i] = new Player(TeamNames[i], skillLevel, PlayerPostion);
            }

        }

        public void DisplayingPlayersInfo()
        {
            Console.WriteLine("{0, -5} {1, -20} {2, -15} {3, -10}", "No.", "Player Name", "Position", "Skill Level");
            for (int i = 0; i < PlayerList.Length; i++)
            {
                Console.WriteLine("{0, -5} {1, -20} {2, -15} {3, -10}",
                     i + 1,
                     PlayerList[i].playerName,
                     PlayerList[i].position,
                     PlayerList[i].skillLevel);
            }
        }
    }
}