using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch5InheritanceBeesPart2
{
    public partial class Form1 : Form
    {
        private Queen queen;

        public Form1()
        {
            InitializeComponent();
            cbJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                        "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" },155);
            queen = new Queen(workers, 275);
        }

        private void btnAssignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(cbJob.Text, (int)nrShits.Value) == false)
                MessageBox.Show("Nie ma robotnikow dla tego zadania" + cbJob.Text);
            else
                MessageBox.Show("Zadanie " + cbJob.Text + " będzie wykonane w " + nrShits.Value + " zmianach");
        }

        private void btnNextShift_Click(object sender, EventArgs e)
        {
            txtReport.Text = queen.WorkTheNextShift();
        }
    }
}
