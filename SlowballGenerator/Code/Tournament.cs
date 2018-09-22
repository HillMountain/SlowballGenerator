using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlowballGenerator.Code
{
    public class Tournament
    {
        public Tournament(int stages)
        {
            Stages = stages;
            Rounds = new List<TournamentRound>();
        }

        public int Stages { get; set; }
        public List<TournamentRound> Rounds { get; set; }
    }
}