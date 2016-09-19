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

namespace QuadEquationWPF
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
            int a = int.Parse(tb1.Text);
            int b = int.Parse(tb2.Text);
            int c = int.Parse(tb3.Text);
            tb4.Visibility = Visibility.Hidden;
            tb5.Visibility = Visibility.Hidden;
            double D;
            D = b * b - 4 * a * c;
            if (D > 0)
            {
                tb4.Visibility = Visibility.Visible;
                tb5.Visibility = Visibility.Visible;
                double x1, x2;
                x1 = ((-b) + Math.Sqrt(D)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(D)) / (2 * a);
                tb4.Text = x1.ToString();
                tb5.Text = x2.ToString();
            }
            else if (D == 0)
            {
                tb4.Visibility = Visibility.Visible;
                l2.Visibility = Visibility.Hidden;
                double x;
                x = (-b) / (2 * a);
                tb4.Text = x.ToString();
            }
            else
            {
                l1.Visibility = Visibility.Hidden;
                l2.Visibility = Visibility.Hidden;
                MessageBox.Show("Решений не существует.");
            }
        }
    }
}
