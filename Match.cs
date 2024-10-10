using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FotballGame
{
    public class Match : Game 
    {
        public int start;
        public int round;
        public Team team1 = new Team();
        public Team team2 = new Team();
     

        public void getStartingTeam()
        {
            Random random = new Random();
            start = random.Next(1,3);

            //Generate random number of turns
            round = random.Next(1,6);

            if(start == 1)
                Console.WriteLine($"Coins toss.. Team {team1} will start the game");
            else
                Console.WriteLine($"Coins toss.. Team {team2} will start the game");

        }
       


        public void firstHalf()
        {
            if (start == 1)
            {
                for (int i = 1; i <= round; i++)
                {
                    Console.Write($"Turn{i}: {team1.Name} ara attacking..");
                    if (i % 2 != 0)
                    {
                        Console.Write($"Turn{i}: {team1.Name} ara attacking..");
                        attack(team1, team2);
                    }
                    else
                    {
                        Console.Write($"Turn{i}: {team2.Name} ara attacking..");
                        attack(team2, team1);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= round; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"Turn{i}: {team2.Name} ara attacking..");
                        attack(team2, team1);
                    }
                    else
                    {
                        Console.Write($"Turn{i}: {team1.Name} ara attacking..");
                        attack(team1, team2);
                    }
                }
            }
        }
        public void secondHalf()
        {
            //Second Half
            if (start == 1)
            {
                for (int i = 1; i <= round; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"Turn{i}: {team2.Name} ara attacking..");
                        attack(team2, team1);
                    }
                    else
                    {
                        Console.Write($"Turn{i}: {team1.Name} ara attacking..");
                        attack(team1, team2);
                    }
                }
            }
            else
            {
                for (int i = 1; i <= round; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write($"Turn{i}: {team1.Name} ara attacking..");
                        attack(team1, team2);
                    }
                    else
                    {
                        Console.Write($"Turn{i}: {team2.Name} ara attacking..");
                        attack(team2, team1);
                    }
                }
            }
        }

   

        public void DisplayResult()
        {
            Console.WriteLine("\nFinal Score:");
            Console.WriteLine($"{team1.Name}: {team1.score} | {team2.Name}: {team2.score}");

            if (team1.score != team2.score)
            {
                if(team1.score> team2.score)
                    Console.WriteLine($"\n{team1.Name} IS THE WINNER!");
                else
                    Console.WriteLine($"\n{team2.Name} IS THE WINNER!");
            }
            else
                Console.WriteLine($"\nIt's a draw!");
        }
    }
}
