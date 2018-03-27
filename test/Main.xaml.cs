using System;
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
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();
            //TextNazwaTestu.Text = Application.Current.Properties["Login"].ToString();
        }

   
        public void polZBaza(bool czy)
        {
            if (czy == true)
                TextPolBaza.Text = "tak";
            else
                TextPolBaza.Text = "brak";
        }

        private void buttonPolBaza_Click(object sender, RoutedEventArgs e)
        {
            (new Baza()).Show();
        }

        private void buttonGenerujTest_Click(object sender, RoutedEventArgs e)
        {
           //TextNazwaTestu.Text = Application.Current.Properties["Login"].ToString();
        }

        private void buttonPobierzTesty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSprawdz_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
