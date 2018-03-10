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
    
            

            // pobrać listę z profilami
            // sprawdzić, czy wprowadzony sie powtarza

            //bool jest = false;

            /*string[] prof = App.profile;

            foreach (string p in prof)
            {
                if ( prof (p) == TextNLogin.Text)
                {

                }
            }*/

            if (TextNLogin.Text != "" && NewPassword.Password == NewPassword2.Password && NewPassword.Password != "")
            {
                (new Main()).Show();

                Close();
            }
            else if(TextNLogin.Text == "")
                KomNP.Content = "Podaj nazwę użytkownika";
            else if (NewPassword.Password == NewPassword2.Password && NewPassword.Password == "")
                KomNP.Content = "Wprowadź hasło";
            else if (NewPassword.Password != NewPassword2.Password)
                KomNP.Content = "Hasła są różne";

        }
    }
}
