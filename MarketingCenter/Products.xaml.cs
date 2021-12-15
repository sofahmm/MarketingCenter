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
using System.Collections.ObjectModel;

namespace MarketingCenter
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        public static ObservableCollection<Product> products { get; set; }
        public Products()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>(DBConnect.connection.Product.ToList());
            this.DataContext = this;
        }

        private void list_products_Loaded(object sender, RoutedEventArgs e)
        {
            list_products.ItemsSource = DBConnect.connection.Product.ToList();
        }
    }
}
