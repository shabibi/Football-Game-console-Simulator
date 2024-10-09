using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FotballGame
{
    public abstract class Player
    {
        // Attributes:
        public string playerName;
        public int skillLevel;
        public enum Positions { Forward, Midfielder, Defender, Goalkeeper };
        public Positions position;

        //Constructor
        public Player(string playerName, int skillLevel, Positions position)
        {
            this.playerName = playerName;
            this.skillLevel = skillLevel;
            this.position = position;
        }
    }
}
