using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
   public class Elf :Hero
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public Elf(string username, int level)
            :base(username,level)
        {

        }
    }
}
