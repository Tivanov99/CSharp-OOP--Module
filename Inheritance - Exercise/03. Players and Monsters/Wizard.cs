using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    class Wizard: Hero
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public Wizard(string username, int level)
            :base(username,level)
        {

        }
    }
}
