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
    /// Логика взаимодействия для AddFavorites_Page.xaml
    /// </summary>
    public partial class AddFavorites_Page : Window
    {
        public AddFavorites_Page()
        {
            InitializeComponent();
        }

        private void FinishAddFavorites_Click(object sender, RoutedEventArgs e)
        {
            int NumFavorites = Convert.ToInt32(Номер_избранного.Text);
            УП2Entities db = new УП2Entities();
            db.Избранное_пользователя.Load();
            var user = db.Избранное_пользователя
                .Where(u => u.Номер_избранного == NumFavorites)
                .FirstOrDefault();
            //Загрузка данных из БД

            if (user != null)
            {
                MessageBox.Show("Номер избранного уже занят");
            }  //Проверка на наличие уже существующей записи.

            if (Логин.Text == "" || Номер_избранного.Text == "" || Класс_ПО.Text == "")
            {
                MessageBox.Show("Все поля обязательны к заполнению");
            }  //Проверка на заполнение полей

            if (Логин.Text != "" && Номер_избранного.Text != "" && Класс_ПО.Text != "")
            {
                user = new Избранное_пользователя();
                user.Номер_избранного = Convert.ToInt32(Номер_избранного.Text);
                user.Логин = Логин.Text;
                user.Класс_ПО = Класс_ПО.Text;
                db.Избранное_пользователя.Add(user);
                db.SaveChanges();
                MessageBox.Show("'Избранное' добавлено успешно");
                Close();

            } // Создание новой записи в таблицу с передачей данных.
        }
    }
}
