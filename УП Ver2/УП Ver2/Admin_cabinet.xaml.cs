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
    /// Логика взаимодействия для Admin_cabinet.xaml
    /// </summary>
    public partial class Admin_cabinet : Window
    {
        public Admin_cabinet()
        {
            InitializeComponent();
        }

        private void Registration_Click(object sender, RoutedEventArgs e) 
        {
            Registration_page registration_page = new Registration_page();
            registration_page.Show();

        } /*Регистрация нового пользователя*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UsersDataBase.Visibility = Visibility.Collapsed;
            DataBase.Visibility = Visibility.Visible;
            УП2Entities db = new УП2Entities();
            db.Name.Load();
            var query =
            from t in db.Name
            select new { t.ID_Названия, t.Название, t.Класс_ПО, t.Дата};

            DataBase.ItemsSource = query.ToList();

        } /*Вывод базы данных ПО*/

        private void ShowAllUsers_Click(object sender, RoutedEventArgs e) 
        {
            UsersDataBase.Visibility = Visibility.Visible;
            DataBase.Visibility = Visibility.Collapsed;
            УП2Entities db = new УП2Entities();
            db.UserData.Load();
            var queryUser =
            from s in db.UserData
            select new { s.login, s.pass, s.Имя, s.Фамилия, s.Телефон,  s.Роль};

            UsersDataBase.ItemsSource = queryUser.ToList();
        } /*Вывод базы данных пользователей*/

        private void AddBase_Click(object sender, RoutedEventArgs e) 
        {
            AddBase OpenAddBasePage = new AddBase();
            OpenAddBasePage.Show();
        } /*Вывод окна для добавления новой записи в БД ПО*/

        private void DeleteBase_Click(object sender, RoutedEventArgs e)
        {
            Delete_Base DeletePage = new Delete_Base();
            DeletePage.Show();
        } /*Вывод окна для удаления записи в БД ПО*/

       
        
        
        //4 события для отображения кнопки "Изменить аватар"
        private void EditPhoto_MouseEnter(object sender, MouseEventArgs e)
        {
            EditPhoto.Visibility = Visibility.Visible;
        }
        private void EditPhoto_MouseLeave(object sender, MouseEventArgs e)
        {
            EditPhoto.Visibility = Visibility.Hidden;
        }
        private void EditPhoto_MouseEnter_1(object sender, MouseEventArgs e)
        {
            EditPhoto.Visibility = Visibility.Visible;
        }
        private void EditPhoto_MouseLeave_1(object sender, MouseEventArgs e)
        {
            EditPhoto.Visibility = Visibility.Hidden;
        }
        



        private void EditPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ChangePhoto = new OpenFileDialog();
            if (ChangePhoto.ShowDialog(this) == true)
            {
                Photo.Source = new BitmapImage(new Uri(ChangePhoto.FileName));    
            }

        }  //Изменения изображения аватарки посредством проводника Windows

        private void EditUserInfo_Click(object sender, RoutedEventArgs e)
        {
            EditUserInfo_Page OpenEditUserInfo_Page = new EditUserInfo_Page();
            OpenEditUserInfo_Page.Show();
        } //Открытие окна изменения данных пользователей
    }
}
