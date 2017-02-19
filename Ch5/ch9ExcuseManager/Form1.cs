using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch9ExcuseManager
{
    public partial class Form1 : Form
    {
        private string selectedFolder = "";
        private Excuse currentExcuse = new Excuse();
        private bool formChanged = false;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = dtLastUsed.Value;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = selectedFolder;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFolder = folderBrowserDialog1.SelectedPath;
                btnOpen.Enabled = true;
                btnSave.Enabled = true;
                btnRandom.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtExcuse.Text) || String.IsNullOrEmpty(txtResult.Text))
            {
                MessageBox.Show("Please specify an escuse and a result", "Unable to save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            saveFileDialog1.InitialDirectory = selectedFolder;
            saveFileDialog1.Filter = "Text files (*.txt) |*.txt|All files(*.*)|*.*";
            saveFileDialog1.FileName = txtExcuse.Text + ".txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
                MessageBox.Show("Excuse written");
            }
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                this.txtExcuse.Text = currentExcuse.Description;
                this.txtResult.Text = currentExcuse.Results;
                this.dtLastUsed.Value = currentExcuse.LastUsed;
                if (!String.IsNullOrEmpty(currentExcuse.ExcusePath))
                    lbFileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                this.Text = "Excuse Manager";
            }
            else
            {
                this.Text = "Excuse Manager*";
            }
            this.formChanged = changed;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(CheckChanged())
            {
                openFileDialog1.InitialDirectory = selectedFolder;
                openFileDialog1.Filter = "Text1 files (*.txt)|*.txt|All1 files (*.*)|*.*";
                openFileDialog1.FileName = txtExcuse.Text + ".txt";
                DialogResult result = openFileDialog1.ShowDialog();
                if(result == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show(
                "The current excuse has not been saved. Continue?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return false;
            }
            return true;
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, selectedFolder);
                UpdateForm(false);
            }
        }

        private void txtExcuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = txtExcuse.Text;
            UpdateForm(true);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = txtResult.Text;
            UpdateForm(true);
        }

        private void dtLastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = dtLastUsed.Value;
            UpdateForm(true);
        }


        //public string Tekst()
        //{
        //    StreamWriter writer = new StreamWriter(@"D:\BERSAGLIO.txt", true);
        //    writer.WriteLine("The {0} is set to {1} degrees.");
        //    writer.Close();
        //    return string.Empty;
        //}

    }
}
