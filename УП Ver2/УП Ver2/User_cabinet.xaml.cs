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
    /// Логика взаимодействия для User_cabinet.xaml
    /// </summary>
    public partial class User_cabinet : Window
    {
        public User_cabinet()
        {
            InitializeComponent();
        }

        private void OpenBase_Click(object sender, RoutedEventArgs e)
        {
            DataBase.Visibility = Visibility.Visible;
            УП2Entities db = new УП2Entities();
            db.Name.Load();
            var query =
            from t in db.Name
            select new { t.ID_Названия, t.Название, t.Класс_ПО, t.Дата };
            DataBase.ItemsSource = query.ToList();

        } //Кнопка открытия таблицы


        //События для отображения кнопки "изменить аватар"
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

        } //Кнопка для изменения изображения аватарки посредством проводника Windows

        private void PrintBase_Click(object sender, RoutedEventArgs e)
        {
            PrintPage OpenPrintPage = new PrintPage();
            OpenPrintPage.Show();
        } //Кнопка открытия окна с отчётом.

        private void Notes_Click(object sender, RoutedEventArgs e)
        {
            NotesPage OpenNotesPage = new NotesPage();
            OpenNotesPage.Show();
        } //Кнопка открытия окна с заметками.

        private void Favourites_Click(object sender, RoutedEventArgs e)
        {
            Favorites_Page OpenFavorites_Page = new Favorites_Page();
            OpenFavorites_Page.Show();
        } //Кнопка открытия окна с избранного.
    }
}
