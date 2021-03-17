using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using System.Windows.Forms;
using CakeApp.Tables.DialogForms;
using System;

namespace CakeApp.Tables
{
    public partial class IngredientPage : Page
    {
        public Ингредиенты selectedItem { get; set; }

        private CakesEntities db = new CakesEntities();
        private EditWindowsForIngredients editWndiow;
        public IngredientPage()
        {
            InitializeComponent();
            db.Ингредиенты.Load();
            listBoxForTable.ItemsSource = db.Ингредиенты.Local.ToBindingList();
        }
        private void refreshTableButton_Click(object sender, RoutedEventArgs e) // Кнопка обновления таблицы
        {
            listBoxForTable.ItemsSource = null;
            listBoxForTable.ItemsSource = db.Ингредиенты.Local.ToBindingList().OrderBy(o => o.Артикул);
        }

        private void addTableButton_Click(object sender, RoutedEventArgs e) // Кнопка открытия диалог. окна добавления записи
        {
            Ингредиенты addItem = new Ингредиенты();
            editWndiow = new EditWindowsForIngredients();
            editWndiow.addButton.Content = "Добавить";
            if (true == editWndiow.ShowDialog())
            {
                InsertData(addItem);
                addItem.Артикул = db.Ингредиенты.OrderByDescending(o => o.Артикул).FirstOrDefault().Артикул + 1;
                addItem.Дата = DateTime.Today;
                db.Ингредиенты.Add(addItem);
                db.SaveChanges();
            }
        }

        private void deleteTableButton_Click(object sender, RoutedEventArgs e) // Кнопка удаления записи с подверждением
        {
            if (System.Windows.Forms.MessageBox.Show("Вы хотите удалить запись?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes && selectedItem != null)
            {
                Ингредиенты itemToRemove = db.Ингредиенты.Where(o => o.Артикул == selectedItem.Артикул).FirstOrDefault();
                db.Ингредиенты.Remove(itemToRemove);
                db.SaveChanges();
            }

        }

        public void listBoxForTable_SelectionChanged(object sender, SelectionChangedEventArgs e) // Выбор нужной строки для взаимодействия кода с ней
        {
            selectedItem = listBoxForTable.SelectedItem as Ингредиенты;
        }

        private void editTableButton_Click(object sender, RoutedEventArgs e)
        {
            editWndiow = new EditWindowsForIngredients();                                                          
            editWndiow.addButton.Content = "Изменить";
            if (selectedItem != null)                                                                       
            {
                editWndiow.Артикул.Text = Convert.ToString(selectedItem.Артикул);
                editWndiow.Наименование.Text = selectedItem.Наименование;
                editWndiow.Единицы_измерения.Text = selectedItem.Единицы_измерения;
                editWndiow.Количество.Text = Convert.ToString(selectedItem.Количество);
                editWndiow.Тип.Text = selectedItem.Тип;
                editWndiow.Цена.Text = Convert.ToString(selectedItem.Цена);
                editWndiow.ГОСТ.Text = selectedItem.ГОСТ;
                editWndiow.Фасовка.Text = selectedItem.Фасовка;
                editWndiow.Характеристика.Text = selectedItem.Характеристика;
                editWndiow.Поставщик.Text = selectedItem.Поставщик;
                editWndiow.Дата.SelectedDate = selectedItem.Дата;

                if (true == editWndiow.ShowDialog())
                {
                    InsertData(selectedItem);
                    db.SaveChanges();
                    listBoxForTable.ItemsSource = null;
                    listBoxForTable.ItemsSource = db.Ингредиенты.Local.ToBindingList().OrderBy(o => o.Артикул);
                }
            }
        }

        private Ингредиенты InsertData(Ингредиенты insertItem)
        {
            insertItem.Наименование = editWndiow.Наименование.Text;
            insertItem.Единицы_измерения = editWndiow.Единицы_измерения.Text;
            insertItem.Количество = Convert.ToInt32(editWndiow.Количество.Text);
            insertItem.Тип = editWndiow.Тип.Text;
            insertItem.Цена = Convert.ToDecimal(editWndiow.Цена.Text);
            insertItem.ГОСТ = editWndiow.ГОСТ.Text;
            insertItem.Фасовка = editWndiow.Фасовка.Text;
            insertItem.Характеристика = editWndiow.Характеристика.Text;
            insertItem.Поставщик = editWndiow.Поставщик.Text;
            insertItem.Дата = editWndiow.Дата.SelectedDate;
            return insertItem;
        }
    }
}
