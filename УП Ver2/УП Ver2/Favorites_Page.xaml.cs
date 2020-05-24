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
    /// Логика взаимодействия для Favorites_Page.xaml
    /// </summary>
    public partial class Favorites_Page : Window
    {
        public Favorites_Page()
        {
            InitializeComponent();
        }

        private void DeleteFavorites_Click(object sender, RoutedEventArgs e)
        {
            DeleteFavorites_page OpenDeleteFavorites_Page = new DeleteFavorites_page();
            OpenDeleteFavorites_Page.Show();
        } //Открыть окно удаления избранного

        private void AddFavorites_Click(object sender, RoutedEventArgs e)
        {
            AddFavorites_Page OpenAddFavorites_Page = new AddFavorites_Page();
            OpenAddFavorites_Page.Show();
        } //Открыть окно добавления избранного

        private void ShowFavorites_Click(object sender, RoutedEventArgs e)
        {
            NotesBase.Visibility = Visibility.Visible;
            УП2Entities db = new УП2Entities();
            db.Избранное_пользователя.Load();
            var query =
            from t in db.Избранное_пользователя
            .Where(u => u.Логин == LoginBox.Text)
            select new { t.Номер_избранного, t.Логин, t.Класс_ПО};
            NotesBase.ItemsSource = query.ToList();

        } //Открыть таблицу избранного
    }
}