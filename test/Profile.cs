using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test
{
    class Profile
    {
        public string[] User
        {
            get;
            private set;
        }

        public string[] Password
        {
            get;
            private set;
        }

        public Profile(string [] u, string [] p)
        {
            User = u;
            Password = p;
        }

        // dodać ścieżkę do pliku z loginami i hasłami ---------------------    TO DO    ------------
        // szyfrowanie haseł??? ---------------------    TO DO    ------------

        public Profile() 
        {
            User = new string[3];
            User[0] = "aa";
            User[1] = "bb";
            User[2] = "admin";

            Password = new string[3];
            Password[0] = "aa";
            Password[1] = "bb";
            Password[2] = "admin";
        }
    }
}
