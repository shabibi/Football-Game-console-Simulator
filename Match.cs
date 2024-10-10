using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballGame
{
    public class Match : Game
    {
        public int CoinsTose;
        public int round;
        public Team team1 = new Team();
        public Team team2 = new Team();
        public int getCoinsTose()
        {
            Random random = new Random();
            CoinsTose = random.Next(1, 3);
            Console.WriteLine(CoinsTose);
            return CoinsTose;
        }

        public Team getStartingTeam()
        {
            Team team = new Team();
            if(CoinsTose == 1)
                team = team1;
            else
                team = team2;

            return team;
        }
        public int getRound()
        {
            Random random = new Random();
            round = random.Next(1, 5);

            return round;
        }

        public void StartGame()
        {
            int start = getCoinsTose();
            int rounded = getRound();
            if (start == 1)
            {
                for (int i = 0; i < rounded; i++)
                {
                    if (i % 2 != 0)
                    {
                        attack(team1, team2);
                    }
                    else
                    {
                        attack(team2, team1);
                    }
                }
            }
            else
            {
                for (int i = 0; i < rounded; i++)
                {
                    if (i % 2 != 0)
                    {
                        attack(team2, team1);
                    }
                    else
                    {
                        attack(team1, team2);
                    }
                }
            }

            //Second Half
            if (start == 1)
            {
                for (int i = 0; i < rounded; i++)
                {
                    if (i % 2 != 0)
                    {
                        attack(team2, team1);
                    }
                    else
                    {
                        attack(team1, team2);
                    }
                }
            }
            else
            {
                for (int i = 0; i < rounded; i++)
                {
                    if (i % 2 != 0)
                    {
                        attack(team1, team2);
                    }
                    else
                    {
                        attack(team2, team1);
                    }
                }
            }
        }

        
    }
}
