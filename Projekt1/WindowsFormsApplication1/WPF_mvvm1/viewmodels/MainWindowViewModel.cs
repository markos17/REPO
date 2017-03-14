using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_mvvm1.viewmodels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _name;
        private string _surname;
        private string _defaultNameText = "Podaj imię";
        private readonly string _defaultSurnameText = "Podaj nazwisko";

        private string _result;

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(() => Result);
            }
        }

        public string Name
        {
            get
            {
                return !string.IsNullOrEmpty(_name) ? _name : _defaultNameText;
            }
            set
            {
                _name = value == string.Empty ? _defaultNameText : value;
                OnPropertyChanged(() => Name);
            }

        }


        public string Surname
        {
            get
            {
                return !string.IsNullOrEmpty(_surname) ? _surname : _defaultSurnameText;
            }
            set
            {
                _surname = value == string.Empty ? _defaultSurnameText : value;
                OnPropertyChanged(() => Surname);
            }
        }

        public ICommand ValidateCommand { get; set; }

        public MainWindowViewModel()
        {
            ValidateCommand = new DelegateCommand(ValidateAction);
        }
        private void ValidateAction()
        {
            bool validationResult = Name != _defaultNameText
                && Surname != _defaultSurnameText;
            if (!validationResult)
            {
                Result = "Błąd, nie wypełniłeś wszystkich pól";
                return;
            }
            Result = "Brawo, poprawnie wypełniony formularz!";
        }
    }
}
