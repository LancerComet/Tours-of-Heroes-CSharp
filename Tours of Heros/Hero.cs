using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_of_Heros
{
    class Hero
    {
        public Hero (string firstname, string lastname, int level)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.level = level;
        }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string fullname
        {
            get
            {
                return firstname + " " + lastname;
            }
        }
        public int level;
        public void levelup ()
        {
            level++;
        }
    }
}
