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

namespace PiConsole
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int f = int.Parse(tb1.Text);
            double res1 = 0.5 + Math.Sqrt(0.5) / 2.0;
            double P = Math.Sqrt(0.5) * Math.Sqrt(res1);
            for (int i = 0; i <= f; i++)
            {
                res1 = 0.5 + (Math.Sqrt(res1) / 2.0);
                P = P * Math.Sqrt(0.5 + (Math.Sqrt(res1) / 2.0));
            }
            P = 2 / P;
            tb2.Text = P.ToString();

            double s = 1.0, t = 2.0;
            double res2 = 1.0;
            for (int l = 0; l <= f; l++)
            {
                res2 = res2 * (s * (s + 2)) / (t * t);
                s += 2;
                t += 2;

            }
            res2 = 2 / res2;           
            tb3.Text = res2.ToString();

            double res3 = 1.0;
            double x = 1.0;
            for (int i = 0; i <= f; i++)
            {
                res3 = 1.0 + 1.0 / (2.0 + x / (x + 2.0) * (x + 2.0));
                x++;
            }
            res3 = 4.0 / res3;
            tb4.Text = res3.ToString();

            double res4 = 0.0;
            double c = 1.0;
            for (int i = 0; i <= f; i++)
            {
                res4 = res4 + (1.0 / c - 1.0 / (c + 2.0));
                c += 4;
            }
            res4 = 4 * res4;           
            tb5.Text = res4.ToString();
        }
    }
}
