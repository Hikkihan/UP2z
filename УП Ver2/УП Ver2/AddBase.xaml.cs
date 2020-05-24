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
    /// Логика взаимодействия для AddBase.xaml
    /// </summary>
    public partial class AddBase : Window
    {
        public AddBase()
        {
            
            InitializeComponent();
        }

        private void AddBase_Click(object sender, RoutedEventArgs e) 
        {
            
            if (ID.Text == "" || Название.Text == "" || Класс_ПО.Text == "" || Дата.Text == "")
            {
                MessageBox.Show("Поля 'ID Названия','Название','Класс_ПО','Дата' обязательны к заполнению!");
                Close();
            } //Проверка на заполнение полей
            else
            {
                УП2Entities db = new УП2Entities(); //Подключение к базе данных
                db.Name.Load();
                int NewID = Convert.ToInt32(ID.Text);
                var NewInfo = db.Name
                        .Where(u => u.ID_Названия == NewID)
                        .FirstOrDefault();
                if (NewInfo != null)  
                {
                    MessageBox.Show("Данные с таким ID уже существуют.");
                } //Проверка на наличие данных по ID
                if ((NewInfo == null) && (ID.Text != "" && Название.Text != "" && Класс_ПО.Text != "" && Дата.Text != "")) 
                {

                    NewID = Convert.ToInt32(ID.Text);
                    string NewName = Название.Text;
                    string Class = Класс_ПО.Text;
                    DateTime NewData = Convert.ToDateTime(Дата.Text);
                    NewInfo = new Name();
                    NewInfo.ID_Названия = NewID;
                    NewInfo.Название = NewName;
                    NewInfo.Класс_ПО = Class;
                    NewInfo.Дата = NewData;
                    db.Name.Add(NewInfo);
                    db.SaveChanges();
                    MessageBox.Show("Новые данные введены успешно.");
                    Close();
                } //Проверка на заполнение полей и добавление данных в бд.
            }
        }


        private void ID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        } //Ограничение ввода, вводить можно только цифры.


        private void Дата_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DatePicker datePickerFor2020 = new DatePicker();
            datePickerFor2020.SelectedDate = new DateTime(2020, 3, 23);
            datePickerFor2020.DisplayDateStart = new DateTime(2009, 1, 1);
            datePickerFor2020.DisplayDateEnd = new DateTime(2020, 12, 31);
            datePickerFor2020.SelectedDateFormat = DatePickerFormat.Long;
            datePickerFor2020.FirstDayOfWeek = DayOfWeek.Monday;
        }  //Выбор даты, прописывание диапазона выбора дат, макет даты.
    }
}
