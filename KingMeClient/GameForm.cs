using KingMeServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KingMeClient
{
    public partial class GameForm : Form
    {

        Player player;
        Room room;
        Table table;
        Dictionary<int, Label[]> boardUI;
        char lastClickedPers = ' ';
        int lastTurnPlayerID=-1;

        public GameForm(Room room, Player myPlayer)
        {
            InitializeComponent();
            this.room = room;
            this.player = myPlayer;
            this.table = new Table(this.room);

            lblUsername.Text = this.player.Name;
            lblPhase.Text = "";
            lblTurn.Text = "";

            lblVersion.Text = $"🌐 DLL {Jogo.versao}";

            SetupBoardUI();
            tmrRefreshGame_Tick(null, null);
            //lblPlayerCard.Text = string.Join(",", this.player.Card);
        }

        void SetupBoardUI()
        {
            this.boardUI = new Dictionary<int, Label[]>();
            this.boardUI.Add(0, new Label[] { lblPawn00, lblPawn01, lblPawn02 });
            this.boardUI.Add(1, new Label[] { lblPawn10, lblPawn11, lblPawn12, lblPawn13 });
            this.boardUI.Add(2, new Label[] { lblPawn20, lblPawn21, lblPawn22, lblPawn23 });
            this.boardUI.Add(3, new Label[] { lblPawn30, lblPawn31, lblPawn32, lblPawn33 });
            this.boardUI.Add(4, new Label[] { lblPawn40, lblPawn41, lblPawn42, lblPawn43 });
            this.boardUI.Add(5, new Label[] { lblPawn50, lblPawn51, lblPawn52, lblPawn53 });
            this.boardUI.Add(10, new Label[] { lblPawn100 });
        }

        void lblPawns_Paint(object sender, PaintEventArgs e) {
            ControlPaint.DrawBorder(e.Graphics, ((Label)sender).DisplayRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void tmrRefreshGame_Tick(object sender, EventArgs e)
        {
            this.table.Update();
            char roomStatus = room.Status;
            btnStartGame.Visible = (roomStatus == 'A');
            List<RoomPlayer> roomPlayers = this.room.Players;

            // Update phase label
            switch (this.table.phase)
            {
                case 'S':
                    lblPhase.Text = "Setup";
                    break;
                case 'P':
                    lblPhase.Text = "Promoção";
                    break;
                case 'V':
                    lblPhase.Text = "Votação";
                    break;
                case 'E':
                    lblPhase.Text = "Encerrado";
                    break;
                default:
                    lblPhase.Text = "";
                    break;
            }

            lblPhase.Text += $" {this.table.round}/3";

            // Update leaderboard label
            lblLeaderboard.Text = "";
            foreach (RoomPlayer p in roomPlayers)
            {
                lblLeaderboard.Text += $"{p.Name}  {p.Score}\r\n";
            }

            if (this.table.phase == 'E')
            {
                lblWinner.Visible = true;
                lblWinner.Text = $"{roomPlayers[0].Name} é o Vencedor!";
                lblPlayerCard.Text = "Jogo Encerrado";
            }

            // Some depending of phase features
            pnlVote.Visible = this.table.phase == 'V' && this.table.turnID == this.player.Id;
            lstPersToChoose.Enabled = this.table.phase == 'S' && this.table.turnID == this.player.Id;

            if (roomStatus == 'A' || this.table.phase == 'E')
                return;

            if (pnlVote.Visible)
            {
                lblVoteTitle.Text = $"{API.GetCharacterNameByLetter(this.table.board[10][0]).Split(' ')[0]} é um bom Rei?";
            }

            // -=-=-=-==-=- Only update under if turn id changed -=-=-==--=-=--=-
            if (table.turnID == this.lastTurnPlayerID)
            {
                return;
            }
            this.lastTurnPlayerID = table.turnID;

            // Update board UI
            foreach (int sector in this.table.board.Keys)
            {
                string chars = this.table.board[sector];
                for (int i=0; i<this.boardUI[sector].Length; i++)
                {
                    if (i >= chars.Length)
                    {
                        this.boardUI[sector][i].Text = "";
                    }
                    else
                    {
                        this.boardUI[sector][i].Text = chars[i].ToString();
                    }
                }
            }

            // Show card
            lblPlayerCard.Text = string.Join("", this.player.Card); // string.Join(",", this.player.Card)

            // Update characters list
            lstPersToChoose.Items.Clear();
            lstPersToChoose.Items.AddRange(this.table.charactersOutOfBoard.ToArray());

            // Update turn label
            if (this.table.turnID == this.player.Id)
            {
                lblTurn.Text = "Sua Vez! :)";
            }
            else
            {
                RoomPlayer p = this.room.GetPlayer(this.table.turnID);
                if (p != null)
                    lblTurn.Text = $"Vez de {p.Name}";
                //foreach(RoomPlayer p in roomPlayers)
                //{
                //    if (this.table.turnID == p.Id)
                //    {
                //        lblTurn.Text = $"Vez de {p.Name}";
                //        break;
                //    }
                //}
            }
        }

        // -=-=-=-==-=- start game -=-=-==--=-=--=-
        private void btnStartGame_Click(object sender, EventArgs e) 
        {
            //check if the game can be started
            if (!this.player.StartGame())
                return;

            btnStartGame.Visible = false; 
        }

        // -=-=-=-==-=- last character choosed -=-=-==--=-=--=-
        private void lstPersToChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            //check if the index is valid
            if (lstPersToChoose.SelectedIndex < 0)
                return;
            this.lastClickedPers = lstPersToChoose.SelectedItem.ToString().ToUpper()[0];
        }

        // -=-=-=-==-=- position for last character -=-=-==--=-=--=-
        private void pnlSector_Clicked(object sender, EventArgs e)
        {
            int targetSector = Convert.ToInt32(((Panel)sender).Name.Replace("pnlSector", ""));
            if (this.table.phase != 'S' || this.table.turnID != this.player.Id || (targetSector < 1 || targetSector > 4))
                return;
            if (this.lastClickedPers == ' ')
            {
                MessageBox.Show("Por favor escolha um personagem da lista para colocar", "Error");
                return;
            }

            if (!this.player.PutCharacter(targetSector, this.lastClickedPers.ToString()))
                return;
            this.lastClickedPers = ' ';
        }

        // -=-=-=-==-=- promote character -=-=-==--=-=--=-
        private void lblPawn_Clicked(object sender, EventArgs e)
        {
            Label target = (Label)sender;
            if (this.table.phase != 'P' || this.table.turnID != this.player.Id || target.Text.Trim() == "")
                return;

            this.player.PromoteCharacter(target.Text.ToUpper());

        }

        // -=-=-=-==-=- vote -=-=-==--=-=--=-
        private void btnVote_Clicked(object sender, EventArgs e)
        {
            this.player.Vote(((Button)sender).Text.ToUpper()[0].ToString());
        }
    }
}
