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
    /// Логика взаимодействия для Registration_page.xaml
    /// </summary>
    public partial class Registration_page : Window
    {
        public Registration_page()
        {
            
            InitializeComponent();
        }

        private void Зарегистрироваться_Click(object sender, RoutedEventArgs e)
        {
            string NewName   =  Имя.Text;
            string NewFemale =  Фамилия.Text;
            string NewNumber =  Телефон.Text;
            string NewLogin  =  Логин.Text;
            string NewPass   =  Пароль.Text;
            
            
            УП2Entities db = new УП2Entities();
            db.UserData.Load();

            var user = db.UserData
                .Where(u => u.login == NewLogin)
                .FirstOrDefault();
            //Загрузка данных из БД

            if (user != null)
            {
                MessageBox.Show("Этот логин уже занят.");
            }  //Проверка на наличие уже существующего пользователя.

            if (Логин.Text == "" || Пароль.Text == "" || Имя.Text == "" || Фамилия.Text == "") 
            {
                MessageBox.Show("Поля 'Имя','Фамилия','Логин','Пароль' обязательны к заполнению!");
            }  //Проверка на заполнение полей

            if ((user == null) && (Логин.Text != "" && Пароль.Text != "" && Имя.Text != "" && Фамилия.Text != ""))
            {
                user = new UserData();
                user.Имя = NewName;
                user.Фамилия = NewFemale;
                user.login = NewLogin;
                user.pass = NewPass;
                user.Роль = "Пользователь";
                if (NewNumber == "")
                    NewNumber = "000";
                user.Телефон = NewNumber;
                db.UserData.Add(user);
                db.SaveChanges();
                MessageBox.Show("Регистрация завершена успешно.");
                Close();

            } //Добавление нового пользователя в БД.
        }

        private void Телефон_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
