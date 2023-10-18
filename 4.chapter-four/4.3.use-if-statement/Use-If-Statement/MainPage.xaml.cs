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

namespace UseIfStatement
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

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void CompareClick(object sender, RoutedEventArgs e)
        {
            int diff = DateCompare(FirstData.Date.LocalDateTime, SecondData.Date.LocalDateTime);
            info.Text = "";
            Show("FirstData == SecondDate", diff == 0);
            Show("FirstData != SecondDate", diff != 0);
            Show("FirstData < SecondDate", diff == -1);
            Show("FirstData > SecondDate", diff == 1);
            Show("FirstData == SecondDate", diff == 0);


        }

        private int DateCompare(DateTime firstSide,DateTime secondSide)
        {
            int result = 0;
            if (firstSide.Year < secondSide.Year)
            {
                result = -1;
            }
            else if (firstSide.Year > secondSide.Year)
            {
                result = 1;
            }
            else if (firstSide.Month < secondSide.Month)
            {
                result = -1;
            }
            else if (firstSide.Month > secondSide.Month)
            {
                result = 1;
            }
            else if (firstSide.Day < secondSide.Day)
            {
                result = -1;
            }
            else if (firstSide.Day > secondSide.Day)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            return result;
        }

        private void Show(string exp,bool result)
        {
            info.Text += ($"{ exp}:{ result}\n");
            //info.Text += exp;
            //info.Text += ":" + result.ToString();
            //info.Text += "/n";
        }
    }
}
