using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    class DarkWizard :Wizard
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public DarkWizard(string username, int level)
            :base(username,level)
        {

        }
    }
}
