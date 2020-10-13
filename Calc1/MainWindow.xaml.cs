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

namespace Calc1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {

        long number1 = 0;
        long number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearElement_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = 0;              
            }
            else
            {
                number2 = 0;
            }

            mathTextBox.Text = "0";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            mathTextBox.Text = "";
            number1 = 0;
            number2 = 0;
            operation = "";
            mathTextBox.Text = "0";
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                mathTextBox.Text = number2.ToString();
            }

        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 7;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10);
                mathTextBox.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10);
                mathTextBox.Text = number2.ToString();
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            mathTextBox.Text = "0";
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            mathTextBox.Text = "0";
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            mathTextBox.Text = "0";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            mathTextBox.Text = "0";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    mathTextBox.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    mathTextBox.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    mathTextBox.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    mathTextBox.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void Thing_Click(object sender, RoutedEventArgs e)
        {
            {
                if (operation == "")
                {
                    number1 = (number1 / 10);
                    mathTextBox.Text = number1.ToString();
                }
                else
                {
                    number2 = (number2 / 10);
                    mathTextBox.Text = number2.ToString();
                }
            }
        }

        private void negOrPos_Click(object sender, RoutedEventArgs e)
        {
            
           if (operation == "")
           {
               number1 = (number1 * -1);
               mathTextBox.Text = number1.ToString();
           }
           else
           {
               number2 = (number2 * -1);
               mathTextBox.Text = number2.ToString();
           }
            
        }
    }
}
