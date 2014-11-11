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

            List<int> characterStats = character.getStats();
            txtStrengthScore.Text = characterStats[0].ToString();
            txtDexterityScore.Text = characterStats[1].ToString();
            txtConstitutionScore.Text = characterStats[2].ToString();
            txtIntelligenceScore.Text = characterStats[3].ToString();
            txtWisdomScore.Text = characterStats[4].ToString();
            txtCharismaScore.Text = characterStats[5].ToString();

            txtStrengthTempAdjustment.Text = characterStats[6].ToString();
            txtDexterityTempAdjustment.Text = characterStats[7].ToString();
            txtConstitutionTempAdjustment.Text = characterStats[8].ToString();
            txtIntelligenceTempAdjustment.Text = characterStats[9].ToString();
            txtWisdomTempAdjustment.Text = characterStats[10].ToString();
            txtCharismaTempAdjustment.Text = characterStats[11].ToString();
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
