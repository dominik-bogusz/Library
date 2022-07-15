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
        public List<Book> Books { get; set; }
        public ShowBooks()
        {
            InitializeComponent();
        }

        public ShowBooks(Frame frame1)
        {
            InitializeComponent();
            this.Frame = frame1;

            string connectionString = @"Data Source=DESKTOP-1D164CU\SQLCOURSE2019;Initial Catalog=Library;Integrated Security=True";

            using (LibraryContext db = new LibraryContext(connectionString))
            {

                Books = db.Book.ToList();
            }
            BooksList.ItemsSource = Books;
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new HomePage(Frame));
        }
    }
}
