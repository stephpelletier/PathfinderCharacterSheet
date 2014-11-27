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
    public class StatsTest
    {
        [TestMethod]
        public void AssertStatsDTOValueGenerateProperly()
        {
            Stats stats = new Stats();

            Assert.AreEqual(DefaultDTOValueExpected(), stats.getAllStats());
        }

        private StatsDTO DefaultDTOValueExpected()
        {
            StatsDTO expectedDTO = new StatsDTO();

            expectedDTO.strenghtScore = 0;
            expectedDTO.strenghtModifier = -5;
            expectedDTO.strenghtTempAdjustment = 0;
            expectedDTO.strenghtTempModifier = -5;

            expectedDTO.constitutionScore = 0;
            expectedDTO.constitutionModifier = -5;
            expectedDTO.constitutionTempAdjustment = 0;
            expectedDTO.constitutionTempModifier = -5;

            expectedDTO.dexterityScore = 0;
            expectedDTO.dexterityModifier = -5;
            expectedDTO.dexterityTempAdjustment = 0;
            expectedDTO.dexterityTempModifier = -5;

            expectedDTO.intelligenceScore = 0;
            expectedDTO.intelligenceModifier = -5;
            expectedDTO.intelligenceTempAdjustment = 0;
            expectedDTO.intelligenceTempModifier = -5;

            expectedDTO.wisdomScore = 0;
            expectedDTO.wisdomModifier = -5;
            expectedDTO.wisdomTempAdjustment = 0;
            expectedDTO.wisdomTempModifier = -5;

            expectedDTO.charismaScore = 0;
            expectedDTO.charismaModifier = -5;
            expectedDTO.charismaTempAdjustment = 0;
            expectedDTO.charismaTempModifier = -5;

            return expectedDTO;
        }
    }
}
