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

namespace WPF_Rassokhin_PR_3._1
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
        int summ;
        private void Button_1_plus_3(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 3;
            TextBox1.Text = summ.ToString();
        }

        private void Button_1_plus_2(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 2;
            TextBox1.Text = summ.ToString();
        }

        private void Button_1_plus_1(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 + 1;
            TextBox1.Text = summ.ToString();
        }

        private void Button_1_minus_1(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 - 1;
            TextBox1.Text = summ.ToString();
        }

        private void Button_1_minus_2(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 - 2;
            TextBox1.Text = summ.ToString();
        }

        private void Button_1_minus_3(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox1.Text);
            summ = cvn1 - 3;
            TextBox1.Text = summ.ToString();
        }

        private void Button_2_plus_3(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox2 .Text);
            summ = cvn1 + 3;
            TextBox2.Text = summ.ToString();
        }

        private void Button_2_plus_2(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox2.Text);
            summ = cvn1 + 2;
            TextBox2.Text = summ.ToString();

        }

        private void Button_2_plus_1(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox2.Text);
            summ = cvn1 + 1;
            TextBox2.Text = summ.ToString();

        }

        private void Button_2_minus_1(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox2.Text);
            summ = cvn1 - 1;
            TextBox2.Text = summ.ToString();

        }

        private void Button_2_minus_2(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox2.Text);
            summ = cvn1 - 2;
            TextBox2.Text = summ.ToString();

        }

        private void Button_2_minus_3(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox2.Text);
            summ = cvn1 - 3;
            TextBox2.Text = summ.ToString();

        }

        private void Button_3_plus_3(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox3.Text);
            summ = cvn1 + 3;
            TextBox3.Text = summ.ToString();

        }

        private void Button_3_plus_2(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox3.Text);
            summ = cvn1 + 2;
            TextBox3.Text = summ.ToString();

        }

        private void Button_3_plus_1(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox3.Text);
            summ = cvn1 + 1;
            TextBox3.Text = summ.ToString();

        }

        private void Button_3_minus_1(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox3.Text);
            summ = cvn1 - 1;
            TextBox3.Text = summ.ToString();

        }

        private void Button_3_minus_2(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox3.Text);
            summ = cvn1 - 2;
            TextBox3.Text = summ.ToString();

        }

        private void Button_3_minus_3(object sender, RoutedEventArgs e)
        {
            int cvn1;
            cvn1 = Convert.ToInt32(TextBox3.Text);
            summ = cvn1 - 3;
            TextBox3.Text = summ.ToString();

        }

        private void Sbros(object sender, RoutedEventArgs e)
        {
            TextBox1.Text = "0";
            TextBox2.Text = "0";
            TextBox3.Text = "0";
        }
    }
}
