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
using static System.Math;

namespace dop3
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
            int b = Convert.ToInt32(polB.Text);
            if (a > 0)
            {
                while (b != 0)
                {
                    b = a % (a = b);
                }
                Otv.Content = $"{a}";
            }
            else
            {
                Otv.Content = $"число меньше 1";
            }
        }
    }
}
