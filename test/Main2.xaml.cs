﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Interaction logic for Main2.xaml
    /// </summary>
    public partial class Main2 : Window
    {
        public Main2()
        {
            InitializeComponent();
        }

        private void buttonPolBaza_Click(object sender, RoutedEventArgs e)
        {
           // PopBaza.IsOpen = true;
        }

        private void buttonGenerujTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Wyloguj_Click(object sender, RoutedEventArgs e)
        {
            (new Logowanie()).Show();
            Close();

        }
    }
}
