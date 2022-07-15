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
    /// Logika interakcji dla klasy ShowBooks.xaml
    /// </summary>
    public partial class ShowBooks : Page
    {
        Frame Frame;
        public ShowBooks()
        {
            InitializeComponent();
        }

        public ShowBooks(Frame frame1)
        {
            InitializeComponent();
            this.Frame = frame1;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new HomePage(Frame));
        }
    }
}
