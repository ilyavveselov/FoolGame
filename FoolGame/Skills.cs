using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoolGame
{
    public partial class Skills : Form
    {
        double Def = 0, Dmg = 0, Heal = 0, Hp = 0;
        int vampHeal = 12;
        int vampDmg = 6;

        int bleedDmg = 14;
        int bleedHeal = 8;

        int contrDef = 12;
        int contrDmg = 8;

        bool isSkillSelected = false;
        bool isUltSelected = false;
        byte ult;
        public Skills()
        {
            InitializeComponent();
        }
        public Skills(double[] stats) : this()
        {
            Def = stats[0];
            Dmg = stats[1];
            Heal = stats[2];
            Hp = stats[3];
        }

        public double[] GiveDataToMainForm()
        {
            double[] stats = new double[] { Def, Dmg, Heal, Hp };
            return stats;
        }

        public byte? GiveUltToMain()
        {
            if (isUltSelected)
            {
                return ult;
            }
            else
            {
                return null;
            }
        }
        private void bAddDef_Click(object sender, EventArgs e)
        {
            Def += 2;
            isSkillSelected = true;
            Close();
        }

        private void Skills_Load(object sender, EventArgs e)
        {
            labelDef.Text += " " + Def.ToString();
            labelDmg.Text += " " + Dmg.ToString();
            labelHeal.Text += " " + Heal.ToString();
            this.Text = $"Сейчас у вас {Hp} здоровья";
            labelCntrDmgDef.Text = $"Защита: {contrDef - Def}";
            labelCntrDmgDmg.Text = $"Урон: {contrDmg - Dmg}";
            labelBleedDmg.Text = $"Урон: {bleedDmg - Dmg}";
            labelBleedHeal.Text = $"Лечение: {bleedHeal - Heal}";
            labelVampDmg.Text = $"Урон: {vampDmg - Dmg}";
            labelVampHeal.Text = $"Лечение: {vampHeal - Heal}";
            if (Dmg >= vampDmg && Heal >= vampHeal) bVamp.Enabled = true;
            if (Dmg >= contrDmg && Def >= contrDef) bCntrDmg.Enabled = true;
            if (Heal >= bleedHeal && Dmg >= bleedDmg) bBleed.Enabled = true;

        }

        private void bCntrDmg_Click(object sender, EventArgs e)
        {
            isUltSelected = true;
            ult = 1;
            Close();
        }

        private void bBleed_Click(object sender, EventArgs e)
        {
            isUltSelected = true;
            ult = 2;
            Close();
        }

        private void bVamp_Click(object sender, EventArgs e)
        {
            isUltSelected = true;
            ult = 3;
            Close();
        }

        private void Skills_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSkillSelected && !isUltSelected)
            {
                Environment.Exit(0);
            }
        }

        private void bAddDmg_Click(object sender, EventArgs e)
        {
            Dmg += 2;
            isSkillSelected = true;
            Close();
        }

        private void bAddHeal_Click(object sender, EventArgs e)
        {
            Heal += 2;
            isSkillSelected = true;
            Close();
        }
    }
}
