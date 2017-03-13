﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ch10WelcomeToSloppyJoes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuMaker menuMaker = new MenuMaker();
        public MainWindow()
        {

            InitializeComponent();
            pageLayoutStackPanel.DataContext = menuMaker;
        }

        private void newMenu_Click(object sender, RoutedEventArgs e)
        {
            menuMaker.UpdateMenu();

        }
    }
}
