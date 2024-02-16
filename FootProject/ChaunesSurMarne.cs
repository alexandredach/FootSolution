using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootProject
{
    internal class ChaunesSurMarne : Teams, ITeamManager
    {
        public ChaunesSurMarne()
        {
            PlayersOnField.Add(new Player(1, "Alain", "PROVISTE", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(3, "Tarek", "TIFFIEH", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(4, "Guy", "LIGUILLI", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(7, "Hal", "COLIK", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(8, "Franck", "FORT", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(12, "Sam", "AGACE", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(13, "Roger", "TROBU", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(15, "Gérard", "MANVUSSA", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(17, "Andy", "SCOTEK", Cities.ChauneSurMarne, Status.On_Field));
            PlayersOnField.Add(new Player(18, "Basile", "HIC", Cities.ChauneSurMarne, Status.On_Field));

            PlayersSubstitute.Add(new Player(2, "Phil", "DEFER", Cities.ChauneSurMarne, Status.Substitute));
            PlayersSubstitute.Add(new Player(5, "Gaspard", "ALIZAN", Cities.ChauneSurMarne, Status.Substitute));
            PlayersSubstitute.Add(new Player(6, "Harry", "COBLAN", Cities.ChauneSurMarne, Status.Substitute));
            PlayersSubstitute.Add(new Player(9, "Axel", "HERRE", Cities.ChauneSurMarne, Status.Substitute));
            PlayersSubstitute.Add(new Player(10, "Lee", "BERTINE", Cities.ChauneSurMarne, Status.Substitute));
        }

        public void DisplayTeamByList(List<Player> listName)
        {
            foreach (Player player in listName)
            {
                Console.WriteLine($"[{player.Number}] ({player.CityName}) {player.FirstName} {player.LastName} {player.YellowCards} {player.Status} ");
            }
        }

        public void GiveCard(Card cardColor, string playerFirstName, string playerLastName)
        {
            if (cardColor == Card.Red)
            {
                foreach (Player player in Teams.PlayersOnField)
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

        public void PlayerInjured(string playerFirstName, string playerLastName)
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

        public void ReplacePlayer(Player playerToReplace)
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
