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

        public int[] getStats()
        {

            int[,] stats = new int[6,4];

            int abilityScoreColumn = 0;
            int abilityModifierColumn = 1;
            int temporaryScoreAdjustmentColumn = 2;
            int temporaryModifierColumn = 3;

            for(int row = 0; row < 6; row++)
            {

            }

            return stats;
        }
    }
}
