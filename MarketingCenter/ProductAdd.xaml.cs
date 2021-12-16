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
    /// Interaction logic for ProductAdd.xaml
    /// </summary>
    public partial class ProductAdd : Page
    {
        public static MarketingEntities db = new MarketingEntities();
        public static ObservableCollection<Product> products { get; set; }
        public static ObservableCollection<Product_category> product_Categories { get; set; }
        public ProductAdd()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>(DBConnect.connection.Product.ToList());
            product_Categories = new ObservableCollection<Product_category>(DBConnect.connection.Product_category.ToList());
            cb_categ.ItemsSource = db.Product_category.ToList();
            this.DataContext = this;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            var h = new Product();
            h.Name = txt_name.Text;
            var t = cb_categ.SelectedItem as Product_category;
            h.Product_category = t;
            db.Product.Add(h);
            db.SaveChanges();
            this.NavigationService.GoBack();
        }
    }
}
