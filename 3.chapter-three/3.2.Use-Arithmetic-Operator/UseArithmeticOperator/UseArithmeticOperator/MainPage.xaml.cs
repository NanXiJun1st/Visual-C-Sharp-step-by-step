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
            int leftHandSide = int.Parse(lhsOperand.Text);
            int rightHandSide = int.Parse(rhsOperand.Text);

            if (addition.IsChecked == true) { additiveValues(leftHandSide,rightHandSide); }
            if (subtraction.IsChecked == true) { subtractionValues(leftHandSide, rightHandSide); }
            if (multiplication.IsChecked == true) { multiplicationValues(leftHandSide, rightHandSide); }
            if (division.IsChecked == true) { divisionValues(leftHandSide, rightHandSide); }


        }

        private void additiveValues(int leftHandSide,int rightHandSide)
        {
            int outcome = 0;
            outcome = leftHandSide + rightHandSide;
            expression.Text = $"Expression:{lhsOperand.Text} + {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} " ;
        }

        private void subtractionValues(int leftHandSide, int rightHandSide)
        {
            int outcome = 0;
            outcome = leftHandSide + rightHandSide;
            expression.Text = $"Expression:{lhsOperand.Text} - {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} ";
        }
        private void multiplicationValues(int leftHandSide, int rightHandSide)
        {
            int outcome = 0;
            outcome = leftHandSide + rightHandSide;
            expression.Text = $"Expression:{lhsOperand.Text} x {rhsOperand.Text}";
            result.Text = $"Result:{outcome.ToString()} ";
        }

        private void divisionValues(int leftHandSide, int rightHandSide)
        {
            int outcome = 0;
            int remainder = 0;
            outcome = leftHandSide / rightHandSide;
            remainder = leftHandSide % rightHandSide;
            expression.Text = $"Expression:{lhsOperand.Text} ÷ {rhsOperand.Text}";
            result.Text = $"Result:quotient={outcome.ToString()},remainder={remainder.ToString()} ";
        }


    }
}
