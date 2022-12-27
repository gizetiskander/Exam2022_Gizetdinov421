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
    /// Логика взаимодействия для AddClientWindow.xaml
    /// </summary>
    public partial class AddClientWindow : Window
    {
        public static TelephoneShopDBEntities1 dBEntities1 = new TelephoneShopDBEntities1();
        public AddClientWindow()
        {
            InitializeComponent();
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            if(NameTB.Text == "" || PhoneTB.Text == "")
            {
                MessageBox.Show("Введите данные клиента!");
            }
            else
            {
                ShopClient shopClient = new ShopClient();
                shopClient.Name_Client = NameTB.Text;
                shopClient.Telephone = PhoneTB.Text;
                dBEntities1.ShopClient.Add(shopClient);
                dBEntities1.SaveChanges();
                MessageBox.Show("Успешно");
                PhoneListWindow phoneListWindow = new PhoneListWindow();
                this.Close();
                phoneListWindow.Show();

            }
        }
    }
}
