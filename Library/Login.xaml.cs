using System;
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
using System.Text.RegularExpressions;

namespace Library
{
    /// <summary>
    /// Logika interakcji dla klasy Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        Frame Frame;
        public Login()
        {
            InitializeComponent();
        }

        public Login(Frame frame1)
        {
            InitializeComponent();
            this.Frame = frame1;
        }

        private void SingIn(object sender, RoutedEventArgs e)
        {
            if (Username.Text.Length == 0)
            {
                errormessage.Text = "Wprowadź nazwę użytkownika";
                Username.Focus();
            }
            else if (!Regex.IsMatch(Username.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                errormessage.Text = "Wprowadź poprawną nazwę użytkownika";
                Username.Select(0, Username.Text.Length);
                Username.Focus();
            }
            else
            {
                string username = Username.Text;
                string password = Password.Password;


                if (username != "admin@admin.pl" || password != "admin")
                {
                    errormessage.Text = "Złe hasło lub nazwa użytkownika";

                }

                else if (username == "admin@admin.pl" && password == "admin")
                {
                    this.Frame.Navigate(new HomePage(this.Frame));
                }

            }
        }
    }
}
