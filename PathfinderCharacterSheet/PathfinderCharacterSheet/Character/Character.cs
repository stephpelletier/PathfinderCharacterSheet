using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterSheet
{
    class Character
    {
        private Stats stats;

        public Character()
        {
            stats = new Stats();
        }

        public StatsDTO getStats()
        {
            return stats.getAllStats();
        }

    }
}
