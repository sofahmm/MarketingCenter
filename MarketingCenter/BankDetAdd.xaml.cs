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
    /// Interaction logic for BankDetAdd.xaml
    /// </summary>
    public partial class BankDetAdd : Page
    {
        public static MarketingEntities db = new MarketingEntities();
        public static ObservableCollection<Bank_details> bank_s { get; set; }
        public BankDetAdd()
        {
            
            bank_s = new ObservableCollection<Bank_details>(DBConnect.connection.Bank_details.ToList());
            InitializeComponent();
            this.DataContext = this;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            var t = new Bank_details();
            t.Bank_number = Convert.ToInt32(txt_NumbBank.Text);
            t.Bank_name = txt_nameBank.Text;
            db.Bank_details.Add(t);
            db.SaveChanges();
        }
    }
}
