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

namespace WPF_Shovkun_PR3
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

        private void Pusk_Click(object sender, RoutedEventArgs e)
        {
            double x = Convert.ToDouble(X.Text);
            Itog.Text = "Результат:" + Environment.NewLine;
            Itog.Text += "При X = " + X.Text + Environment.NewLine;

            int n = 0;
            double z;

             if (RB2.IsChecked == true) n = 1;
             else if (RB3.IsChecked == true) n = 2;

            switch (n)
            {              
                case 0:
                    if (x >= 0 && x <= 3)
                    {
                        z = x * x;
                    }

                    else 
                        z = x * x;                                      
                    Itog.Text += "Z = " + Convert.ToString(z) + Environment.NewLine;
                    break;
                case 1:
                    if (x > 3 && x < 0)
                    {
                        z = 4 * x;
                    }
                    else
                        z = 4 * x;
                    Itog.Text += "Z = " + Convert.ToString(z) + Environment.NewLine;
                    break;
            }

        }

        private void Clean_Click(object sender, RoutedEventArgs e)
        {
            X.Clear();
            Itog.Clear();
        }
    }
}
