﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ch12DisposePlay
{
    [Serializable]
    class Clone : IDisposable
    {
        public int Id { get; private set; }


        public Clone(int Id)
        {
            this.Id = Id;
        }

        public void Dispose()
        {
            //  MessageBox.Show("I’ve been disposed!" + "Clone #" + Id + " says...");
            string filename = @"C:\Temp\Clone.dat";
            string dirname = @"C:\Temp\";
            if (File.Exists(filename) == false)
            {
                Directory.CreateDirectory(dirname);
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }
        }

        ~Clone()
        {
            MessageBox.Show("Aaargh! You got me!" + " Clone #" + Id + " says...");
        }
    }
}