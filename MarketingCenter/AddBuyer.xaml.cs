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
    /// Interaction logic for AddBuyer.xaml
    /// </summary>
    public partial class AddBuyer : Page
    {
        public  static MarketingEntities db = new MarketingEntities();
        public static ObservableCollection<Buyer> buyers { get; set; }
        public static ObservableCollection<Bank_details> bank_Details { get; set; }
        public AddBuyer()
        {
            InitializeComponent();
            buyers = new ObservableCollection<Buyer>(DBConnect.connection.Buyer.ToList());
            bank_Details = new ObservableCollection<Bank_details>(DBConnect.connection.Bank_details.ToList());
            // cb_numbBank.ItemsSource = new ObservableCollection<Buyer>(DBConnect.connection.Buyer.ToList());
            cb_numbBank.ItemsSource = db.Bank_details.ToList();
            

            //cb_numbBank.DisplayMemberPath = "Bank_number";
            this.DataContext = this;
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            var b = new Buyer();
            //var w = cb_entity.SelectedItem as Buyer;
            b.Entity = (cb_entity.SelectedItem).ToString();
            //b.Entity = txt_entity.Text;
            b.Name = txt_name.Text;
            b.Document_number = Convert.ToInt32(txt_numberDoc.Text);
            b.Document_series = Convert.ToInt32(txt_serDoc.Text);
            var gg = cb_numbBank.SelectedItem as Bank_details;
            b.Bank_details =  gg;
            db.Buyer.Add(b);
            db.SaveChanges();
        }

        private void cb_numbBank_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_entity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
