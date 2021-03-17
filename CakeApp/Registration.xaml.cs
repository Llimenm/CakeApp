using System;
using System.Threading;
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
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace CakeApp
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close(); // Возвращение в окно логина
        }

        private void Registration_button_Click(object sender, RoutedEventArgs e)
        {
            string Login = Login_TextBox.Text;          //Фиксация введных данных
            string Password = Password_TextBox.Password;
            string FN = FN_TextBox.Text;
            string SN = SN_TextBox.Text;

            using (CakesEntities db = new CakesEntities())
            {
                db.Пользователи.Load();
                var user = db.Пользователи.Where(u => u.Login == Login).FirstOrDefault(); // Нахождение одинаковых логинов
                MainWindow mainWindow = new MainWindow();
                while (true)
                {
                    if (user != null) //Проверка на уникальность логина
                    {
                        MessageBox.Show("Этот логин уже занят"); 
                        goto BreakLink; 
                    }
                    if (Login == "") // Проверка на пустоту поля
                    {
                        MessageBox.Show("Введите логин"); 
                        goto BreakLink;
                    }
                    if (Regex.IsMatch(Login, @"[а-яА-Я]")) //Проверка на ввод кирилицы
                    {
                        MessageBox.Show("Логин не должен содержать кириллицу."); 
                        goto BreakLink;
                    }
                    if (Regex.IsMatch(Password, @"[А-Я]") || Regex.IsMatch(Password, @"[а-я]")) //Проверка на ввод кирилицы
                    {
                        MessageBox.Show("Пароль не должен содержать кириллицу.");  
                        goto BreakLink;
                    }
                    if (Password.Length < 5 || Password.Length > 20)  //Проверка на соблюдения длинны пароля
                    {
                        MessageBox.Show("Пароль должен быть от 5 до 20 символов");
                        goto BreakLink;
                    }
                    if (Password == Login) // В сообщении для пользователя и так понятно на что проверка, этот комментарий существует просто потому что
                    {
                        MessageBox.Show("Пароль не должен совпадать с логином"); 
                        goto BreakLink;
                    }
                    if (SN == "") // Проверка на пустоту поля
                    {
                        MessageBox.Show("Введите фамилию"); 
                        goto BreakLink;
                    }
                    if (FN == "") // Проверка на пустоту поля
                    {
                        MessageBox.Show("Введите имя и отчество"); 
                        goto BreakLink;
                    }
                    user = new Пользователи
                    {
                        Login = Login,
                        Role = "Заказчик",
                        Password = Password,
                        Фамилия = SN,
                        Имя_Отчество = FN
                    };
                    db.Пользователи.Add(user);
                    db.SaveChanges();
                    Close();
                    mainWindow.Show();
                BreakLink: break;
                }
            }
        }
    }
}
