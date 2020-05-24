using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Entity;
using System.Linq;

namespace УП_Ver2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string logloginuser;
       
        public MainWindow()
        {
            InitializeComponent();
        }

        [System.Obsolete]
        private void Button_Click(object sender, RoutedEventArgs e)
        {
             string loginUser = loginField.Text;    //Подключение к базе данных
            string passUser = passField.Text;       //Подключение к базе данных

            УП2Entities db = new УП2Entities();
            db.UserData.Load(); //Подключение к базе данных
            var user = db.UserData
                .Where(u => u.login == loginUser && u.pass == passUser)
                .FirstOrDefault();
            //Сравнение логина и пароля 
            
            if (user == null) 
            {
                MessageBox.Show("Логин или пароль введены неверно!");
            } //Проверка ввода логина и пароля

            if (user != null) 
            {
                if (user != null && user.Роль != "Администратор")
                {
                    User_cabinet user_cabinet = new User_cabinet();
                    user_cabinet.Show();
                    Close();

                } //Проверка роли пользователя
                if (user != null && user.Роль == "Администратор") 
                {
                    Admin_cabinet admin_cabinet = new Admin_cabinet();
                    admin_cabinet.Show();
                    
                    Close();
                }//Проверка роли администратора

            }  //Проверка на наличие пользователя в бд.

        }


        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration_page registration_page = new Registration_page(); 
            registration_page.Show();

        } //Открытие окна регистрации нового пользователя
    }
}
