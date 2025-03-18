namespace KingMeClient
{
    partial class LobbyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCreateRoom = new System.Windows.Forms.Panel();
            this.btnCriarSala = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewSalaSenha = new System.Windows.Forms.TextBox();
            this.txtNewSalaNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.tmrRefreshLobby = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.lstPlayers = new System.Windows.Forms.ListBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlLastJoinInfo = new System.Windows.Forms.Panel();
            this.lblLastRoomStatus = new System.Windows.Forms.Label();
            this.lblLastUserID = new System.Windows.Forms.Label();
            this.lblLastUserPassword = new System.Windows.Forms.Label();
            this.lblLastUsername = new System.Windows.Forms.Label();
            this.txtSearchRoom = new System.Windows.Forms.TextBox();
            this.panelCreateRoom.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLastJoinInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCreateRoom
            // 
            this.panelCreateRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCreateRoom.Controls.Add(this.btnCriarSala);
            this.panelCreateRoom.Controls.Add(this.label4);
            this.panelCreateRoom.Controls.Add(this.txtNewSalaSenha);
            this.panelCreateRoom.Controls.Add(this.txtNewSalaNome);
            this.panelCreateRoom.Controls.Add(this.label2);
            this.panelCreateRoom.Controls.Add(this.label1);
            this.panelCreateRoom.Location = new System.Drawing.Point(32, 188);
            this.panelCreateRoom.Name = "panelCreateRoom";
            this.panelCreateRoom.Size = new System.Drawing.Size(194, 219);
            this.panelCreateRoom.TabIndex = 0;
            // 
            // btnCriarSala
            // 
            this.btnCriarSala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarSala.ForeColor = System.Drawing.Color.White;
            this.btnCriarSala.Location = new System.Drawing.Point(62, 171);
            this.btnCriarSala.Name = "btnCriarSala";
            this.btnCriarSala.Size = new System.Drawing.Size(74, 23);
            this.btnCriarSala.TabIndex = 7;
            this.btnCriarSala.Text = "Criar";
            this.btnCriarSala.UseVisualStyleBackColor = true;
            this.btnCriarSala.Click += new System.EventHandler(this.btnCriarSala_Click);
            this.btnCriarSala.MouseEnter += new System.EventHandler(this.btnCriarSala_MouseEnter);
            this.btnCriarSala.MouseLeave += new System.EventHandler(this.btnCriarSala_MouseLeave);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Criar Sala";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNewSalaSenha
            // 
            this.txtNewSalaSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtNewSalaSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNewSalaSenha.ForeColor = System.Drawing.Color.White;
            this.txtNewSalaSenha.Location = new System.Drawing.Point(22, 113);
            this.txtNewSalaSenha.Name = "txtNewSalaSenha";
            this.txtNewSalaSenha.Size = new System.Drawing.Size(77, 23);
            this.txtNewSalaSenha.TabIndex = 4;
            // 
            // txtNewSalaNome
            // 
            this.txtNewSalaNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtNewSalaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNewSalaNome.ForeColor = System.Drawing.Color.White;
            this.txtNewSalaNome.Location = new System.Drawing.Point(20, 66);
            this.txtNewSalaNome.MaxLength = 20;
            this.txtNewSalaNome.Name = "txtNewSalaNome";
            this.txtNewSalaNome.Size = new System.Drawing.Size(116, 23);
            this.txtNewSalaNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(356, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 111);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Novo Jogador";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(20, 66);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(119, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome de Usuário";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstRooms
            // 
            this.lstRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lstRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstRooms.ForeColor = System.Drawing.Color.White;
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 16;
            this.lstRooms.Location = new System.Drawing.Point(521, 63);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(267, 308);
            this.lstRooms.TabIndex = 3;
            this.lstRooms.SelectedIndexChanged += new System.EventHandler(this.lstRooms_SelectedIndexChanged);
            // 
            // tmrRefreshLobby
            // 
            this.tmrRefreshLobby.Enabled = true;
            this.tmrRefreshLobby.Interval = 800;
            this.tmrRefreshLobby.Tick += new System.EventHandler(this.tmrRefreshLobby_Tick);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "1 Click = Server Info, 2 Clicks = Entrar:";
            // 
            // lstPlayers
            // 
            this.lstPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.lstPlayers.ForeColor = System.Drawing.Color.White;
            this.lstPlayers.FormattingEnabled = true;
            this.lstPlayers.Items.AddRange(new object[] {
            "Jogadores"});
            this.lstPlayers.Location = new System.Drawing.Point(400, 211);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(115, 160);
            this.lstPlayers.TabIndex = 6;
            this.lstPlayers.SelectedIndexChanged += new System.EventHandler(this.lstPlayers_SelectedIndexChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblVersion.Location = new System.Drawing.Point(616, 426);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(139, 16);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "🌐 DLL VERSION";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(614, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "⚔️ Senhores de Kent ⚔️";
            // 
            // pnlLastJoinInfo
            // 
            this.pnlLastJoinInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.pnlLastJoinInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLastJoinInfo.Controls.Add(this.lblLastRoomStatus);
            this.pnlLastJoinInfo.Controls.Add(this.lblLastUserID);
            this.pnlLastJoinInfo.Controls.Add(this.lblLastUserPassword);
            this.pnlLastJoinInfo.Controls.Add(this.lblLastUsername);
            this.pnlLastJoinInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlLastJoinInfo.Name = "pnlLastJoinInfo";
            this.pnlLastJoinInfo.Size = new System.Drawing.Size(256, 65);
            this.pnlLastJoinInfo.TabIndex = 9;
            // 
            // lblLastRoomStatus
            // 
            this.lblLastRoomStatus.AutoSize = true;
            this.lblLastRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblLastRoomStatus.Location = new System.Drawing.Point(9, 50);
            this.lblLastRoomStatus.Name = "lblLastRoomStatus";
            this.lblLastRoomStatus.Size = new System.Drawing.Size(74, 13);
            this.lblLastRoomStatus.TabIndex = 3;
            this.lblLastRoomStatus.Text = "Jogando em...";
            this.lblLastRoomStatus.Click += new System.EventHandler(this.lblLastRoomStatus_Click);
            // 
            // lblLastUserID
            // 
            this.lblLastUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblLastUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(79)))), ((int)(((byte)(255)))));
            this.lblLastUserID.Location = new System.Drawing.Point(3, 10);
            this.lblLastUserID.Name = "lblLastUserID";
            this.lblLastUserID.Size = new System.Drawing.Size(38, 32);
            this.lblLastUserID.TabIndex = 2;
            this.lblLastUserID.Text = "1";
            this.lblLastUserID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastUserPassword
            // 
            this.lblLastUserPassword.AutoSize = true;
            this.lblLastUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblLastUserPassword.Location = new System.Drawing.Point(47, 25);
            this.lblLastUserPassword.Name = "lblLastUserPassword";
            this.lblLastUserPassword.Size = new System.Drawing.Size(53, 13);
            this.lblLastUserPassword.TabIndex = 1;
            this.lblLastUserPassword.Text = "Password";
            // 
            // lblLastUsername
            // 
            this.lblLastUsername.AutoSize = true;
            this.lblLastUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLastUsername.Location = new System.Drawing.Point(47, 10);
            this.lblLastUsername.Name = "lblLastUsername";
            this.lblLastUsername.Size = new System.Drawing.Size(65, 15);
            this.lblLastUsername.TabIndex = 0;
            this.lblLastUsername.Text = "Username";
            // 
            // txtSearchRoom
            // 
            this.txtSearchRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.txtSearchRoom.ForeColor = System.Drawing.Color.White;
            this.txtSearchRoom.Location = new System.Drawing.Point(521, 377);
            this.txtSearchRoom.Name = "txtSearchRoom";
            this.txtSearchRoom.Size = new System.Drawing.Size(157, 20);
            this.txtSearchRoom.TabIndex = 10;
            this.txtSearchRoom.TextChanged += new System.EventHandler(this.txtSearchRoom_TextChanged);
            // 
            // LobbyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchRoom);
            this.Controls.Add(this.pnlLastJoinInfo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lstPlayers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCreateRoom);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 489);
            this.Name = "LobbyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingMe";
            this.panelCreateRoom.ResumeLayout(false);
            this.panelCreateRoom.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlLastJoinInfo.ResumeLayout(false);
            this.pnlLastJoinInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCreateRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewSalaSenha;
        private System.Windows.Forms.TextBox txtNewSalaNome;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCriarSala;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.Timer tmrRefreshLobby;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstPlayers;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlLastJoinInfo;
        private System.Windows.Forms.Label lblLastUserID;
        private System.Windows.Forms.Label lblLastUserPassword;
        private System.Windows.Forms.Label lblLastUsername;
        private System.Windows.Forms.Label lblLastRoomStatus;
        private System.Windows.Forms.TextBox txtSearchRoom;
    }
}