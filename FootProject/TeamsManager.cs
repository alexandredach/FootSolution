using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FootProject
{
    internal class TeamsManager
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
            new Player(18 , "Basile", "HIC", Cities.ChauneSurMarne, Status.On_Field),

            new Player(1 , "Kylian", "MBAPPE", Cities.Paris, Status.On_Field),
            new Player(3 , "Ousmane", "DEMBELE", Cities.Paris, Status.On_Field),
            new Player(4 , "Marco", "ASENSIO", Cities.Paris, Status.On_Field),
            new Player(7 , "Randal", "KOLO MUANI", Cities.Paris, Status.On_Field),
            new Player(8 , "Bryan", "BARCOLA", Cities.Paris, Status.On_Field),
            new Player(12 , "Achraf", "HAKIMI", Cities.Paris, Status.On_Field),
            new Player(13 , "Mauricio", "UGARTE", Cities.Paris, Status.On_Field),
            new Player(15 , "Lucas", "HERNANDEZ", Cities.Paris, Status.On_Field),
            new Player(17 , "Thimotée", "PEMBELE", Cities.Paris, Status.On_Field),
            new Player(18 , "Arnau", "TENAS", Cities.Paris, Status.On_Field)
        };

        public static List<Player> PlayersSubstitute = new List<Player>()
        {
            new Player(2 , "Phil", "DEFER", Cities.ChauneSurMarne, Status.Substitute),
            new Player(5 , "Gaspard", "ALIZAN", Cities.ChauneSurMarne, Status.Substitute),
            new Player(6 , "Harry", "COBLAN", Cities.ChauneSurMarne, Status.Substitute),
            new Player(9 , "Axel", "HERRE", Cities.ChauneSurMarne, Status.Substitute),
            new Player(10 , "Lee", "BERTINE", Cities.ChauneSurMarne, Status.Substitute),

            new Player(2 , "Keylor", "NAVAS", Cities.Paris, Status.Substitute),
            new Player(5 , "Sergio", "RICO", Cities.Paris, Status.Substitute),
            new Player(6 , "Nordi", "MUKIELE", Cities.Paris, Status.Substitute),
            new Player(9 , "Carlos", "SOLER", Cities.Paris, Status.Substitute),
            new Player(10 , "Thilo", "KEHRER", Cities.Paris, Status.Substitute)
        };

        public static List<Player> PlayersSentOff = new List<Player>();

        // LISTE D'ATTENTE A FAIRE POUR MATCH SUIVANT SI BESOIN : les remplaçants entrent de suite dans la liste

        public static void DisplayTeamByList(Cities cityName, List<Player> listName)
        {
            foreach (Player player in listName)
            {
                if (player.CityName.Equals(cityName))
                    Console.WriteLine($"[{player.Number}] ({player.CityName}) {player.FirstName} {player.LastName} {player.YellowCards} {player.Status} ");
            }
        }

        public static void GiveCard(Card cardColor, string playerFirstName, string playerLastName)
        {
            if (cardColor == Card.Red)
            {
                foreach (Player player in PlayersOnField)
                    if (player.FirstName.Contains(playerFirstName) && player.LastName.Contains(playerLastName))
                    {
                        player.Status = Status.SentOff_Red_Card;
                        Console.WriteLine($"CARTON ROUGE ! {player.FirstName} {player.LastName} a été exclu !");
                        ReplacePlayer(player);
                        break;
                    }
            }
            else if (cardColor == Card.Yellow)
            {
                foreach (Player player in PlayersOnField)
                {
                    if (player.FirstName.Contains(playerFirstName) && player.LastName.Contains(playerLastName))
                    {
                        player.YellowCards++;
                        if (player.YellowCards >= 2)
                        {
                            player.Status = Status.SentOff_Yellow_Cards;
                            Console.WriteLine($"2 CARTONS JAUNES ! {player.FirstName} {player.LastName} a été exclu !");
                            ReplacePlayer(player);
                            break;
                        }
                    }
                }
            }
        }

        public static void PlayerInjured(string playerFirstName, string playerLastName)
        {

            foreach (Player player in PlayersOnField)
                if (player.FirstName.Contains(playerFirstName) && player.LastName.Contains(playerLastName))
                {
                    player.Status = Status.Inured;
                    Console.WriteLine($"{player.FirstName} {player.LastName} s'est blessé et est sorti du terrain.");
                    ReplacePlayer(player);
                    break;
                }

        }

        public static void ReplacePlayer(Player playerToReplace)
        {
            PlayersOnField.Remove(playerToReplace);

            PlayersSentOff.Add(playerToReplace);
            // je prends l'index d'un joueur de la liste des remplaçants aléatoirement ...

            int randomPlayerSubstitute = new Random().Next(0, PlayersSubstitute.Count);
            // ... pour l'ajouter à la liste des joueurs sur le terrain ...
            PlayersOnField.Add(PlayersSubstitute[randomPlayerSubstitute]);
            PlayersSubstitute[randomPlayerSubstitute].Status = Status.On_Field;
            // CONSOLE
            Console.WriteLine($"{PlayersSubstitute[randomPlayerSubstitute].FirstName} {PlayersSubstitute[randomPlayerSubstitute].LastName} est entré sur le terrain.");
            // ... et je le retire de la liste des remplaçants
            // CONSOLE
            Console.WriteLine($"{PlayersSubstitute[randomPlayerSubstitute].FirstName} {PlayersSubstitute[randomPlayerSubstitute].LastName} : sorti de la liste des remplaçants\n");
            PlayersSubstitute.RemoveAt(randomPlayerSubstitute);

        }
    }
}
