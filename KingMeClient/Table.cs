using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingMeClient
{
    public class Table
    {
        Room room;

        public int turnID;
        public char gameStatus;
        public int round;
        public char phase;
        public string turnRaw;
        public Dictionary<int, string> board;
        public List<string> charactersOutOfBoard;
        private string[] turnSplitted;

        public Table(Room room) { 
            this.room = room;
        }

        public int StartNoVotes
        {
            get
            {
                return Convert.ToInt32(12 / this.room.Players.Count);
            }
        }

        // TODO: Implement this
        public int GetPlayerNoVotesLeft(int playerID)
        {
            if (this.room.Status == 'A')
                return 0;
            return 0;
            //DBResponse resp = new DBResponse(Jogo.ConsultarHistorico(this.room.id, false));

        }

        // IF YOU WANT TO UPDATE ONLY ONE PART OF THE TABLE, USE THESE METHOD, BUT CALL UpdateBaseInfo() BEFORE
        public void UpdateCharactersOutOfBoard()
        {
            if (this.board == null)
                return;

            this.charactersOutOfBoard = new List<string>();
            DBResponse resp = new DBResponse(Jogo.ListarPersonagens());
            foreach (string pers in resp.list)
            {
                char target = pers.ToUpper()[0];
                bool contains = false;
                foreach (int sector in this.board.Keys)
                {
                    if (this.board[sector].Contains(target))
                    {
                        contains = true;
                        break;
                    }
                }
                if (!contains)
                {
                    this.charactersOutOfBoard.Add(pers);
                }
            }
        }

        // IF YOU WANT TO UPDATE ONLY ONE PART OF THE TABLE, USE THESE METHOD, BUT CALL UpdateBaseInfo() BEFORE
        public void UpdateBoard()
        {
            if (this.turnSplitted == null) 
                return;

            board = new Dictionary<int, string>();
            board.Add(0, "");
            board.Add(1, "");
            board.Add(2, "");
            board.Add(3, "");
            board.Add(4, "");
            board.Add(5, "");
            board.Add(10, "");
            for (int i = 4; i < this.turnSplitted.Length; i += 2)
            {
                board[Convert.ToInt32(this.turnSplitted[i])] += this.turnSplitted[i + 1];
            }
        }

        public void UpdateBaseInfo()
        {
            DBResponse resp = new DBResponse(Jogo.VerificarVez(room.id));
            if (resp.error)
                return;
            this.turnRaw = resp.response;
            this.turnSplitted = resp.response.Replace("\n", ",").Split(',');
            this.turnID = Convert.ToInt32(this.turnSplitted[0]);
            this.gameStatus = this.turnSplitted[1][0];
            this.round = Convert.ToInt32(this.turnSplitted[2]);
            this.phase = this.turnSplitted[3][0];
        }

        public void Update()
        {
            UpdateBaseInfo();

            UpdateBoard();

            UpdateCharactersOutOfBoard();
        }
    }
}
