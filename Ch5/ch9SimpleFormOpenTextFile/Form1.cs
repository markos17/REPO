using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ch9SimpleFormOpenTextFile
{
    public partial class Form1 : Form
    {
        private string name;

        public Form1()
        {
            InitializeComponent();
        }
        //dell test
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "*.txt|*.pdf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "SUPER TYTUŁ!";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                name = saveFileDialog1.FileName;
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
