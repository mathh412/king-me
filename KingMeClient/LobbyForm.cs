using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KingMeServer;


namespace KingMeClient
{
    public partial class LobbyForm : Form
    {
        Player lastPlayer = null;
        Room lastRoom = null;
        Room selectedRoom = null;
        int lastRoomClickedIndex = -1;
        int lastSelectedPlayerID=0;

        public LobbyForm()
        {
            InitializeComponent();
            this.Visible = false;
            new SplashForm().ShowDialog();
            this.Visible = true;
            lblVersion.Text = $"🌐 DLL {Jogo.versao}";
            tmrRefreshLobby_Tick(null, null);
        }

        private void UpdateRoomsList()
        {
            DBResponse rooms = new DBResponse(Jogo.ListarPartidas("T"));
            if (txtSearchRoom.Text.Trim() != "")
            {
                rooms.list = rooms.list.Where(r => r.ToLower().Contains(txtSearchRoom.Text.ToLower())).ToArray();
            }
            if (rooms.list.Length < lstRooms.Items.Count)
                lstRooms.Items.Clear();

            for (int i = 0; i < rooms.list.Length; i++)
            {
                if (i < lstRooms.Items.Count)
                {
                    // already added, just edit
                    lstRooms.Items[i] = rooms.list[i].Replace(",", " | ");
                }
                else
                {
                    // add
                    lstRooms.Items.Add(rooms.list[i].Replace(",", " | "));
                }
            }
        }

        private void UpdatePlayersList()
        {
            if (this.lastRoomClickedIndex < 0 || this.selectedRoom == null)
                return;
            lstPlayers.Items.Clear();
            foreach (RoomPlayer player in this.selectedRoom.Players)
            {
                lstPlayers.Items.Add($"{player.Id} | {player.Name}");
            }
        }

        private void tmrRefreshLobby_Tick(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;

            UpdateRoomsList();
            UpdatePlayersList();

            if (this.lastRoom == null || this.lastPlayer == null)
            {
                pnlLastJoinInfo.Visible = false;
                return;
            }
            pnlLastJoinInfo.Visible = true;
            
            lblLastUserID.Text = this.lastPlayer.Id.ToString();
            lblLastUsername.Text = this.lastPlayer.Name;
            lblLastUserPassword.Text = this.lastPlayer.Password;
            int playerCount = this.lastRoom.Players.Count - 1;
            string lastWord = playerCount > 1 ? "amigos" : "amigo :(";
            lblLastRoomStatus.Text = $"Jogando em {this.lastRoom.name} com {playerCount} {lastWord}";
        }

        void OpenGameForm()
        {
            if (this.lastPlayer == null || this.lastRoom == null)
                return;

            GameForm gameForm = new GameForm(this.lastRoom, this.lastPlayer);
            this.Visible = false;
            gameForm.ShowDialog();
            gameForm.Close();
            this.Visible = true;
        }

        private void JoinSelectedRoom() {
            Room room = this.selectedRoom;
            Player player = null;

            bool success;

            // Login
            if (txtUserName.Text.Trim().Length == 0)
            {
                player = new Player(room.GetPlayer(this.lastSelectedPlayerID));
                success = player.JoinRoom(room);
            }
            // Register
            else
            {
                player = new Player();
                success = player.JoinRoom(room, txtUserName.Text);
            }

            if (!success)
            {
                return;
            }

            //txtPlayerInfo.Text = $"ID: {player.id}\r\nSenha: {player.password}";
            //UpdatePlayersList();
            this.lastPlayer = player;
            this.lastRoom = room;
            this.lastSelectedPlayerID = player.Id;
            txtUserName.Text = "";
            Clipboard.SetText(player.Password);
            OpenGameForm();
        }

        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRooms.SelectedIndex < 0 && lstRooms.SelectedIndex >= lstRooms.Items.Count || lstRooms.SelectedItem == null)
                return;

            // list players only
            if (lstRooms.SelectedIndex != this.lastRoomClickedIndex)
            {
                this.lastRoomClickedIndex = lstRooms.SelectedIndex;
                lstRooms.SelectedIndex = -1;
                this.selectedRoom = new Room(lstRooms.Items[this.lastRoomClickedIndex].ToString().Replace(" | ", ","));
                UpdatePlayersList();
                return;
            }
            lstRooms.SelectedIndex = -1;

            JoinSelectedRoom();
        }

        private void btnCriarSala_Click(object sender, EventArgs e)
        {
            Room newRoom = new Room(txtNewSalaNome.Text, txtNewSalaSenha.Text, API.GROUP);
            if (newRoom.Create())
            {
                MessageBox.Show("Sala criada com sucesso!");
                return;
            }
            MessageBox.Show("Erro ao criar a sala!", "Error");
        }

        private void lstPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.selectedRoom == null)
                return;
            
            List<RoomPlayer> players = this.selectedRoom.Players;

            if (lstPlayers.SelectedIndex < 0 || lstPlayers.SelectedIndex >= players.Count)
                return;

            RoomPlayer selectedPlayer = players[lstPlayers.SelectedIndex];
            this.lastSelectedPlayerID = selectedPlayer.Id;
            txtUserName.Text = "";

            if (this.lastPlayer != null && this.lastPlayer.Id == selectedPlayer.Id)
            {
                OpenGameForm();
                return;
            }

            JoinSelectedRoom();
        }

        private void lblLastRoomStatus_Click(object sender, EventArgs e)
        {
            OpenGameForm();
        }

        private void txtSearchRoom_TextChanged(object sender, EventArgs e)
        {
            this.lastRoomClickedIndex = -1;
        }

        private void btnCriarSala_MouseLeave(object sender, EventArgs e)
        {
            btnCriarSala.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255, 255);
        }

        private void btnCriarSala_MouseEnter(object sender, EventArgs e)
        {
            btnCriarSala.FlatAppearance.BorderColor = Color.FromArgb(255, 83, 79, 255);
        }
    }
}
