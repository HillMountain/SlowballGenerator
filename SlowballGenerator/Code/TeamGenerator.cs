using System.Collections.Generic;

namespace SlowballGenerator.Code
{
    public static class TeamGenerator
    {

        public static List<Team> GenerateTeams(int partnerRandomStart, int partnerRandomIntervall, List<Player> players, int nbrOfTeams)
        {
            List<Team> teams = new List<Team>();

            for (int i = 0; i < nbrOfTeams; i++)
            {
                int nextPlayer = partnerRandomStart + partnerRandomIntervall;
                if(nextPlayer > players.Count-1)
                {
                    nextPlayer = ((partnerRandomIntervall + partnerRandomStart) - players.Count);
                }
                if(partnerRandomStart > players.Count -1)
                {
                    partnerRandomStart = 0;
                }

                Team team = new Team();
                Player player1 = players[partnerRandomStart];
                Player player2 = players[nextPlayer];
                team.Players.Add(player1);
                team.Players.Add(player2);
                team.Name = player1.Name + ", " + player2.Name;
                teams.Add(team);

                partnerRandomStart++;
            }
            return teams;
        }
    }
}