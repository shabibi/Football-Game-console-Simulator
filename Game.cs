using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FotballGame.Player;

namespace FotballGame
{
    public class Game
    {
        public bool goal = false;

        public void attack(Team team1, Team team2)
        {
            int totalAttackValue = 0, totalDefendValue = 0;

            //Calculate total values of Forward and Midfielder skill level for first team
            for (int i = 0; i < team1.PlayerList.Length; i++)
            {
                if ((team1.PlayerList[i].position == Positions.Forward) || (team1.PlayerList[i].position == Positions.Midfielder))
                {
                    totalAttackValue += team1.PlayerList[i].skillLevel;
                }
            }
            //Calculate total values of Goalkeeper and Defender skill level for second team
            for (int i = 0; i < team2.PlayerList.Length; i++)
            {
                if ((team1.PlayerList[i].position == Positions.Goalkeeper) || (team1.PlayerList[i].position == Positions.Defender))
                {
                    totalDefendValue += team2.PlayerList[i].skillLevel;
                }
            }
            // check the attack result 
            if (totalAttackValue > totalDefendValue)
            {
                goal = true;
                team1.score += 1;
            }
            else
            {
                goal = false;
            }
        }

    }
}
