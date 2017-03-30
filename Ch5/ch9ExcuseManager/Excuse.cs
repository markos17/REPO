using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace ch9ExcuseManager
{
    public class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string excusePath)
        {
            try
            {
                this.ExcusePath = excusePath;
                using (StreamReader reader = new StreamReader(excusePath))
                {
                    Description = reader.ReadLine();
                    Results = reader.ReadLine();
                    LastUsed = Convert.ToDateTime(reader.ReadLine());
                }
            }
            catch (SerializationException)
            {
                MessageBox.Show("Unable to read " + excusePath);
                LastUsed = DateTime.Now;
            }
        }

        public void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }

        }


    }
}
