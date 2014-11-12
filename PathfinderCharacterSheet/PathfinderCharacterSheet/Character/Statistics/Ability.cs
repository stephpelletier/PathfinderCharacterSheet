using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterSheet
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

            calculateStats();
        }

        public Ability(int abilityScore, int temporaryAdjustment)
        {
            this.score = abilityScore;
            this.tempAdjustment = temporaryAdjustment;

            calculateStats();
        }

        private void calculateStats()
        {
            double tempScore = score - 10;
            modifier = (int)Math.Floor(tempScore/2);
            tempModifier = (int)Math.Floor((tempScore + tempModifier)/2);
        }

        public void setScore(int newScore)
        {
            this.score = newScore;
            calculateStats();
        }

        public void setTemporaryAdjustment(int newTempAdjustment)
        {
            this.tempAdjustment = newTempAdjustment;
            calculateStats();
        }

        public int getScore()
        {
            return score;
        }

        public int getModifier()
        {
            return modifier;
        }

        public int getTemporaryAdjustment()
        {
            return tempAdjustment;
        }

        public int getTemporaryModifier()
        {
            return tempModifier;
        }
    }
}
