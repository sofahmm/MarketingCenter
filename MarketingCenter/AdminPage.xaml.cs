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

namespace MarketingCenter
{
    /// <summary>
    /// Interaction logic for AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btn_buyer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Buyers());
        }

        private void btn_invoice_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageInvoice());
        }

        private void btn_priduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Products());
        }

        private void btn_bankdetails_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new BankDetailsPage());
        }
    }
}
