using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class MuseElf :Elf
    {
        public string Username { get; set; }
        public int Level { get; set; }
        public MuseElf(string username, int level)
            :base(username,level)
        {

        }
    }
}
