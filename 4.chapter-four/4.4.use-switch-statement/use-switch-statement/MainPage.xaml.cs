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

namespace use_switch_statement
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

        private void StartCopy(object sender, RoutedEventArgs e)
        {
            copedText.Text = "";
            string str = originText.Text;
            char[] chars = str.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                CopyTwo(chars[i]);
            }
        }

        private void CopyOne(char current)
        {
            switch (current)
            {
                case '<':
                    copedText.Text += "&lt;";
                    break;
                case '>':
                    copedText.Text += "&gt;";
                    break;
                case '&':
                    copedText.Text += "&amp;";
                    break;
                case '\"':
                    copedText.Text += "&#34;";
                    break;
                case '\'':
                    copedText.Text += "&#39;";
                    break;
                default:
                    copedText.Text += current;
                    break;
            }
        }

        /// <summary>
        /// switch 表达式，仅支持c#8.0及以上
        /// </summary>
        /// <param name="current"></param>
        private void CopyTwo(char current)
        {
            copedText.Text += current switch
            {
                '<' => "&lt;",
                '>' => "&gt;",
                '&' => "&amp;",
                '\"' => "&#34;",
                '\'' => "&#39;",
                _ =>current
            };
        }
    }
}
