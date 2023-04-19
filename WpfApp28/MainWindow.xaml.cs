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

namespace WpfApp28
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }
        private void OK_Click(object sender, RoutedEventArgs e)
        {
            int mast = Convert.ToInt32(polA.Text);
            int number = Convert.ToInt32(polB.Text);
            string masti;
            string N;
 
            switch (mast)
            {

                case 1:
                    masti = "Пики";
                    Otv1.Content = masti;
                    break;
                case 2:
                    masti = "Трефы";
                    Otv1.Content = masti;
                    break;
                case 3:
                    masti = "Бубны";
                    Otv1.Content = masti;
                    break;
                case 4:
                    masti = "Черви";
                    Otv1.Content = masti;
                    break;
                default:
                    Otv1.Content = "Нет такой масти";
                    break;


            }
            switch (number)
            {
                case 6:
                    N = "Шестёрка";
                    Otv.Content = N;
                    break;
                case 7:
                    N = "Семёрка";
                    Otv.Content = N;
                    break;
                case 8:
                    N = "Восмёрка";
                    Otv.Content = N;
                    break;
                case 9:
                    N = "Девятка";
                    Otv.Content = N;
                    break;
                case 10:
                    N = "Десятка";
                    Otv.Content = N;
                    break;
                case 11:
                    N = "Валет";
                    Otv.Content = N;
                    break;
                case 12:
                    N = "Дама";
                    Otv.Content = N;
                    break;
                case 13:
                    N = "Король";
                    Otv.Content = N;
                    break;
                case 14:
                    N = "Туз";
                    Otv.Content = N;
                    break;
                default:
                    Otv.Content = "Нет такого номера";
                    break;
            }

        }
    }
}
