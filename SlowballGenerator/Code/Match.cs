using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlowballGenerator.Code
{
    public class Match
    {
        public Match()
        {
            Teams = new List<Team>();
        }

        public List<Team> Teams { get; set; }
        public string Name { get; set; }
    }
}