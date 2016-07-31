using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tours_of_Heros
{
    class HeroesService
    {
        private static Hero[] _heroes = {
            new Hero("Lancer", "Comet", 5),
            new Hero("Caps", "Locker", 1),
            new Hero("Helcus", "God", 99)
        };
        
        public static Hero[] heroes
        {
            get
            {
                return _heroes;
            }
            set
            {
                _heroes = value;
            }
        }

        public static Hero[] topHeroes ()
        {
            Hero[] result = heroLevelSort(heroes);
            return result;
        }

        private static int index = 0;
        private static Hero[] heroLevelSort (Hero[] heroesArr)
        {
            var tempArr = heroesArr;
            for (int i = 1; i < tempArr.Length; i++)
            {
                if (tempArr[i - 1].level < tempArr[i].level)
                {
                    var temp = tempArr[i];
                    tempArr[i] = tempArr[i - 1];
                    tempArr[i - 1] = temp;
                }
            }
            HeroesService.index++;
            if (HeroesService.index < tempArr.Length)
            {
                HeroesService.heroLevelSort(tempArr);
            } else
            {
                HeroesService.index = 0;
            }
            return tempArr;
        }
    }
}
