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
    /// Interaction logic for NowyProfil.xaml
    /// </summary>
    public partial class NowyProfil : Window
    {
        public NowyProfil()
        {
            InitializeComponent();
        }

        private void buttonStworzKonto_Click(object sender, RoutedEventArgs e)
        {
            if (TextNLogin.Text != "" && NewPassword.Password == NewPassword2.Password)
            {
                (new Main()).Show();

                Close();
            }
            else
            {
                if(TextNLogin.Text == "" && NewPassword != null && NewPassword.Password != NewPassword2.Password)
                    KomNP.Content = "Podana nazwa użytkownika jest już zajęta. Hasła są różne";
                if (TextNLogin.Text != null && NewPassword.Password == NewPassword2.Password)
                    KomNP.Content = "Podana nazwa użytkownika jest już zajęta.";
                else
                    KomNP.Content = "Hasła są różne";
            }
        }
    }
}
