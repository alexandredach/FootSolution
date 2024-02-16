using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootProject
{
    internal class Teams
    {
        public static List<Player> PlayersOnField { get; set; }
        public static List<Player> PlayersSubstitute { get; set; }
        public static List<Player> PlayersSentOff { get; set; }

        // LISTE D'ATTENTE A FAIRE POUR MATCH SUIVANT SI BESOIN : les remplaçants entrent de suite dans la liste
        public Teams()
        {
            PlayersOnField = new List<Player>();
            PlayersSubstitute = new List<Player>();
            PlayersSentOff = new List<Player>();
        }

        
    }
}
