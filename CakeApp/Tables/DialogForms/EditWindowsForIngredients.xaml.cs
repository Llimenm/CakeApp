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

namespace CakeApp.Tables.DialogForms
{
    /// <summary>
    /// Логика взаимодействия для EditWindowsForIngredients.xaml
    /// </summary>
    public partial class EditWindowsForIngredients : Window
    {
        public EditWindowsForIngredients()
        {
            InitializeComponent();
        }
        private void addButton_Click(object sender, RoutedEventArgs e) // Событие добавление нового ингридиента
        {
            using (CakesEntities db = new CakesEntities())
            {
                if (null == db.Поставщик.Where(o => o.Название_поставщика == Поставщик.Text).FirstOrDefault())
                {
                    MessageBox.Show("Поставщик не найден", "Такого поставщика не существует", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    DialogResult = true;
                    this.Close();
                }
            }
        }
    }
}
