using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty_first_version
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            //dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            //dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            //dinnerParty.SetHealthyOption(healthyBox.Checked);
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyBox.Checked, fancyBox.Checked);

            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)nrNumberBirthday.Value, chbFancyBirthday.Checked, txtCakewWriting.Text);

            DispalyBirthdayPartyCost();
        }




        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            //    decimal Cost = dinnerParty.CalculateCost(healthyBox.Checked);
            costLabel.Text = Cost.ToString("c");
        }

        private void nrNumberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)nrNumberBirthday.Value;
            DispalyBirthdayPartyCost();
        }

        private void chbFancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = chbFancyBirthday.Checked;
            DispalyBirthdayPartyCost();
        }

        private void txtCakewWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = txtCakewWriting.Text;
            DispalyBirthdayPartyCost();
        }


        private void DispalyBirthdayPartyCost()
        {
            lblTooLong.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            lblBirthdayCost.Text = cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();

        }

        private void fancyBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyBox.Checked;
            //   dinnerParty.CalculateCostOfDecorations(fancyBox.Checked);
            DisplayDinnerPartyCost();

        }

        private void healthyBox_CheckedChanged(object sender, EventArgs e)
        {


            dinnerParty.HealthyOption = healthyBox.Checked;
            //  dinnerParty.SetHealthyOption(healthyBox.Checked);
            DisplayDinnerPartyCost();

        }
    }
}
