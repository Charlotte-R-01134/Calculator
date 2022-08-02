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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members

        private bool max;


        #endregion

        #region Constructor
        public MainWindow()
        {
            InitializeComponent();

            NewCalc();

        }

        #endregion

        private void NewCalc()
        {
            max = false;

            box.Text = "";

        }

        /// <summary>
        /// Handles clearing calculator
        /// </summary>
        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            NewCalc();
        }

        private void Button_Square_Click(object sender, RoutedEventArgs e)
        {
            if (!max)
            {
                box.Text += "^";
                max = true;
            }
        }

        private void Button_Square_Root_Click(object sender, RoutedEventArgs e)
        {
            box.Text = "√";
            max = true;
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            if (!max)
            {
                box.Text += "+";
                max = true;
            }
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "7";
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "8";
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "9";
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            if (!max)
            {
                box.Text += "-";
                max = true;
            }
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "4";
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "5";
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "6";
        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (!max)
            {
                box.Text += "x";
                max = true;
            }
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "1";
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "2";
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "3";
        }

        private void Button_Divide_Click(object sender, RoutedEventArgs e)
        {
            if (!max)
            {
                box.Text += "÷";
                max = true;
            }
        }

        private void Button_Del_Click(object sender, RoutedEventArgs e)
        {
            // if contents are empty
            if (box.Text.Length != 0)
            {
                box.Text = box.Text.Remove(box.Text.Length - 1);
                if (!(box.Text.Contains("+") & box.Text.Contains("-") & box.Text.Contains("x") & box.Text.Contains("÷") & box.Text.Contains("^") & box.Text.Contains("√"))) 
                {
                    max = false;
                }
            }
        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            box.Text += "0";
        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {
            var contents = box.Text;
            if (contents.Contains("+"))
            {
                var results = contents.Split('+');
                box.Text = (Int32.Parse(results[0]) + Int32.Parse(results[1])).ToString();
                max = false;
            }
            if (contents.Contains("-"))
            {
                var results = contents.Split('-');
                box.Text = (Int32.Parse(results[0]) - Int32.Parse(results[1])).ToString();
                max = false;
            }
            if (contents.Contains("x"))
            {
                var results = contents.Split('x');
                box.Text = (Int32.Parse(results[0]) * Int32.Parse(results[1])).ToString();
                max = false;
            }
            if (contents.Contains("÷"))
            {
                var results = contents.Split('÷');
                box.Text = (Int32.Parse(results[0]) / Int32.Parse(results[1])).ToString();
                max = false;
            }
            if (contents.Contains("^"))
            {
                var results = contents.Split('^');
                box.Text = Math.Pow(Int32.Parse(results[0]), Int32.Parse(results[1])).ToString();
                max = false;
            }
            if (contents.Contains("√"))
            {
                var results = contents.Substring(1);
                box.Text = Math.Sqrt(Convert.ToDouble(Int32.Parse(results))).ToString();
                max = false;
            }

        }
    }
}
