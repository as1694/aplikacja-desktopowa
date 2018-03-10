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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace test
{
    /// <summary>
    /// Interaction logic for Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void buttonZaloguj_Click(object sender, RoutedEventArgs e)
        {
            if (TextLogin.Text == "admin" && Password.Password == "admin")
            {
                (new Main()).Show();

                Close();
            }
            else
                KomH.Content = "Nieprawidłowy login lub hasło.";
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                buttonZaloguj_Click(sender, e);
            }
        }

        private void buttonPubliczny_Click(object sender, RoutedEventArgs e)
        {
            (new Main()).Show();

            Close();
        }

        private void buttonNowyProfil_Click(object sender, RoutedEventArgs e)
        {
            (new NowyProfil()).Show();

            Close();
        }
    }
}
