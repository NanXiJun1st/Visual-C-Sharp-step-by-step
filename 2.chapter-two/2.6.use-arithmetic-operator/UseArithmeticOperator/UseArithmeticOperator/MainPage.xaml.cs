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

namespace UseArithmeticOperator
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


        private void calculateClick(object sender, RoutedEventArgs e)
        {
            if (addition.IsChecked == true) { additiveValues(); }
            if (subtraction.IsChecked == true) { subtractionValues(); }
            if (multiplication.IsChecked == true) { multiplicationValues(); }
            if (division.IsChecked == true) { divisionValues(); }
            if (remainder.IsChecked == true) { remainderValues(); }


        }

        private void additiveValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs + rhs;
            expression.Text = $"Expression:{lhsOperand.Text} + {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} " ;
        }

        private void subtractionValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs - rhs;
            expression.Text = $"Expression:{lhsOperand.Text} - {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} ";
        }
        private void multiplicationValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs * rhs;
            expression.Text = $"Expression:{lhsOperand.Text} x {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} ";
        }

        private void divisionValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs / rhs;
            expression.Text = $"Expression:{lhsOperand.Text} ÷ {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} ";
        }
        private void remainderValues()
        {
            int lhs = int.Parse(lhsOperand.Text);
            int rhs = int.Parse(rhsOperand.Text);
            int outcome = 0;
            outcome = lhs % rhs;
            expression.Text = $"Expression:{lhsOperand.Text} % {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} ";
        }


    }
}
