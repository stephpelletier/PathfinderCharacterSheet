using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterSheet.Character.Statistics
{
    class Ability
    {
        private int score;
        private int modifier;
        private int tempAdjustment;
        private int tempModifier;

        public Ability(int abilityScore)
        {
            this.score = abilityScore;
            this.tempAdjustment = 0;
        }

        public Ability(int abilityScore, int temporaryAdjustment)
        {
            this.score = abilityScore;
            this.tempAdjustment = temporaryAdjustment;
        }

        private void calculateStats()
        {

        }
    }
}
