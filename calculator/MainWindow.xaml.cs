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

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double num1 = 0;
        double num2 = 0;
        string op = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtBox_input_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if(txtBox_input.Text == "0")
                txtBox_input.Text = "1";
            else
                txtBox_input.Text += "1";
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "0";
            else
                txtBox_input.Text += "0";
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "2";
            else
                txtBox_input.Text += "2";
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "3";
            else
                txtBox_input.Text += "3";
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "4";
            else
                txtBox_input.Text += "4";
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "5";
            else
                txtBox_input.Text += "5";
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "6";
            else
                txtBox_input.Text += "6";
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "7";
            else
                txtBox_input.Text += "7";
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "8";
            else
                txtBox_input.Text += "8";
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text == "0")
                txtBox_input.Text = "9";
            else
                txtBox_input.Text += "9";
        }

        private void btn_ce_Click(object sender, RoutedEventArgs e)
        {
            txtBox_input.Text = "0";
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            op = "";
            txtBox_input.Text = "0";
        }

        private void btn_neg_Click(object sender, RoutedEventArgs e)
        {
            if (txtBox_input.Text[0] == '-')
            {
                txtBox_input.Text = txtBox_input.Text.Substring(1);
            }
            else if (txtBox_input.Text[0] == '0')
            {
                return;
            }
            else
            {
                txtBox_input.Text = "-" + txtBox_input.Text;
            }
        }

        private void btn_dec_Click(object sender, RoutedEventArgs e)
        {
            txtBox_input.Text += ".";
        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if(op == "")
            {
                num1 = Double.Parse(txtBox_input.Text);
                txtBox_input.Text = "0";
                op = "+";
            }
            else
            { 
                num1 = ExecuteEquation(num1, Double.Parse(txtBox_input.Text), op);
                op = "+";
            }
            
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = Double.Parse(txtBox_input.Text);
                txtBox_input.Text = "0";
                op = "-";
            }
            else
            {
                num1 = ExecuteEquation(num1, Double.Parse(txtBox_input.Text), op);
                op = "-";
            }
        }

        private void btn_mul_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = Double.Parse(txtBox_input.Text);
                txtBox_input.Text = "0";
                op = "*";
            }
            else
            {
                num1 = ExecuteEquation(num1, Double.Parse(txtBox_input.Text), op);
                op = "*";
            }
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            if (op == "")
            {
                num1 = Double.Parse(txtBox_input.Text);
                txtBox_input.Text = "0";
                op = "/";
            }
            else
            {
                num1 = ExecuteEquation(num1, Double.Parse(txtBox_input.Text), op);
                op = "/";
            }
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            num2 = Double.Parse(txtBox_input.Text);
            txtBox_input.Text = ExecuteEquation(num1, num2, op).ToString();
            op = "";
        }

        private double ExecuteEquation(double num1, double num2, string op)
        {
            double result;
            if (op == "+")
                result = num1 + num2;
            else if (op == "-")
                result = num1 - num2;
            else if (op == "*")
                result = num1 * num2;
            else if (op == "/")
                result = num1 / num2;
            else
                result = 0;

            op = "";
            return result;
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            txtBox_input.Text = txtBox_input.Text.Substring(0, txtBox_input.Text.Length-1);
            if (txtBox_input.Text.Length == 0)
                txtBox_input.Text = "0";
        }

        
    }
}
