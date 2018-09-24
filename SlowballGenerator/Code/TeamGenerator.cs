using System;
using System.Collections.Generic;

namespace SlowballGenerator.Code
{
    public static class TeamGenerator
    {

        public static List<Team> GenerateTeams(List<Player> playerList, int nbrOfTeams)
        {
            List<Team> teams = new List<Team>();
            List<Player> players = new List<Player>(playerList);

            while (players.Count > 0)
            {
                Team team = new Team();
                bool pickNextPlayerinTeam = true;
                while (pickNextPlayerinTeam)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int randomPlayer = ThreadSafeRandom.ThisThreadsRandom.Next(0, players.Count - 1);
                        Player player = players[randomPlayer];
                        pickNextPlayerinTeam = CheckIfInSameTeamBefore();
                        team.Players.Add(player);
                        players.Remove(player);
                    }
                }
                team.Name = team.Players[0].Name + ", " + team.Players[1].Name;
                teams.Add(team);
            }

            //for (int i = 0; i < nbrOfTeams; i++)
            //{
                

            //    Team team = new Team();
            //    int randomPlayer = ThreadSafeRandom.ThisThreadsRandom.Next(0, players.Count - 1);
            //    Player player = players[randomPlayer];
            //    players.Remove(player);
            //    team.Players.Add(player);
            //    team.Name = team.Players[0].Name + ", " + team.Players[1].Name;
            //    teams.Add(team);
            //    int partnerRandomIntervall = ThreadSafeRandom.ThisThreadsRandom.Next(1, players.Count - 1);
            //    int nextPlayer = randomPlayer + partnerRandomIntervall;
            //    if (nextPlayer > players.Count - 1)
            //    {
            //        nextPlayer = ((partnerRandomIntervall + randomPlayer) - players.Count);
            //    }
            //    Player player2 = players[nextPlayer];
            //    team.Players.Add(player2);
            //    team.Name = player.Name + ", " + player2.Name;
            //    players.Remove(player2);
            //}

            return teams;
        }

        private static bool CheckIfInSameTeamBefore()
        {
            
        }
    }
}