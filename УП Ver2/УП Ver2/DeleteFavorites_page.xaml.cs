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
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace УП_Ver2
{
    /// <summary>
    /// Логика взаимодействия для DeleteFavorites_page.xaml
    /// </summary>
    public partial class DeleteFavorites_page : Window
    {
        public DeleteFavorites_page()
        {
            InitializeComponent();
        }

        private void DeleteFavorites_Textbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        } //Ограничение ввода, вводить можно только цифры.

        private void DeleteFavorites_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DeleteFavorites_Textbox.Text == "")
            {
                MessageBox.Show("Сначало введите номер избранного.");
            } //Проверка на ввод данных
            else
            {
                int ID = Convert.ToInt32(DeleteFavorites_Textbox.Text); //Подключение к бд
                УП2Entities db = new УП2Entities();
                db.Избранное_пользователя.Load();
                var DeleteInfo = db.Избранное_пользователя
                        .Where(u => u.Номер_избранного == Convert.ToInt32(DeleteFavorites_Textbox.Text))
                        .FirstOrDefault();

                if (DeleteInfo == null)
                {
                    MessageBox.Show("Данных с таким номером не существует.");
                } //Проверка на наличие заметки в базе
                if (DeleteFavorites_Textbox.Text != "" && DeleteInfo != null)
                {
                    db.Избранное_пользователя.Remove(DeleteInfo);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно удалены.");
                    Close();
                } //Удаление заметок по номерам, если они существуют.
            }
        }
    }
}
