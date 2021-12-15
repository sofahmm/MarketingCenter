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
    /// Interaction logic for BankDetailsPage.xaml
    /// </summary>
    public partial class BankDetailsPage : Page
    {
        public static ObservableCollection<Bank_details> bank_Details { get; set; }
        public BankDetailsPage()
        {
            InitializeComponent();
            bank_Details = new ObservableCollection<Bank_details>(DBConnect.connection.Bank_details.ToList());
            this.DataContext = this;
        }

        private void list_bankDet_Loaded(object sender, RoutedEventArgs e)
        {
            list_bankDet.ItemsSource = DBConnect.connection.Bank_details.ToList();
        }
    }
}
