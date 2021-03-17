using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace CakeApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login_button_Click(this, e);
            }
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            string LoginUser = Login_TextBox.Text;
            string Password = PasswordBox.Password;

            using (CakesEntities db = new CakesEntities())
            {
                db.Пользователи.Load();
                var user = db.Пользователи.Where(u => u.Login == LoginUser && u.Password == Password).FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Логин или пароль введены неверно");
                }
                else
                {
                    userData.user = user;
                    UserCabinet userCabinet = new UserCabinet();
                    userCabinet.Show();
                    Close();
                }
            }
        }

        private void PasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Login_button_Click(this, e);
            }
        }

        private void Registration_button_Click(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            Close();
            registration.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
