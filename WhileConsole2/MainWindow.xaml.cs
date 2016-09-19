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

namespace WhileConsole2
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
            double P = double.Parse(tb1.Text);
            int K = 1;
            double S = 1.0;
            while (S <= 200.0)
            {
                S = 10 * Math.Pow((1 + P / 100), K);
                K++;
            }
            tb2.Text = S.ToString();
            tb3.Text = K.ToString();
        }
    }
}
