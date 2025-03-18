using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingMeClient
{
    public class Bot : Player
    {
        private event Action SetupTurn;
        private event Action PromoteTurn;
        private event Action VoteTurn;

        private Table table;
        private Room room;

        public Bot(Player player, Room room, Table table)
        {
            this.id = player.Id;
            this.name = player.Name;
            this.password = player.Password;
            this.score = player.Score;
            
            this.room = room;
            this.table = table;

            this.SetupTurn += OnSetupTurn;
            this.PromoteTurn += OnPromoteTurn;
            this.VoteTurn += OnVoteTurn;
        }

        private void OnSetupTurn()
        {
            // Setup
        }

        private void OnPromoteTurn() { 
            // Promote
        }

        private void OnVoteTurn()
        {
            // Vote
        }

        public void Handle()
        {
            this.table.Update();
            if (this.table.turnID != this.id)
                return;

            switch (this.table.phase)
            {
                case 'S':
                    this.SetupTurn.Invoke();
                    break;
                case 'P':
                    this.PromoteTurn.Invoke(); ;
                    break;
                case 'V':
                    this.VoteTurn.Invoke();
                    break;
            }
        }
    }
}
