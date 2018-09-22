using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlowballGenerator.Code
{
    public class Tournament
    {
        public Tournament(int rounds)
        {
            Rounds = rounds;
            Teams = new List<Team>[rounds]; 
        }

        public int Rounds { get; set; }
        public List<Team>[] Teams { get; set; }
    }
}