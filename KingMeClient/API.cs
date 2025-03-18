using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KingMeServer;


namespace KingMeClient
{
    public static class API
    {
        public static string GROUP = "Senhores de Kent";

        public static List<Room> ListRooms()
        {
            List<Room> rooms = new List<Room>();

            foreach (string r in new DBResponse(Jogo.ListarPartidas("T")).list)
            {
                rooms.Add(new Room(r));
            }

            return rooms;
        }

        public static Dictionary<int, RoomPlayer> GetPlayers() {
            Dictionary<int, RoomPlayer> playersDict = new Dictionary<int, RoomPlayer>();

            foreach(Room room in ListRooms())
            {
                foreach(RoomPlayer player in room.Players)
                {
                    playersDict.Add(player.Id, player);
                }
            }
            return playersDict;
        }

        public static string GetCharacterNameByLetter(char letter)
        {
            DBResponse names = new DBResponse(Jogo.ListarPersonagens());
            foreach(string name in names.list) {
                if (name.ToUpper()[0] == letter.ToString().ToUpper()[0])
                {
                    return name;
                }
            }
            return "";
        }
    }
}
