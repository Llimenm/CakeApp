using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using System.Windows.Forms;
using CakeApp.Tables.DialogForms;
using System;

namespace CakeApp.Tables
{
    public partial class OrderPage : Page
    {
        public Заказ selectedItem { get; set; }

        private CakesEntities db = new CakesEntities();
        private EditWndiowForOrder editWndiow;

        public OrderPage() //Первоначальная инициализация и занос бд в таблицу
        {
            InitializeComponent();
            db.Заказ.Load();
            listBoxForTable.ItemsSource = db.Заказ.Local.ToBindingList().OrderBy(o => o.Номер);
        }

        private void refreshTableButton_Click(object sender, RoutedEventArgs e) // Кнопка обновления таблицы
        {
            listBoxForTable.ItemsSource = null;
            listBoxForTable.ItemsSource = db.Заказ.Local.ToBindingList();
        }

        private void addTableButton_Click(object sender, RoutedEventArgs e) // Кнопка открытия диалог. окна добавления записи
        {
            Заказ addItem = new Заказ();
            editWndiow = new EditWndiowForOrder();
            editWndiow.addButton.Content = "Добавить";
            if (true == editWndiow.ShowDialog())
            {
                InsertData(addItem);
                addItem.Номер = db.Заказ.OrderByDescending(o => o.Номер).FirstOrDefault().Номер + 1;
                addItem.Дата = DateTime.Today;
                db.Заказ.Add(addItem);
                db.SaveChanges();
            }
        }

        private void deleteTableButton_Click(object sender, RoutedEventArgs e) // Кнопка удаления записи с подверждением
        {
            if (System.Windows.Forms.MessageBox.Show("Вы хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo , MessageBoxIcon.Warning ) == DialogResult.Yes && selectedItem != null)
            {
                Заказ itemToRemove = db.Заказ.Where(o => o.Номер == selectedItem.Номер).FirstOrDefault();
                db.Заказ.Remove(itemToRemove);
                db.SaveChanges();
            }
            
        }

        public void listBoxForTable_SelectionChanged(object sender, SelectionChangedEventArgs e) // Выбор нужной строки для взаимодействия кода с ней
        {
            selectedItem = listBoxForTable.SelectedItem as Заказ;
        }

        private void editTableButton_Click(object sender, RoutedEventArgs e)
        {
            editWndiow = new EditWndiowForOrder();                                                          
            editWndiow.addButton.Content = "Изменить";                         
            if (selectedItem != null)                                                                     
            {
                editWndiow.Номер.Text = Convert.ToString(selectedItem.Номер);                               
                editWndiow.Дата.Text = Convert.ToString(selectedItem.Дата);
                editWndiow.Наименование_заказа.Text = selectedItem.Наименование_заказа;
                editWndiow.Изделие.Text = selectedItem.Изделие;
                editWndiow.Заказчик.Text = selectedItem.Заказчик;
                editWndiow.Менеджер.Text = selectedItem.Ответственный_менеджер;
                editWndiow.Стоимость.Text = Convert.ToString(selectedItem.Стоимость);
                editWndiow.План_дата_завершения.SelectedDate = selectedItem.Плановая_дата_завершения;
                editWndiow.Примеры_работ.Text = selectedItem.Примеры_работ;

                if (true == editWndiow.ShowDialog())
                {
                    InsertData(selectedItem);
                    db.SaveChanges();
                    listBoxForTable.ItemsSource = null;
                    listBoxForTable.ItemsSource = db.Заказ.Local.ToBindingList().OrderBy(o => o.Номер);
                }
            }
        }

        private Заказ InsertData(Заказ insertOrder)
        {
            insertOrder.Наименование_заказа = editWndiow.Наименование_заказа.Text;
            insertOrder.Изделие = editWndiow.Изделие.Text;
            insertOrder.Заказчик = editWndiow.Заказчик.Text;
            insertOrder.Ответственный_менеджер = editWndiow.Менеджер.Text;
            insertOrder.Стоимость = Convert.ToDecimal(editWndiow.Стоимость.Text);
            insertOrder.Плановая_дата_завершения = editWndiow.План_дата_завершения.SelectedDate;
            insertOrder.Примеры_работ = editWndiow.Примеры_работ.Text;
            return insertOrder;
        }

    }
}
