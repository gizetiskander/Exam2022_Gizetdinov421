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
using Exam2022_Gizetdinov421.db;

namespace Exam2022_Gizetdinov421.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public static TelephoneShopDBEntities1 dBEntities = new TelephoneShopDBEntities1();
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTB.Text == "" || PasswordPB.Password == "")
            {
                MessageBox.Show("Введите ваши данные!");
            }
            else
            {
                foreach (var user in dBEntities.User)
                {
                    if (user.Login == LoginTB.Text.Trim())
                    {
                        if (user.Password == PasswordPB.Password.Trim() && user.Id_Role == 1)
                        {
                            MessageBox.Show($"Добро пожаловать, администратор: {user.Name_User}");
                            PhoneListWindow phoneListWindow = new PhoneListWindow();
                            this.Close();
                            phoneListWindow.Show();
                            phoneListWindow.AddClientBtn.Visibility = Visibility.Visible;
                            phoneListWindow.SellPhoneBtn.Visibility = Visibility.Visible;
                            phoneListWindow.PassedPhoneBtn.Visibility = Visibility.Visible;
                        }
                        else if (user.Password == PasswordPB.Password.Trim() && user.Id_Role == 2)
                        {
                            MessageBox.Show($"Добро пожаловать, работник мастерской: {user.Name_User}");
                            PhoneListWindow phoneListWindow = new PhoneListWindow();
                            this.Close();
                            phoneListWindow.Show();
                            phoneListWindow.MaterialBtn.Visibility = Visibility.Visible;
                            
                        }
                        else if (user.Password == PasswordPB.Password.Trim() && user.Id_Role == 3)
                        {
                            MessageBox.Show($"Добро пожаловать, работник склада: {user.Name_User}");
                            PhoneListWindow phoneListWindow = new PhoneListWindow();
                            this.Close();
                            phoneListWindow.Show();

                        }
                        else if (user.Password == PasswordPB.Password.Trim() && user.Id_Role == 4)
                        {
                            MessageBox.Show($"Добро пожаловать, владелец: {user.Name_User}");
                            PhoneListWindow phoneListWindow = new PhoneListWindow();
                            this.Close();
                            phoneListWindow.Show();

                        }
                    }
                }
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
