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
using FirstPractice2;

namespace FirstPractice1
{
    public partial class Page2 : Page
    {
        private LibraryDatabaseEntities library1 = new LibraryDatabaseEntities();
        public Page2()
        {
            InitializeComponent();
            biba.ItemsSource = library1.Books.ToList();
        }
    }
}
