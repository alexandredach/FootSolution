using System;
namespace FootProject
{
	internal class TeamsManager
	{


        public static void DisplayTeamByList(Cities cityName, List<Player> listName)
            {
                foreach (Player player in listName)
                {
                    if (player.CityName.Equals(cityName))
                        Console.WriteLine($"[{player.Number}] {player.FirstName} {player.LastName} {player.YellowCards} {player.Status} ");
                }
            }

        public static void GiveCard(TeamDataBase teamName, Card cardColor, string playerFirstName, string playerLastName)
        {
            if (cardColor == Card.Red)
            {
                foreach (Player player in teamName.PlayersOnField)
                    if (player.FirstName.Contains(playerFirstName) && player.LastName.Contains(playerLastName))
                    {
                        player.Status = Status.SentOff_Red_Card;
                        Console.WriteLine($"CARTON ROUGE ! {player.FirstName} {player.LastName} a été exclu !");
                        ReplacePlayer(teamName, player);
                        break;
                    }
            }
            else if (cardColor == Card.Yellow)
            {
                foreach (Player player in teamName.PlayersOnField)
                {
                    if (player.FirstName.Contains(playerFirstName) && player.LastName.Contains(playerLastName))
                    {
                        player.YellowCards++;
                        if (player.YellowCards >= 2)
                        {
                            player.Status = Status.SentOff_Yellow_Cards;
                            Console.WriteLine($"2 CARTONS JAUNES ! {player.FirstName} {player.LastName} a été exclu !");
                            ReplacePlayer(teamName, player);
                            break;
                        }
                    }
                }
            }
        }

        public static void PlayerInjured(TeamDataBase teamName, string playerFirstName, string playerLastName)
        {

            foreach (Player player in teamName.PlayersOnField)
                if (player.FirstName.Contains(playerFirstName) && player.LastName.Contains(playerLastName))
                {
                    player.Status = Status.Inured;
                    Console.WriteLine($"{player.FirstName} {player.LastName} s'est blessé et est sorti du terrain.");
                    ReplacePlayer(teamName, player);
                    break;
                }

        }
        
        public static void ReplacePlayer(TeamDataBase teamName, Player playerToReplace)
        {
            teamName.PlayersOnField.Remove(playerToReplace);
            teamName.PlayersSentOff.Add(playerToReplace);
            // je prends l'index d'un joueur de la liste des remplaçants aléatoirement ...
            int randomPlayerSubstitute = new Random().Next(0, teamName.PlayersSubstitute.Count);
            // ... pour l'ajouter à la liste des joueurs sur le terrain ...
            teamName.PlayersOnField.Add(teamName.PlayersSubstitute[randomPlayerSubstitute]);
            teamName.PlayersSubstitute[randomPlayerSubstitute].Status = Status.On_Field;
            // CONSOLE
            Console.WriteLine($"{teamName.PlayersSubstitute[randomPlayerSubstitute].FirstName} {teamName.PlayersSubstitute[randomPlayerSubstitute].LastName} est entré sur le terrain.");
            // ... et je le retire de la liste des remplaçants
            // CONSOLE
            Console.WriteLine($"{teamName.PlayersSubstitute[randomPlayerSubstitute].FirstName} {teamName.PlayersSubstitute[randomPlayerSubstitute].LastName} : sorti de la liste des remplaçants\n");
            teamName.PlayersSubstitute.RemoveAt(randomPlayerSubstitute);

        }
        
	}
}

