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
    /// Логика взаимодействия для Delete_Base.xaml
    /// </summary>
    public partial class Delete_Base : Window
    {
        public Delete_Base()
        {
            InitializeComponent();
        }

        private void DeleteBaseButton_Click(object sender, RoutedEventArgs e)
        {
            if (DeleteBaseText.Text == "") 
            {
                MessageBox.Show("Сначало введите ID названия.");
            } //Проверка на ввод данных
            else
            {
                int ID = Convert.ToInt32(DeleteBaseText.Text); //Подключение к бд
                УП2Entities db = new УП2Entities();
                db.Name.Load();
                var DeleteInfo = db.Name
                        .Where(u => u.ID_Названия == ID)
                        .FirstOrDefault();

                if (DeleteInfo == null) 
                {
                    MessageBox.Show("Данные с таким ID не существуют.");
                } //Проверка на наличие ID в базе
                if (DeleteBaseText.Text != "" && DeleteInfo != null) 
                {
                    db.Name.Remove(DeleteInfo);
                    db.SaveChanges();
                    MessageBox.Show("Данные успешно удалены.");
                    Close();
                } //Удаление данных по ID, если они существуют.
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
