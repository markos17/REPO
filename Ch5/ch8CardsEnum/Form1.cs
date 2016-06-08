using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ch8CardsEnum
{
    public partial class Form1 : Form
    {
        Card card;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void RandomCard()
        {
            Random random = new Random();
            int nr0_3 = random.Next(4);
            int nr1_13 = random.Next(1, 14);
            card = new Card((Suit)nr0_3, (Value)nr1_13 );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RandomCard();
            MessageBox.Show(card.Name);


           // Accountant acc = new Accountant();

            List<Accountant.Pracownik> lista = new List<Accountant.Pracownik>();
            

            lista.Add(new Accountant.Sekretarka());
            lista.Add(new Accountant.Ochroniarz());
            lista.Add(new Accountant.Ksiegowy());

            Accountant.Sekretarka sekr = new Accountant.Sekretarka();
            lista.Add(sekr);
            MessageBox.Show(lista.IndexOf(sekr).ToString());
            lista.RemoveAt(3);
            MessageBox.Show(lista.IndexOf(sekr).ToString());
            foreach (var i in lista)
            {
                // hurtowo wszystkich zaganiamy do pracy
                i.Pracuj();

            }
           
        }
    }
}
