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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncalcola_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(txtnumero1.Text);
            double b = double.Parse(txtnumero2.Text);
            double max = Math.Max(a, b);
            lblmax.Content = $"massimo:{max}";
            double min = Math.Min(a, b);
            lblmin.Content = $"minimo:{min}";
            double media = (a + b) / 2;
            lblmedia.Content = $"media:{media}";
        }
    }
}
