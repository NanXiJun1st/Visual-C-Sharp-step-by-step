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

namespace UsePrimitiveDataType
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void typeSeletionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedType = type.SelectedItem as ListBoxItem;
            switch (selectedType.Content.ToString())
            {
                case "int":
                    showIntValue();
                    break;
                case "long":
                    showLongValue();
                    break;
                case "float":
                    showFloatValue();
                    break;
                case "double":
                    showDoubleValue();
                    break;
                case "decimal":
                    showDecimalValue();
                    break;
                case "string":
                    showStringValue();
                    break;
                case "char":
                    showCharValue();
                    break;
                case "bool":
                    showBoolValue();
                    break;
                default:
                    break;
            }
        }

        private void showIntValue()
        {
            int intVar;
            intVar = 9;
            value.Text = intVar.ToString();
        }

        private void showLongValue()
        {
            long longVar;
            longVar = 99999999999;
            value.Text = longVar.ToString();
        }

        private void showFloatValue()
        {
            float floatVar;
            floatVar = 9f;
            value.Text = floatVar.ToString();
        }

        private void showDoubleValue()
        {
            double doubleVar;
            doubleVar = 0.99;
            value.Text = doubleVar.ToString();
        }

        private void showDecimalValue()
        {
            decimal decimalVar;
            decimalVar = 0.99m;
            value.Text= decimalVar.ToString();
        }

        private void showStringValue()
        {
            string stringVar;
            stringVar = "String";
            value.Text = stringVar.ToString();
        }

        private void showCharValue()
        {
            char charVar;
            charVar = 'a';
            value.Text = "to do";
        }

        private void showBoolValue()
        {
            bool boolVar;
            boolVar = true;
            value.Text = boolVar.ToString();
        }
    }
}
