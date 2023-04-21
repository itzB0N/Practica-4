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

namespace dop1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(polA.Text);
            int vt = 0;
            int pr = 0;
            string z = "учебных заданий";
            if(10 <= a && a <= 19)
            {
                vt = a;
            }
            else if(20 <= a && a <=40)
            {
                vt = a % 10;
                pr = a / 10;
            }
            else
            {
                vt = 56;
                pr = 5;
            }
            string t,s;
            switch (vt)
            {
                case 0:
                    t = "";
                    break;
                case 1:
                    t = "один";
                    break;
                case 2:
                    t = "два";
                    break;
                case 3:
                    t = "три";
                    break;
                case 4:
                    t = "четыре";
                    break;
                case 5:
                    t = "пять";
                    break;
                case 6:
                    t = "шесть";
                    break;
                case 7:
                    t = "семь";
                    break;
                case 8:
                    t = "восемь";
                    break;
                case 9:
                    t = "девять";
                    break;
                case 10:
                    t = "Десять";
                    break;
                case 11:
                    t = "Одинадцать";
                    break;
                case 12:
                    t = "Двенадцать";
                    break;
                case 13:
                    t = "Тринадцать";
                    break;
                case 14:
                    t = "Четырнадцать";
                    break;
                case 15:
                    t = "Пятнадцать";
                    break;
                case 16:
                    t = "Шестьнадцать";
                    break;
                case 17:
                    t = "Семнадцать";
                    break;
                case 18:
                    t = "Восемьнадцать";
                    break;
                case 19:
                    t = "Девятнадцать";
                    break;
                default:
                    t = "недопустимое число";
                    Otv.Content = $"{t}";
                    break;
            }
            switch(pr)
            {
                case 0:
                    s = "";
                    Otv.Content = $"{t} {z}";
                    break;
                case 2:
                    s = "Двадцать";
                    Otv.Content = $"{s} {t} {z}";
                    break;
                case 3:
                    s = "Тридцать";
                    Otv.Content = $"{s} {t} {z}";
                    break;
                case 4:
                    s = "Сорок";
                    Otv.Content = $"{s} {z}";
                    break;
                default:
                    s = "недопустимое число";
                    Otv.Content = $"{s}";
                    break;
            }      
        }
    }
}
