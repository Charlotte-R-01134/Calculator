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

        private Type[] results;
        private bool pressedEnter;
        private bool pressedClear;

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
            results = new Type[10];
            pressedEnter = false;
            pressedClear = false;

        }

        /// <summary>
        /// Handles clearing calculator
        /// </summary>
        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_LBracket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_RBracket_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Divide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Decimal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Enter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
