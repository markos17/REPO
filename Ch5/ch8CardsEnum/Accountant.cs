using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch8CardsEnum
{
    public class Accountant
    {
        public class Pracownik
        {
            virtual public void Pracuj() { MessageBox.Show("Pracownik pracuje"); }
        }

        public class Sekretarka : Pracownik
        {
            override public void Pracuj() { MessageBox.Show("Sekretarka pracuje"); }
        }

        public class Ochroniarz : Pracownik
        {
            override public void Pracuj() { MessageBox.Show("Ochroniarz pracuje"); }
        }

        public class Ksiegowy : Pracownik
        {
            override public void Pracuj() { MessageBox.Show("Księgowy pracuje"); }
        }



    }
}
