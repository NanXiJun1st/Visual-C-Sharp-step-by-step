using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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

namespace MathsOperators
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


        public void AddValues()
        {
            int lhs = int.Parse(LeftOperandValue.Text);
            int rhs = int.Parse(RightOperandValue.Text);
            int outcome = checked(lhs + rhs);

            Expression.Text = $"{lhs} + {rhs}";
            Result.Text = outcome.ToString();
        }

        public void SubValues()
        {
            int lhs = int.Parse(LeftOperandValue.Text);
            int rhs = int.Parse(RightOperandValue.Text);
            int outcome = lhs - rhs;

            Expression.Text = $"{lhs} - {rhs}";
            Result.Text = outcome.ToString();
        }

        public void MulValues()
        {
            int lhs = int.Parse(LeftOperandValue.Text);
            int rhs = int.Parse(RightOperandValue.Text);
            double outcome = checked(lhs * rhs); //将最终结果转换为double类型，不能解决Int32的溢出问题

            Expression.Text = $"{lhs} *  {rhs}";
            Result.Text = outcome.ToString();
        }

        public void DivValues()
        {
            int lhs = int.Parse(LeftOperandValue.Text);
            int rhs = int.Parse(RightOperandValue.Text);
            int outcome = lhs / rhs;

            Expression.Text = $"{lhs} / {rhs}";
            Result.Text = outcome.ToString();
        }

        public void RemainderValues()
        {
            int lhs = int.Parse(LeftOperandValue.Text);
            int rhs = int.Parse(RightOperandValue.Text);
            int outcome = lhs % rhs;

            Expression.Text = $"{lhs} % {rhs}";
            Result.Text = outcome.ToString();
        }

        private void StartCalculate(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)Addition.IsChecked)
                {
                    AddValues();
                }
                else if ((bool)Subtraction.IsChecked)
                {
                    SubValues();
                }
                else if ((bool)Multiplication.IsChecked)
                {
                    MulValues();
                }
                else if ((bool)Division.IsChecked)
                {
                    DivValues();
                }
                else if ((bool)Remainder.IsChecked)
                {
                    RemainderValues();
                }
                else
                {
                    throw new InvalidOperationException("No operator selected");
                }
            }
            catch (FormatException fEx)
            {

                Result.Text = fEx.Message;
            }
            catch (OverflowException oFx)
            {
                Result.Text = oFx.Message;
            }
            catch (InvalidOperationException ioEx)
            {
                Result.Text = ioEx.Message;
            }
            catch (Exception ex)
            {
                Result.Text = ex.Message;
            }
            finally
            {
                Result.Text += 1;
            }
        }
    }
}