using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterSheet
{
    class Stats
    {
        private int strength, dexterity, constitution, intelligence, wisdom, charisma;
        private int strengthAdjustment, dexterityAdjustment, constitutionAdjustment, intelligenceAdjustment, wisdomAdjustment, charismaAdjustment;

        public Stats()
        {
            strength = 0;
            dexterity = 0;
            constitution = 0;
            intelligence = 0;
            wisdom = 0;
            charisma = 0;

            strengthAdjustment = 0;
            dexterityAdjustment = 0;
            constitutionAdjustment = 0;
            intelligenceAdjustment = 0;
            wisdomAdjustment = 0;
            charismaAdjustment = 0;
        }

        public List<int> getStats()
        {
            List<int> stats = new List<int>();

            stats.Add(strength);
            stats.Add(dexterity);
            stats.Add(constitution);
            stats.Add(intelligence);
            stats.Add(wisdom);
            stats.Add(charisma);

            stats.Add(strengthAdjustment);
            stats.Add(dexterityAdjustment);
            stats.Add(constitutionAdjustment);
            stats.Add(intelligenceAdjustment);
            stats.Add(wisdomAdjustment);
            stats.Add(charismaAdjustment);

            return stats;
        }
    }
}
