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
    /// Логика взаимодействия для IndexEdit.xaml
    /// </summary>
    public partial class IndexEdit : Page
    {
        public Manager Manager { get; set; }
        public List<Salary> salaries { get; set; }


        public Salary m { get; set; } = new Salary();

        public IndexEdit(Manager manager)
        {
            InitializeComponent();
            DataContext = this;
            Manager = manager;
            salaries = Core.db.Salaries.ToList();
            foreach(Salary salary in salaries)
            {
                if(salary.Менеджер == manager.ID)
                {
                    m = salary;
                }
            }
         
        }
    }
}
