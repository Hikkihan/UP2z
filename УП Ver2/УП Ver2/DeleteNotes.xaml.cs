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
    /// Логика взаимодействия для DeleteNotes.xaml
    /// </summary>
    public partial class DeleteNotes : Window
    {
        public DeleteNotes()
        {
            InitializeComponent();
        }

        private void DeleteNotes_Textbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void DeleteNotes_Button_Click(object sender, RoutedEventArgs e)
        {
            if (DeleteNotes_Textbox.Text == "")
            {
                MessageBox.Show("Сначало введите номер заметки.");
            } //Проверка на ввод данных
            else
            {
                int ID = Convert.ToInt32(DeleteNotes_Textbox.Text); //Подключение к бд
                УП2Entities db = new УП2Entities();
                db.Заметки_пользователя.Load();
                var DeleteInfo = db.Заметки_пользователя
                        .Where(u => u.Номер_заметки == Convert.ToInt32(DeleteNotes_Textbox.Text))
                        .FirstOrDefault();

                if (DeleteInfo == null)
                {
                    MessageBox.Show("Данные с таким ID не существуют.");
                } //Проверка на наличие заметки в базе
                if (DeleteNotes_Textbox.Text != "" && DeleteInfo != null)
                {
                    db.Заметки_пользователя.Remove(DeleteInfo);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно удалены.");
                    Close();
                } //Удаление заметок по номерам, если они существуют.
            }
        }
    }
}
