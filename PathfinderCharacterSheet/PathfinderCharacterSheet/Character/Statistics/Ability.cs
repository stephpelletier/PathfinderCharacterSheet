using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterSheet
{
    public class Ability
    {
        private int score = 0;
        private int modifier = 0;
        private int tempAdjustment = 0;
        private int tempModifier = 0;

        public Ability(int abilityScore)
        {
            setupAbility(abilityScore, 0);
        }

        public Ability(int abilityScore, int temporaryAdjustment)
        {
            setupAbility(abilityScore, temporaryAdjustment);
        }

        private void setupAbility(int abilityScore, int temporaryAdjustment)
        {
            setScore(abilityScore);
            setTemporaryAdjustment(temporaryAdjustment);
        }

        public void setScore(int newScore)
        {
            if (newScore < 0)
                score = 0;
            else
                this.score = newScore;
            calculateStats();
        }

        public void setTemporaryAdjustment(int newTempAdjustment)
        {
            this.tempAdjustment = newTempAdjustment;
            calculateStats();
        }

        private void calculateStats()
        {
            double tempScore = score - 10;
            modifier = (int)Math.Floor(tempScore / 2);
            tempModifier = (int)Math.Floor((tempScore + tempAdjustment) / 2);
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
