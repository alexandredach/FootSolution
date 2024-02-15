using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootProject
{
    internal class TeamChauneSurMarne : TeamDataBase
    {
        public static List<Player> PlayersOnField = new List<Player>()
        {
            new Player(1 , "Alain", "PROVISTE", Cities.ChauneSurMarne, Status.On_Field),
            new Player(3 , "Tarek", "TIFFIEH", Cities.ChauneSurMarne, Status.On_Field),
            new Player(4 , "Guy", "LIGUILLI", Cities.ChauneSurMarne, Status.On_Field),
            new Player(7 , "Hal", "COLIK", Cities.ChauneSurMarne, Status.On_Field),
            new Player(8 , "Franck", "FORT", Cities.ChauneSurMarne, Status.On_Field),
            new Player(12 , "Sam", "AGACE", Cities.ChauneSurMarne, Status.On_Field),
            new Player(13 , "Roger", "TROBU", Cities.ChauneSurMarne, Status.On_Field),
            new Player(15 , "Gérard", "MANVUSSA", Cities.ChauneSurMarne, Status.On_Field),
            new Player(17 , "Andy", "SCOTEK", Cities.ChauneSurMarne, Status.On_Field),
            new Player(18 , "Basile", "HIC", Cities.ChauneSurMarne, Status.On_Field)
        };

        public static List<Player> PlayersSubstitute = new List<Player>()
        {
            new Player(2 , "Phil", "DEFER", Cities.ChauneSurMarne, Status.Substitute),
            new Player(5 , "Gaspard", "ALIZAN", Cities.ChauneSurMarne, Status.Substitute),
            new Player(6 , "Harry", "COBLAN", Cities.ChauneSurMarne, Status.Substitute),
            new Player(9 , "Axel", "HERRE", Cities.ChauneSurMarne, Status.Substitute),
            new Player(10 , "Lee", "BERTINE", Cities.ChauneSurMarne, Status.Substitute),
        };

        public static List<Player> PlayersSentOff = new List<Player>();

        // LISTE D'ATTENTE A FAIRE POUR MATCH SUIVANT SI BESOIN : les remplaçants entrent de suite dans la liste

        
    }
}
