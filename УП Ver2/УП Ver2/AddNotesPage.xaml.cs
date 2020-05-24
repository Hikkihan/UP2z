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
using Microsoft.Win32;
using System.IO;

namespace УП_Ver2
{
    /// <summary>
    /// Логика взаимодействия для AddNotesPage.xaml
    /// </summary>
    public partial class AddNotesPage : Window
    {
        public AddNotesPage()
        {
            InitializeComponent();
        }

        private void FinishAddNotes_Click(object sender, RoutedEventArgs e)
        {
            int NumNotes = Convert.ToInt32(НомерЗаметки.Text);
            УП2Entities db = new УП2Entities();
            db.Заметки_пользователя.Load();
            var user = db.Заметки_пользователя
                .Where(u => u.Номер_заметки == NumNotes)
                .FirstOrDefault();
            //Загрузка данных из БД

            if (user != null)
            {
                MessageBox.Show("Номер заметки уже занят");
            }  //Проверка на наличие уже существующей записи.

            if (Логин.Text == "" || НомерЗаметки.Text == "" || Класс_ПО.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению");
            }  //Проверка на заполнение полей

            if ((user == null) && (Логин.Text != "" && НомерЗаметки.Text != ""&& Класс_ПО.Text != ""))
            {
                user = new Заметки_пользователя();
                user.Номер_заметки = Convert.ToInt32(НомерЗаметки.Text);
                user.Логин = Логин.Text;
                user.Класс_ПО = Класс_ПО.Text;
                db.Заметки_пользователя.Add(user);
                db.SaveChanges();
                MessageBox.Show("Заметка добавлена успешно");
                Close();

            } //Добавление новой записи в таблицу с передачей данных.
        }
    }
}
