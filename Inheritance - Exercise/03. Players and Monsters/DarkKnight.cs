using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    class DarkKnight:Knight
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public DarkKnight(string username, int level)
            :base(username,level)
        {

        }
    }
}
