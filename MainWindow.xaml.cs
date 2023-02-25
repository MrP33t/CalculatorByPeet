using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string displayText = " ";
        int answer = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed )
            {
                DragMove();
            }
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if(Application.Current.MainWindow.WindowState != WindowState.Maximized ) 
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            } else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal;
            }
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private int addd(int value)
        {
            return this.answer + value;
        }
        private int remove(int value)
        {
            return this.answer - value;
        }
        private int multiplyy(int value)
        {
            return this.answer * value;
        }
        private int dividee(int value)
        {
            return this.answer / value;
        }
        private void displayAnswer()
        {
            display.Content = this.answer.ToString();
        }
        private void reset()
        {
            this.answer = 0;
            this.displayText = " ";
            displayAnswer();
        }
        private void displayTextt()
        {
            display.Content = displayText;
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            Button src = e.Source as Button;
            switch (src.Name)
            {
                case "one":
                    displayText += "1";
                    displayTextt();
                    break;
                case "two":
                    displayText += "2";
                    displayTextt();
                    break;
                case "three":
                    displayText += "3";
                    displayTextt();
                    break;
                case "four":
                    displayText += "4";
                    displayTextt();
                    break;
                case "five":
                    displayText += "5";
                    displayTextt();
                    break;
                case "six":
                    displayText += "6";
                    displayTextt();
                    break;
                case "seven":
                    displayText += "7";
                    displayTextt();
                    break;
                case "eight":
                    displayText += "8";
                    displayTextt();
                    break;
                case "nine":
                    displayText += "9";
                    displayTextt();
                    break;
                case "zero":
                    displayText += "0";
                    displayTextt();
                    break;
                case "c":
                    reset();
                    break;
                case "equal":
                    displayAnswer();
                    break;
                case "add":
                    if (displayText == " ") break;
                    this.answer = addd(Int32.Parse(displayText));
                    this.displayText = " ";
                    displayAnswer();
                    break;
                case "minus":
                    if (displayText == " ") break;
                    this.answer = remove(Int32.Parse(displayText));
                    this.displayText = " ";
                    displayAnswer();
                    break;
                case "divide":
                    if (displayText == " ") break;
                    this.answer = dividee(Int32.Parse(displayText));
                    this.displayText = " ";
                    displayAnswer();
                    break;
                case "multiply":
                    if (displayText == " ") break;
                    this.answer = multiplyy(Int32.Parse(displayText));
                    this.displayText = " ";
                    displayAnswer();
                    break;
                default:
                    break;
            }
        }
    }
}
