using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace use_do_statement
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void showStepsClick(object sender, RoutedEventArgs e)
        {
            startCalculate02();
        }

        private void startCalculate01()
        {
            int amount = int.Parse(number.Text);
            steps.Text = "";
            string current = "";

            do
            {
                int nextDigit = amount % 8;
                amount /= 8;
                int digitCode = 48 + nextDigit;  //字符‘0’的代码是整数48
                char digit = Convert.ToChar(digitCode);
                current = digit + current;
                steps.Text += current + "\n";
            }
            while (amount != 0);
        }
        private void startCalculate02()
        {
            int amount = int.Parse(number.Text);
            steps.Text = "";
            string current = "";

            do
            {
                int digit = amount % 2;
                amount /= 2;
                int digitCode = '0' + digit;
                char temp = Convert.ToChar(digitCode);
                current = temp + current;
                steps.Text += current + "\n";

            }
            while (amount != 0);
        }
    }
}
