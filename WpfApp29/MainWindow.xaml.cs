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

namespace WpfApp29
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
            int n = Convert.ToInt32(polB.Text);
            switch (n)
            {
                case 1:
                    double a = Convert.ToDouble(polA.Text);
                    double R1 = a + Math.Sqrt(3 / 4);
                    double S = Math.Pow(a, 2) * Math.Sqrt(3 / 4);
                    double R2 = 2 * R1;
                    Otv.Content = $"1 = {a}; 2 = {R1}; 3 = {R2}; 4 = {S}";
                    break;

                case 2:
                    R1 = Convert.ToDouble(polA.Text);
                    a = R1 - Math.Sqrt(3 / 4);
                    S = Math.Pow(a, 2) * Math.Sqrt(3 / 4);
                    R2 = 2 * R1;
                    Otv.Content = $"1 = {a}; 2 = {R1}; 3 = {R2}; 4 = {S}";
                    break;
                case 3:
                    R2 = Convert.ToDouble(polA.Text);
                    R1 = R2 / 2;
                    a = R1 - Math.Sqrt(3 / 4);
                    S = Math.Pow(a, 2) * Math.Sqrt(3 / 4);
                    Otv.Content = $"1 = {a}; 2 = {R1}; 3 = {R2}; 4 = {S}";
                    break;
                case 4:
                    S = Convert.ToDouble(polA.Text);
                    a = Math.Sqrt(S / Math.Sqrt(3 / 4));
                    R1 = a + Math.Sqrt(3 / 4);
                    R2 = 2 * R1;
                    Otv.Content = $"1 = {a}; 2 = {R1}; 3 = {R2}; 4 = {S}";
                    break;
                default:
                    Otv.Content = $"Не допустимы значения";
                    break;
            }

            






        }
    }
}
