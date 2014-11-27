using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PathfinderCharacterSheet;

namespace PathfinderCharacterSheetTest.Character.Statistics
{
    [TestClass]
    public class AbilityTest
    {
        [TestMethod]
        public void AssertDefaultValueOfTheVariable()
        {
            int DEFAULT_SCORE = 0;
            int DEFAULT_MODIFIER = -5;

            Ability ability = new Ability(DEFAULT_SCORE);
            Assert.AreEqual(DEFAULT_SCORE, ability.getScore());
            Assert.AreEqual(DEFAULT_MODIFIER, ability.getModifier());
            Assert.AreEqual(DEFAULT_SCORE, ability.getTemporaryAdjustment());
            Assert.AreEqual(DEFAULT_MODIFIER, ability.getTemporaryModifier());
        }

        [TestMethod]
        public void AssertScoreNotLowerThanZero()
        {
            int LOWER_THAN_ZERO_SCORE = -5;
            int LOWEST_SCORE_POSSIBLE = 0;

            Ability ability = new Ability(LOWER_THAN_ZERO_SCORE);

            Assert.AreEqual(LOWEST_SCORE_POSSIBLE, ability.getScore());
        }

        [TestMethod]
        public void AssertCalculateStatsOutputProperModifier()
        {
            int DEFAULT_SCORE = 12;
            int EXPECTED_MODIFIER = 1;

            Ability ability = new Ability(DEFAULT_SCORE);

            Assert.AreEqual(EXPECTED_MODIFIER, ability.getModifier());
            Assert.AreEqual(EXPECTED_MODIFIER, ability.getTemporaryModifier());
        }

        [TestMethod]
        public void AssertTemporaryAdjustmentCalculateProperly()
        {
            int DEFAULT_SCORE = 11;
            int TEMPORARY_ADJUSTMENT = -2;
            int EXPECTED_TEMPORARY_MODIFIER = -1;

            Ability ability = new Ability(DEFAULT_SCORE, TEMPORARY_ADJUSTMENT);

            Assert.AreEqual(EXPECTED_TEMPORARY_MODIFIER, ability.getTemporaryModifier());
        }
    }
}
