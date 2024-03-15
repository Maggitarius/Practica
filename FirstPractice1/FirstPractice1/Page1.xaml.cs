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
using FirstPractice1.LibraryDatabaseDataSetTableAdapters;

namespace FirstPractice1
{
    public partial class Page1 : Page
    {
        AuthorsTableAdapter authors = new AuthorsTableAdapter();
        public Page1()
        {
            InitializeComponent();
            Authors.ItemsSource = authors.GetData();
        }
    }
}   
