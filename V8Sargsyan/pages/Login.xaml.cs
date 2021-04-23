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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace V8Sargsyan.pages
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
            executors = Core.db.Executors.ToList();
            managers = Core.db.Managers.ToList();
        }
        public List<Executor> executors { get; set; }
        public List<Manager> managers { get; set; }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (login.Text == "" && passwordBox.Password == "")
            {
                MessageBox.Show("Поля не заполнены!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                foreach (Manager manager in managers) 
                { 
                            if ((login.Text == manager.Логин) && (passwordBox.Password == login.Text))
                            {
                                NavigationService?.Navigate(new IndexEdit(manager));
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                }
                    
                

            }
        }

    }
}
