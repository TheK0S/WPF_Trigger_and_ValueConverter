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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee[] employees =
        {
            new Employee("Василий Пупкин", "Директор", 7000),
            new Employee("Петр Бубкин", "Операционный директор", 6000),
            new Employee("Генадий Бобров", "Менеджер", 5200),
            new Employee("Илья Козаков", "Менеджер по продажам", 5000),
            new Employee("Иван Бровкин", "Разработчик", 4000),
            new Employee("Максим Перепелица", "Разработчик", 3500),
            new Employee("Елена Воробей", "Разработчик", 1000),
            new Employee("Маруся Климова", "Разработчик", 900)
        };
        public MainWindow()
        {
            InitializeComponent();
            employeesTable.ItemsSource = employees;
        }
    }
}
