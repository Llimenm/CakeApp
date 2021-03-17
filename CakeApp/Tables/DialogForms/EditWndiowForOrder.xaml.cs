using System.Windows;

namespace CakeApp.Tables.DialogForms
{
    /// <summary>
    /// Логика взаимодействия для EditWndiowForOrder.xaml
    /// </summary>
    public partial class EditWndiowForOrder : Window
    {
        public EditWndiowForOrder()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            this.Close();
        }
    }
}
