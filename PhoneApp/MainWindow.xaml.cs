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

namespace PhoneApp
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
        private void InputNum(string num)
        {

            PhoneScreen.Text += num;
        }
        private void One_Click(object sender, RoutedEventArgs e)
        {
            InputNum("1");
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            InputNum("2");
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            InputNum("3");
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            InputNum("4");
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            InputNum("5");
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            InputNum("6");
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            InputNum("7");
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            InputNum("8");
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            InputNum("9");
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            InputNum("0");
        }

        private void Asterisk_Click(object sender, RoutedEventArgs e)
        {
            InputNum("*");
        }

        private void Hash_Click(object sender, RoutedEventArgs e)
        {
            InputNum("#");
        }
        private void ToCall_Click(object sender, RoutedEventArgs e)
        {
            if (PhoneScreen.Text != "" && ToCall.Background == Brushes.LawnGreen)
            {
                PhoneScreen.Padding = new Thickness(0, 20, 0, 0);
                PhoneScreen.FontSize = 16;
                PhoneScreen.Text = PhoneScreen.Text + "\nВызов...";
                ToCall.Background = Brushes.Red;
            }
            else
            {
                PhoneScreen.Text = "";
                ToCall.Background = Brushes.LawnGreen;
            }

        }
    }
}
