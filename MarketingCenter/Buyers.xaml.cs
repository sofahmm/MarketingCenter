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
    /// Interaction logic for Buyers.xaml
    /// </summary>
    public partial class Buyers : Page
    {
        public static ObservableCollection<Buyer> buyers { get; set; }
        public Buyers()
        {
            InitializeComponent();
            buyers = new ObservableCollection<Buyer>(DBConnect.connection.Buyer.ToList());
            this.DataContext = this;
        }

        private void list_buyer_Loaded(object sender, RoutedEventArgs e)
        {
            list_buyer.ItemsSource = DBConnect.connection.Buyer.ToList();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddBuyer());
        }
    }
}
