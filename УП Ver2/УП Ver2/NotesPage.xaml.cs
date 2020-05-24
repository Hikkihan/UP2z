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
    /// Логика взаимодействия для NotesPage.xaml
    /// </summary>
    public partial class NotesPage : Window
    {
        public NotesPage()
        {
            InitializeComponent();
        }

        private void ShowNotes_Click(object sender, RoutedEventArgs e)
        {
            NotesBase.Visibility = Visibility.Visible;
            УП2Entities db = new УП2Entities();
            db.Заметки_пользователя.Load();
            var query =
            from t in db.Заметки_пользователя
            .Where(u => u.Логин == LoginBox.Text)
            select new { t.Номер_заметки, t.Логин, t.Класс_ПО};
            NotesBase.ItemsSource = query.ToList();


        }  //Открыть таблицу заметок

        private void AddNotes_Click(object sender, RoutedEventArgs e)
        {
            AddNotesPage OpenAddNotesPage = new AddNotesPage();
            OpenAddNotesPage.Show();
        } //Открыть окно добавления заметок

        private void Button_Click(object sender, RoutedEventArgs e) 
        {
            DeleteNotes deleteNotes_page = new DeleteNotes();
            deleteNotes_page.Show();
        } //Открыть окно удаления заметок
    }
}
