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

namespace Library
{
    /// <summary>
    /// Logika interakcji dla klasy HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private Frame Frame;
        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(Frame frame1)
        {
            InitializeComponent();
            this.Frame = frame1;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(new ShowBooks(this.Frame));
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
