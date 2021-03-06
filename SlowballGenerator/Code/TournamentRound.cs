﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlowballGenerator.Code
{
    public class TournamentRound
    {
        public TournamentRound(string name)
        {
            Name = name;
            Teams = new List<Team>();
            Matches = new List<Match>();
        }

        public string Name { get; set; }
        public List<Team> Teams { get; set; }
        public List<Match> Matches { get; set; }

    }
}