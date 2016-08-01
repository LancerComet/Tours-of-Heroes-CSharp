using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_of_Heros
{
    class Hero
    {
        static private int idIndex = 1;
        private string _id;
        public string id {
            get
            {
                return _id;
            }
            set
            {
                _id = "hero_" + Hero.idIndex;
                Hero.idIndex++;
            }
        }
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
