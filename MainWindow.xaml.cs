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

namespace WpfApp26
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
            try
            {
                //Задание 1
                int DD = Convert.ToInt32(polA.Text);
                int MM = Convert.ToInt32(polB.Text);
                switch(MM)
                {

                    case 1:
                        if(1<=DD && DD < 31)
                        {
                            Otv.Content = $"{DD + 1} Январь";
                        }
                        else if(DD == 31)
                        {
                            Otv.Content = $"{1} Февраля";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        } 
                        break;

                    case 2:
                        if (1 <= DD && DD < 28)
                        {
                            Otv.Content = $"{DD + 1} Февраль";
                        }
                        else if (DD == 28)
                        {
                            Otv.Content = $"{1} Март";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 3:
                        if (1 <= DD && DD < 31)
                        {
                            Otv.Content = $"{DD + 1} Март";
                        }
                        else if (DD == 31)
                        {
                            Otv.Content = $"{1} Апрель";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 4:
                        if (1 <= DD && DD < 30)
                        {
                            Otv.Content = $"{DD + 1} Апрель";
                        }
                        else if (DD == 30)
                        {
                            Otv.Content = $"{1} Май";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 5:
                        if (1 <= DD && DD < 31)
                        {
                            Otv.Content = $"{DD + 1} Май";
                        }
                        else if (DD == 31)
                        {
                            Otv.Content = $"{1} Июнь";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 6:
                        if (1 <= DD && DD < 30)
                        {
                            Otv.Content = $"{DD + 1} Июнь";
                        }
                        else if (DD == 30)
                        {
                            Otv.Content = $"{1} Июль";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 7:
                        if (1 <= DD && DD < 31)
                        {
                            Otv.Content = $"{DD + 1} Июль";
                        }
                        else if (DD == 31)
                        {
                            Otv.Content = $"{1} Август";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 8:
                        if (1 <= DD && DD < 31)
                        {
                            Otv.Content = $"{DD + 1} Август";
                        }
                        else if (DD == 31)
                        {
                            Otv.Content = $"{1} Сентябрь";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 9:
                        if (1 <= DD && DD < 30)
                        {
                            Otv.Content = $"{DD + 1} Сентябрь";
                        }
                        else if (DD == 30)
                        {
                            Otv.Content = $"{1} Октябрь";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 10:
                        if (1 <= DD && DD < 31)
                        {
                            Otv.Content = $"{DD + 1} Октябрь";
                        }
                        else if (DD == 31)
                        {
                            Otv.Content = $"{1} Ноябрь";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 11:
                        if (1 <= DD && DD < 30)
                        {
                            Otv.Content = $"{DD + 1} Ноябрь";
                        }
                        else if (DD == 30)
                        {
                            Otv.Content = $"{1} Декабрь";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;

                    case 12:
                        if (1 <= DD && DD < 31)
                        {
                            Otv.Content = $"{DD + 1} Декабрь";
                        }
                        else if (DD == 31)
                        {
                            Otv.Content = $"{1} Январь";
                        }
                        else
                        {
                            Otv.Content = $"Недопустимое число";
                        }
                        break;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        }
    }
