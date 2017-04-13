using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch15DelegateRestaurantWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        private void button1_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
            {
                MessageBox.Show("I'll add " + ingredientMethod((int)nrAmount.Value));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredient);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ingredientMethod = amy.AmySecretIngredientMethod;
        }
    }
}
