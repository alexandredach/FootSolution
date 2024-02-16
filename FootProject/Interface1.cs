using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootProject
{
    internal interface ITeamManager
    {
        public void DisplayTeamByList(List<Player> listName);

        public void GiveCard(Card cardColor, string playerFirstName, string playerLastName);

        public void PlayerInjured(string playerFirstName, string playerLastName);

        public void ReplacePlayer(Player playerToReplace);
        
    }
}
