using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;

namespace ch11WpfGuySerializer
{
    class GuyManager : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Guy joe = new Guy("Joe", 37, 176.22M);
        public Guy Joe
        {
            get { return joe; }
        }

        private Guy bob = new Guy("Bob", 45, 222.22M);
        public Guy Bob
        {
            get { return bob; }
        }

        private Guy ed = new Guy("Ed", 19, 57.56M);
        public Guy Ed
        {
            get { return ed; }
        }

        public Guy NewGuy { get; set; }

        public string GuyFile { get; set; }

        public void ReadGuy()
        {
            if (string.IsNullOrEmpty(GuyFile))
                return;

            using (Stream inputStream = File.OpenRead(GuyFile))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Guy));
                NewGuy = serializer.ReadObject(inputStream) as Guy;
            }
            OnPropertyChanged("NewGuy");
        }

        public void WriteGuy(Guy guyToWrite)
        {
            GuyFile = Path.GetFullPath(guyToWrite.Name + ".xml");
            if (File.Exists(GuyFile))
                File.Delete(GuyFile);
            using (Stream outputSteram = File.OpenWrite(GuyFile))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Guy));
                serializer.WriteObject(outputSteram, guyToWrite);
            }

            OnPropertyChanged("GuyFile");
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyEvent = PropertyChanged;
            if (propertyEvent != null)
                propertyEvent(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
