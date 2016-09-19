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

namespace TriangleConsole
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

           
            double x1 = double.Parse(tb1.Text);
            double y1 = double.Parse(tb2.Text);
            double x2 = double.Parse(tb3.Text);
            double y2 = double.Parse(tb4.Text);
            double x3 = double.Parse(tb5.Text);
            double y3 = double.Parse(tb6.Text);
            double x = double.Parse(tb7.Text);
            double y = double.Parse(tb8.Text);
            

            double a = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
            double b = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
            double c = (x3 - x) * (y1 - y3) - (x1 - x3) * (y3 - y);

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                lb1.Visibility = Visibility.Visible;           
            else
                lb2.Visibility = Visibility.Visible;
            

        }
    }
}
