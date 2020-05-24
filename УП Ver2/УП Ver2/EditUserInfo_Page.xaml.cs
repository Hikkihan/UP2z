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
    /// Логика взаимодействия для EditUserInfo_Page.xaml
    /// </summary>
    public partial class EditUserInfo_Page : Window
    {
        public EditUserInfo_Page()
        {
            InitializeComponent();
        }

        private void ContinueEditUserInfo_Click(object sender, RoutedEventArgs e)
        {
            if (LoginUser.Text == "")
            {
                MessageBox.Show("Сначало введите логин пользователя.");
            } //Проверка на ввод данных
            else
            {
                
                УП2Entities db = new УП2Entities();
                db.UserData.Load();
                var CheckLogin = db.UserData
                        .Where(u => u.login == LoginUser.Text)
                        .FirstOrDefault();
                if (CheckLogin == null)
                {
                    MessageBox.Show("Пользователя с таким логином не существует!");
                } //Проверка на наличие логина в базе
                if (LoginUser.Text != "" && CheckLogin != null)
                {
                    NameUser.IsEnabled = true ;
                    FemaleUser.IsEnabled = true;
                    PhoneUser.IsEnabled = true;
                    EndEditUserInfo.IsEnabled = true;
                    ContinueEditUserInfo.IsEnabled = false;
                } 
            }
        }

        private void EndEditUserInfo_Click(object sender, RoutedEventArgs e)
        {
            string NewName = NameUser.Text;
            string NewFemale = FemaleUser.Text;
            УП2Entities db = new УП2Entities();
            db.UserData.Load();
            var EditUser = db.UserData
                        .Where(u => u.login == LoginUser.Text)
                        .FirstOrDefault();

            if (NameUser.Text == "" || FemaleUser.Text == "")
            {
                MessageBox.Show("Поля 'Имя' и 'Фамилия' обязательны к заполнению!");
            } //Проверка на ввод данных
            if (EditUser != null)
            {
                EditUser.Имя = NewName;
                EditUser.Фамилия = NewFemale;
                if (PhoneUser.Text == "")
                    PhoneUser.Text = "000";
                EditUser.Телефон = PhoneUser.Text;
                db.SaveChanges();
                MessageBox.Show("Изменения завершены успешно.");
                Close();
            } //Внесение изменений.

        }

        private void PhoneUser_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }//ограничение ввода, вводить можно только цифры.
    }
}

