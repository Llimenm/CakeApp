using CakeApp.Tables;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;

namespace CakeApp
{
    /// <summary>
    /// Логика взаимодействия для UserCabinet.xaml
    /// </summary>
    public partial class UserCabinet : Window
    {
        public UserCabinet() 
        {
            InitializeComponent();
            SeconNameBlock.Text = userData.user.Фамилия;
            FirstNameBlock.Text = userData.user.Имя_Отчество;
            RoleBlock.Text = userData.user.Role;
            var tablesName = new List<string> { "Ингредиенты", "Заказы" };
            tableSwitchBox.ItemsSource = tablesName;
        }
        private void Button_Click(object sender, RoutedEventArgs e) // Выход на страницу авторизации
        {
            MainWindow window = new MainWindow();
            this.Close();
            window.Show();
        }

        private void tableSwitchBox_DropDownClosed(object sender, System.EventArgs e) // Выбор таблицы
        {
            switch (tableSwitchBox.Text)
            {
                case "Ингредиенты":
                    IngredientPage ingredientPage = new IngredientPage();
                    frameForTables.Navigate(ingredientPage);
                    break;
                case "Заказы":
                    OrderPage orderPage = new OrderPage();
                    frameForTables.Navigate(orderPage);
                    break;
            }
        }
    }
}
