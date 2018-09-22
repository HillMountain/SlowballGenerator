using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlowballGenerator.Code
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }

        public Team(List<Player> players)
        {
            Players = players;
        }

        public List<Player> Players { get; set; }
        public string Name { get; set; }
    }
}