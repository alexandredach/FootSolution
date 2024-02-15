using FootProject;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teams.DisplayTeamByList(Cities.ChauneSurMarne, Teams.PlayersOnField);
            Console.WriteLine();

            Teams.GiveCard(Card.Red,"Tarek","TIFFIEH");

            Teams.GiveCard(Card.Yellow, "Roger", "TROBU");
            Teams.GiveCard(Card.Yellow, "Roger", "TROBU");

            Console.WriteLine("NOUVELLE EQUIPE :");
            Teams.DisplayTeamByList(Cities.ChauneSurMarne, Teams.PlayersOnField);

            Console.WriteLine();
            Console.WriteLine("Remplaçants :");
            Teams.DisplayTeamByList(Cities.ChauneSurMarne, Teams.PlayersSubstitute);

            Console.WriteLine();
            Console.WriteLine("Exclus :");
            Teams.DisplayTeamByList(Cities.ChauneSurMarne, Teams.PlayersSentOff);



        }
    }
}