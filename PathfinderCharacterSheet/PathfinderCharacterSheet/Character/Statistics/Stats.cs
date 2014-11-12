using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathfinderCharacterSheet
{
    class Stats
    {
        private Ability strenght;
        private Ability dexterity;
        private Ability constitution;
        private Ability intelligence;
        private Ability wisdom;
        private Ability charisma;

        public Stats()
        {
            strenght = new Ability(0);
            dexterity = new Ability(0);
            constitution = new Ability(0);
            intelligence = new Ability(0);
            wisdom = new Ability(0);
            charisma = new Ability(0);
        }

        public StatsDTO getAllStats()
        {
            StatsDTO stats = new StatsDTO();

            stats.strenghtScore = strenght.getScore();
            stats.strenghtModifier = strenght.getModifier();
            stats.strenghtTempAdjustment = strenght.getTemporaryAdjustment();
            stats.strenghtTempModifier = strenght.getTemporaryModifier();

            stats.dexterityScore = dexterity.getScore();
            stats.dexterityModifier = dexterity.getModifier();
            stats.dexterityTempAdjustment = dexterity.getTemporaryAdjustment();
            stats.dexterityTempModifier = dexterity.getTemporaryModifier();

            stats.constitutionScore = constitution.getScore();
            stats.constitutionModifier = constitution.getModifier();
            stats.constitutionTempAdjustment = constitution.getTemporaryAdjustment();
            stats.constitutionTempModifier = constitution.getTemporaryModifier();

            stats.intelligenceScore = intelligence.getScore();
            stats.intelligenceModifier = intelligence.getModifier();
            stats.intelligenceTempAdjustment = intelligence.getTemporaryAdjustment();
            stats.intelligenceTempModifier = intelligence.getTemporaryModifier();

            stats.wisdomScore = wisdom.getScore();
            stats.wisdomModifier = wisdom.getModifier();
            stats.wisdomTempAdjustment = wisdom.getTemporaryAdjustment();
            stats.wisdomTempModifier = wisdom.getTemporaryModifier();

            stats.charismaScore = charisma.getScore();
            stats.charismaModifier = charisma.getModifier();
            stats.charismaTempAdjustment = charisma.getTemporaryAdjustment();
            stats.charismaTempModifier = charisma.getTemporaryModifier();

            return stats;
        }
    }
}
