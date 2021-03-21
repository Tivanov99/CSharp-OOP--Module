using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    class SoulMaster: DarkWizard
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public SoulMaster(string username, int level)
            :base(username,level)
        {
            
        }
    }
}
