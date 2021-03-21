using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    class BladeKnight:DarkKnight
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public BladeKnight(string username, int level)
            :base(username,level)
        {

        }
    }
}
