using Exam2022_Gizetdinov421.db;
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
using System.Windows.Shapes;

namespace Exam2022_Gizetdinov421.Pages
{
    /// <summary>
    /// Логика взаимодействия для PhoneListWindow.xaml
    /// </summary>
    public partial class PhoneListWindow : Window
    {
        public static TelephoneShopDBEntities1 dBEntities = new TelephoneShopDBEntities1();
        public PhoneListWindow()
        {
            InitializeComponent();
            PhoneLV.ItemsSource = dBEntities.Phone.ToList();
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            this.Close();
            addClientWindow.Show();
            
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);    
        }

        private void SellPhoneBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PassedPhoneBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MaterialBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
