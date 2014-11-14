using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathfinderCharacterSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character character = new Character();

            StatsDTO characterStats = character.getStats();

            txtStrengthScore.Text = characterStats.strenghtScore.ToString();
            txtStrengthModifier.Text = characterStats.strenghtModifier.ToString();
            txtStrengthTempAdjustment.Text = characterStats.strenghtTempAdjustment.ToString();
            txtStrengthTempModifier.Text = characterStats.intelligenceTempModifier.ToString();

            txtDexterityScore.Text = characterStats.dexterityScore.ToString();
            txtDexterityModifier.Text = characterStats.dexterityModifier.ToString();
            txtDexterityTempAdjustment.Text = characterStats.dexterityTempAdjustment.ToString();
            txtDexterityTempModifier.Text = characterStats.dexterityTempModifier.ToString();

            txtConstitutionScore.Text = characterStats.constitutionScore.ToString();
            txtConstitutionModifier.Text = characterStats.constitutionModifier.ToString();
            txtConstitutionTempAdjustment.Text = characterStats.constitutionTempAdjustment.ToString();
            txtConstitutionTempModifier.Text = characterStats.constitutionTempModifier.ToString();

            txtIntelligenceScore.Text = characterStats.intelligenceScore.ToString();
            txtIntelligenceModifier.Text = characterStats.intelligenceModifier.ToString();
            txtIntelligenceTempAdjustment.Text = characterStats.intelligenceTempAdjustment.ToString();
            txtIntelligenceTempModifier.Text = characterStats.intelligenceTempModifier.ToString();

            txtWisdomScore.Text = characterStats.wisdomScore.ToString();
            txtWisdomModifier.Text = characterStats.wisdomModifier.ToString();
            txtWisdomTempAdjustment.Text = characterStats.wisdomTempAdjustment.ToString();
            txtWisdomTempModifier.Text = characterStats.wisdomTempModifier.ToString();

            txtCharismaScore.Text = characterStats.charismaScore.ToString();
            txtCharismaModifier.Text = characterStats.charismaModifier.ToString();
            txtCharismaTempAdjustment.Text = characterStats.charismaTempAdjustment.ToString();
            txtCharismaTempModifier.Text = characterStats.charismaTempModifier.ToString();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
