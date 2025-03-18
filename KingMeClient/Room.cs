using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KingMeClient
{
    public class Room
    {
        public int id;
        public string name;
        public string password="";
        public string group;
        public string date;

        public List<RoomPlayer> Players
        {
            get
            {
                List<RoomPlayer> playerList = new List<RoomPlayer>();
                DBResponse resp = new DBResponse(Jogo.ListarJogadores(this.id));
                //if (resp.response == "")
                //    return playerList;
                foreach (string player in resp.list)
                {
                    if (player != "")
                        playerList.Add(new RoomPlayer(player));
                }
                return playerList;
            }
        }

        public char Status { 
            get {
                DBResponse rooms = new DBResponse(Jogo.ListarPartidas("T"));
                foreach(string room in rooms.list)
                {
                    if (!room.StartsWith(this.id.ToString()))
                        continue;
                    // string[] roomData = room.Trim().Split(',');
                    return room[room.Length-1];
                }
                return ' ';
            } 
        }

        public RoomPlayer Winner
        {
            get
            {
                return this.Players[0];
            }
        }

        public Room(string name, string password, string group) 
        {
            this.name = name;
            this.password = password;
            this.group = group;
        }

        public Room(string data)
        {
            string[] roomData = data.Trim().Split(',');
            this.id = Convert.ToInt32(roomData[0]);
            this.name = roomData[1];
            this.date = roomData[2];
        }

        public RoomPlayer GetPlayer(string username)
        {

            return this.Players.Find(player => player.Name == username);
            //return p == default(RoomPlayer) ? null : p;
            
            //foreach (RoomPlayer player in this.Players)
            //{
            //    if (player.Name == username)
            //    {
            //        return player;
            //    }
            //}
            //return null;
        }

        public RoomPlayer GetPlayer(int id)
        {
            return this.Players.Find(player => player.Id == id);
            //return p == default(RoomPlayer) ? null : p;
            
            //foreach (RoomPlayer player in this.Players)
            //{
            //    if (player.Id == id)
            //    {
            //        return player;
            //    }
            //}
            //return null;
        }

        public bool Create()
        {
            DBResponse resp = new DBResponse(Jogo.CriarPartida(this.name, this.password, this.group));
            if (resp.error)
            {
                resp.ShowError();
                return false;
            }

            this.id = Convert.ToInt32(resp.response);
            return true;
        }
    }
}
