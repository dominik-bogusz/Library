﻿using System;
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
    /// Logika interakcji dla klasy AddBook.xaml
    /// </summary>
    public partial class AddBook : Page
    {
        Frame Frame;
        public AddBook()
        {
            InitializeComponent();
        }
        public AddBook(Frame frame1)
        {
            InitializeComponent();
            this.Frame = frame1;

            //db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            //db.SaveChanges();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new HomePage(Frame));
        }

    private void BookAdd_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-1D164CU\SQLCOURSE2019;Initial Catalog=Library;Integrated Security=True";

            using (LibraryContext db = new LibraryContext(connectionString))
            {
                db.Add(new Author { Name = BookTitle.Text, Surname=BookYear.Text });
                db.SaveChanges();
            }
        }
    }
}
