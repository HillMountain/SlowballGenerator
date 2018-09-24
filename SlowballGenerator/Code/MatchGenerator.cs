using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlowballGenerator.Code
{
    public static class MatchGenerator
    {
        public static List<Match> GenerateMatches(List<Team> teams, int nbrOfMatches)
        {
            List<Match> matches = new List<Match>();

            for (int i = 0; i < nbrOfMatches; i++)
            {
                Match match = new Match();
                for (int j = 0; j < 2; j++)
                {
                    int rndTeam = ThreadSafeRandom.ThisThreadsRandom.Next(0, teams.Count);
                    match.Teams.Add(teams[rndTeam]);
                    teams.RemoveAt(rndTeam);
                }
                match.Name = match.Teams[0].Name + " vs " + match.Teams[1].Name;
                matches.Add(match);
            }


            return matches;
        }
    }
}