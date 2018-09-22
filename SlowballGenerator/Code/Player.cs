using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlowballGenerator.Code
{
    public class Player
    {
        public Player()
        {

        }

        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}