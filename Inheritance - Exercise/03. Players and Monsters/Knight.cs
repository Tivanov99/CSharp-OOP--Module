using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    class Knight:Hero
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public Knight(string username, int level)
            :base(username,level)
        {

        }
    }
}
