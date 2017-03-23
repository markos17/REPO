using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ch10WelcomeToSloppyJoes
{
    class MenuMaker : INotifyPropertyChanged
    {
        private Random random = new Random();
        private List<String> Meats = new List<String>() { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        private List<String> Condiments = new List<String>() { "yellow mustard", "brown mustard",
                   "honey mustard", "mayo", "relish", "french dressing" };
        private List<String> Breads = new List<String>() { "rye", "white", "wheat", "pumpernickel",
                   "italian bread", "a roll" };

        public event PropertyChangedEventHandler PropertyChanged;

        public int NumberOfItems { get; set; }
        public ObservableCollection<MenuItem> Menu { get; private set; }
        public DateTime GeneratedDate { get; set; }
        public string Test { get; set; }

        public MenuMaker()
        {
            Menu = new ObservableCollection<MenuItem>();
            NumberOfItems = 10;
            UpdateMenu();
            Test = "one";
        }

        private MenuItem CreateMenuItem()
        {
            string randomMeat = Meats[random.Next(Meats.Count)];
            string randomCondiment = Condiments[random.Next(Condiments.Count)];
            string randomBread = Breads[random.Next(Breads.Count)];
            return new MenuItem(randomMeat, randomCondiment, randomBread);
        }

        public void UpdateMenu()
        {
            Menu.Clear();
            for (int i = 0; i < NumberOfItems; i++)
            {
                Menu.Add(CreateMenuItem());
            }
            GeneratedDate = DateTime.Now;
            OnPropertyChanged("GeneratedDate");
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
