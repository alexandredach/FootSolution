using FootProject;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamsManager.GiveCard(TeamChauneSurMarne.PlayersOnField, Card.Red, "Tarek", "TIFFIEH");
            Console.WriteLine();

            //TeamChauneSurMarne.GiveCard(Card.Red,"Tarek","TIFFIEH");

            //TeamChauneSurMarne.GiveCard(Card.Yellow, "Roger", "TROBU");
            //TeamChauneSurMarne.GiveCard(Card.Yellow, "Roger", "TROBU");

            //Console.WriteLine("NOUVELLE EQUIPE :");
            //TeamChauneSurMarne.DisplayTeamByList(Cities.ChauneSurMarne, TeamChauneSurMarne.PlayersOnField);

            //Console.WriteLine();
            //Console.WriteLine("Remplaçants :");
            //TeamChauneSurMarne.DisplayTeamByList(Cities.ChauneSurMarne, TeamChauneSurMarne.PlayersSubstitute);

            //Console.WriteLine();
            //Console.WriteLine("Exclus :");
            //TeamChauneSurMarne.DisplayTeamByList(Cities.ChauneSurMarne, TeamChauneSurMarne.PlayersSentOff);



        }
    }
}