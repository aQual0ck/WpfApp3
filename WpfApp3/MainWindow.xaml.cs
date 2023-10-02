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

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button2.Background = new SolidColorBrush(Colors.Green);
            Button2.Foreground = new SolidColorBrush(Colors.Red);

            Button4.Background = new SolidColorBrush(Colors.Black);
            Button4.Foreground = new SolidColorBrush(Colors.White);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btn1.Content = "Bye World";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Button4.Background = new SolidColorBrush(Colors.White);
            Button4.Foreground = new SolidColorBrush(Colors.Black);
        }
    }
}
