﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FotballGame.Player;

namespace FotballGame
{
    public class Game
    {
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
                if ((team2.PlayerList[i].position == Positions.Goalkeeper) || (team2.PlayerList[i].position == Positions.Defender))
                {
                    totalDefendValue += team2.PlayerList[i].skillLevel;
                }
            }
            // check the attack result 
            if (totalAttackValue +10  > totalDefendValue)
            {
                team1.score += 1;
                Console.Write($"Goal!");
            }
            else
            {
                Console.Write("Defended successfuly!");
            }
            Console.WriteLine($" Score: {team1.score} | {team2.score}");
            
        }

        
    }
}
