using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KingMeClient
{
    public class RoomPlayer
    {
        protected int id;
        protected string name;
        protected int score;

        public int Id {  get { return id; } }
        public string Name { get { return name; } }
        public int Score { get { return score; } }

        // Made for room player string
        public RoomPlayer(string player = "")
        {
            if (player == "")
            {
                return;
            }
            string[] playerData = player.Trim().Split(',');
            this.id = Convert.ToInt32(playerData[0]);
            this.name = playerData[1];
            this.score = Convert.ToInt32(playerData[2]);
        }

        public RoomPlayer(int id, string name, int score)
        {
            this.id = id;
            this.name = name;
            this.score = score;
        }
    }
}
