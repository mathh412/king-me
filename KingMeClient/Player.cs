using KingMeServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingMeClient
{
    public class Player : RoomPlayer
    {
        protected string password=null;
        public string Password
        {
            get { return password; }
        }

        public char[] Card
        {
            get
            {
                if (this.password == null)
                    return null;
                DBResponse resp = new DBResponse(Jogo.ListarCartas(this.id, this.password));
                if (resp.error)
                {
                    resp.ShowError();
                    return null;
                }
                return resp.response.ToCharArray();
            }
        }


        public Player(RoomPlayer roomPlayer=null)
        {
            if (roomPlayer == null)
                return;

            this.id = roomPlayer.Id;
            this.name = roomPlayer.Name;
            this.score = roomPlayer.Score;
        }

        // Register
        public bool JoinRoom(Room room, string username)
        {
            InputBox ib = new InputBox("Digite a senha da sala");
            ib.ShowDialog();
            if (ib.Response == null){
                return false;
            }
            room.password = ib.Response;
            DBResponse resp = new DBResponse(Jogo.Entrar(room.id, username, room.password));
            if (resp.error)
            {
                resp.ShowError();
                return false;
            }
            string[] playerData = resp.response.Split(',');
            this.id = Convert.ToInt32(playerData[0]);
            this.password = playerData[1];
            this.name = username;
            return true;
        }

        // Login
        public bool JoinRoom(Room room)
        {
            if (room.GetPlayer(this.id) == null)
            {
                MessageBox.Show("Usuário não está na sala!", "Error");
                return false;
            }

            InputBox inputBox = new InputBox("Digite a senha do jogador");
            inputBox.ShowDialog();
            if (inputBox.Response == null)
            {
                return false;
            }
            this.password = inputBox.Response.ToUpper();
            if (!CheckPassword())
            {
                MessageBox.Show("Senha de usuário errada!", "Error");
                return false;
            }

            return true;
        }

        public bool CheckPassword()
        {
            string resp = Jogo.ListarCartas(this.id, this.password);
            return !resp.StartsWith("ERRO: Jogador");
        }

        public bool StartGame()
        {
            DBResponse resp = new DBResponse(Jogo.Iniciar(this.id, this.password));
            if (resp.error)
            {
                resp.ShowError();
                return false;
            }
            return true;
        }

        public bool PutCharacter(int sector, string character)
        {
            DBResponse resp = new DBResponse(Jogo.ColocarPersonagem(this.id, this.password, sector, character));
            if (resp.error)
            {
                resp.ShowError();
                return false;
            }
            return true;
        }

        public void PromoteCharacter(string character)
        {
            DBResponse resp = new DBResponse(Jogo.Promover(this.id, this.password, character));
            if (resp.error)
                resp.ShowError();
        }

        public void Vote(string vote)
        {
            DBResponse resp = new DBResponse(Jogo.Votar(this.id, this.password, vote));
            if (resp.error)
                resp.ShowError();
        }
    }
}
