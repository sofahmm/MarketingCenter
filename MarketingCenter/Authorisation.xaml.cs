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
    /// Interaction logic for Authorisation.xaml
    /// </summary>
    public partial class Authorisation : Page
    {
        public static ObservableCollection<User> users { get; set; }
        public Authorisation()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, RoutedEventArgs e)
        {
            users = new ObservableCollection<User>(DBConnect.connection.User.ToList());
            var n = users.Where(a => a.Login == txt_login.Text && a.Password == pb_password.Password).FirstOrDefault();
            if(n != null)
            {

            }
            else
            {
                MessageBox.Show("Логин или пароль неверный", "error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_reg_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
