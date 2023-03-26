using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THA_MEGAN_R
{
    internal class Player
    {
        public string playerName { get; set; }
        public string playerNumber { get; set; }
        public string playerPosition { get; set; }
        public Player(string playerName, string playerNumber, string playerPosition)
        {
            this.playerName = playerName;
            this.playerNumber = playerNumber;
            this.playerPosition = playerPosition;
        }
    }
}
