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
    /// Interaction logic for PageInvoiceAdd.xaml
    /// </summary>
    public partial class PageInvoiceAdd : Page
    {
        public static MarketingEntities db = new MarketingEntities();
        public static ObservableCollection<Invoice> invoices { get; set; }
        public static ObservableCollection<Buyer> buyers { get; set; }
        
        public PageInvoiceAdd()
        {
            InitializeComponent();
            invoices = new ObservableCollection<Invoice>(DBConnect.connection.Invoice.ToList());
            buyers = new ObservableCollection<Buyer>(DBConnect.connection.Buyer.ToList());
            cb_Buyer.ItemsSource = db.Invoice.ToList();
            cb_Product.ItemsSource = db.Invoice.ToList();
            this.DataContext = this;
        }

        private void cb_Buyer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, RoutedEventArgs e)
        {
            var b = new Invoice();
            var ff = cb_Buyer.SelectedItem as Buyer;
            b.Buyer = ff;
            b.Vacation_price = Convert.ToInt32(txt_Cost.Text);
            b.Quantity_of_goods_released = Convert.ToInt32(txt_Count.Text);
            b.Address = txt_Address.Text;
            var dd = cb_Product.SelectedItem as Product;
            b.Product = dd;
            db.Invoice.Add(b);
            db.SaveChanges();
        }

        private void cb_Product_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
