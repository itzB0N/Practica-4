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

namespace Practica_4_N6
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
            int N = Convert.ToInt32(polA.Text);
            int f;
            bool b = true;
           if(N > 0)
            {
                while(b == true)
                {
                    f = N % 10;
                    if (f == 1)
                    {
                        Otv.Content = $"true";
                        b = false;
                    }
                    else if(N == 0)
                    {
                        Otv.Content = $"false";
                        b = false;
                    }
                    else
                    {
                        N /= 10;
                        b = true;
                    }
                }
            }
            else
            {
                Otv.Content = $"Число меньше нуля";
            }     
        }
    }
}
