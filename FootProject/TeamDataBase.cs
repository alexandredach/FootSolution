using System;
namespace FootProject
{
	internal class TeamDataBase
	{
        public List<Player> PlayersOnField { get; set; }
        public List<Player> PlayersSubstitute { get; set; }
        public List<Player> PlayersSentOff { get; set; }
    }
}

