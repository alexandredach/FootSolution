using FootProject;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamsManager.DisplayTeamByList(Cities.ChauneSurMarne, TeamsManager.PlayersOnField);
            Console.WriteLine();

            TeamsManager.GiveCard(Card.Red, "Tarek", "TIFFIEH");

            TeamsManager.GiveCard(Card.Yellow, "Roger", "TROBU");
            TeamsManager.GiveCard(Card.Yellow, "Roger", "TROBU");

            Console.WriteLine("NOUVELLE EQUIPE :");
            TeamsManager.DisplayTeamByList(Cities.ChauneSurMarne, TeamsManager.PlayersOnField);

            Console.WriteLine();
            Console.WriteLine("Remplaçants :");
            TeamsManager.DisplayTeamByList(Cities.ChauneSurMarne, TeamsManager.PlayersSubstitute);

            Console.WriteLine();
            Console.WriteLine("Exclus :");
            TeamsManager.DisplayTeamByList(Cities.ChauneSurMarne, TeamsManager.PlayersSentOff);



        }
    }
}