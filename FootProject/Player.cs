using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootProject
{
    internal class Player
    {
        public int Number { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Cities CityName { get; set; }
        public int YellowCards { get; set; }
        public Status Status { get; set; }

        public Player(int initNumber, string initFirstName, string initLastName, Cities initCityName, Status initStatus)
        {
            Number = initNumber;
            FirstName = initFirstName;
            LastName = initLastName;
            CityName = initCityName;
            Status = initStatus;
            YellowCards = 0;
        }
    }
}
