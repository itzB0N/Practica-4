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

namespace dop2
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
            int sot = 0;
            int dec = 0;
            int ed = 0;
            string t = "",s = "",h = "";
            
            if (99 < a && a < 1000)
            {
                ed = a % 10;
                dec = (a % 100) / 10;
                sot = a / 100;
            }
            else
            {
                Otv.Content = $"Не допустимое число";
            }
            switch(ed)
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
            }
            switch (dec)
            {
                case 1:
                    s = "десять";
                    Otv.Content = $"{s}";
                    break;
                case 2:
                    s = "двадцать";
                    Otv.Content = $"{s}";
                    break;
                case 3:
                    s = "тридцать";
                    Otv.Content = $"{s}";
                    break;
                case 4:
                    s = "сорок";
                    Otv.Content = $"{s}";
                    break;
                case 5:
                    s = "пятьдесят";
                    Otv.Content = $"{s}";
                    break;
                case 6:
                    s = "шестьдесят";
                    Otv.Content = $"{s}";
                    break;
                case 7:
                    s = "семдесят";
                    Otv.Content = $"{s}";
                    break;
                case 8:
                    s = "восемьдесят";
                    Otv.Content = $"{s}";
                    break;
                case 9:
                    s = "девяносто";
                    Otv.Content = $"{s}";
                    break;
            }
            switch(sot)
            {
                case 1:
                    h = "сто";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 2:
                    h = "двесте";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 3:
                    h = "триста";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 4:
                    h = "четыреста";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 5:
                    h = "пятьсот";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 6:
                    h = "шестьсот";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 7:
                    h = "семьсот";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 8:
                    h = "восемьсот";
                    Otv.Content = $"{h} {s} {t}";
                    break;
                case 9:
                    h = "девятьсот";
                    Otv.Content = $"{h} {s} {t}";
                    break;
            }
        }
    }
}
