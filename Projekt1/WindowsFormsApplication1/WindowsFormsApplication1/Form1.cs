using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "clicked 2ga ver";
            label1.BackColor = Color.Red;



            Dictionary<int, string> dictionary =
    new Dictionary<int, string>();

            Dictionary<string, int> count = new Dictionary<string, int>();
            dictionary.Add(11, "apple");
            dictionary.Add(22, "apple");
            dictionary.Add(33, "windows");
            dictionary.Add(44, "apple");
            dictionary.Add(55, "windows");
           // dictionary.Add(66, "windows");


            // See whether Dictionary contains this string.
            if (dictionary.ContainsKey(1))
            {
                string value = dictionary[1];
                label1.Text += dictionary.Keys.ToString();
            }

            // See whether it contains this string.
            if (!dictionary.ContainsKey(2))
            {
                label1.Text += false;
            }


            foreach (KeyValuePair<int, string> item in dictionary)
            {
                label2.Text += item.Value + "\n";

                if (!count.ContainsKey(item.Value))
                    count.Add(item.Value, 1);
                else
                    count[item.Value] += 1;

            }

            var maxCount = dictionary.FirstOrDefault(x => x.Key == dictionary.Keys.Max()).Key;
            var max = dictionary.GroupBy(x => x.Value).OrderByDescending(g => g.Count()).FirstOrDefault().Key;
            label1.Text = max.ToString();

            foreach (var item in count)
            {
                label2.Text += item.Key + " " + item.Value;
            }

            label2.Text += Environment.NewLine + count.Values.Max();
            var biggestKey = count.FirstOrDefault(x => x.Value == count.Values.Max()).Key;
            label2.Text = biggestKey + " " + count[biggestKey].ToString();
        }
    }
}
