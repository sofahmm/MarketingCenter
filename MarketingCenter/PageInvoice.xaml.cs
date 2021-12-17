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
    /// Interaction logic for PageInvoice.xaml
    /// </summary>
    public partial class PageInvoice : Page
    {
        public static ObservableCollection<Invoice> invoices { get; set; }
        public PageInvoice()
        {
            InitializeComponent();
            invoices = new ObservableCollection<Invoice>(DBConnect.connection.Invoice.ToList());
            this.DataContext = this;
        }

        private void lv_Invoice_Loaded(object sender, RoutedEventArgs e)
        {
            //list_buyer.ItemsSource = DBConnect.connection.Buyer.ToList();
            lv_Invoice.ItemsSource = DBConnect.connection.Invoice.ToList();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageInvoiceAdd());
        }
    }
}
