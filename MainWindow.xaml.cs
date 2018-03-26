//Aidan McClung
//March 26, 2018
//u2AidanMTXTMSG
//converts a variety of short forms to their "adult-friendly" versions.

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

namespace u2AidanMTXTMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            //Make a text box input and a label output (design aspect?)
            string input = txtInput.Text;
            ///If statements check for each word (loop for multiple uses?)
            //String.replace each word then loop again to make sure there aren't any.
            input = input.Replace("CU", "see you"); Console.WriteLine(input);
            input = input.Replace(":-)", "I’m happy"); Console.WriteLine(input);
            input = input.Replace(":-(", "I’m unhappy"); Console.WriteLine(input);
            input = input.Replace(";-)", "wink"); Console.WriteLine(input);
            input = input.Replace(":-P", "stick out my tongue"); Console.WriteLine(input);
            input = input.Replace("(˜.˜)", "sleepy"); Console.WriteLine(input);
            input = input.Replace("TA", "totally awesome"); Console.WriteLine(input);
            input = input.Replace("CCC", "Canadian Computing Competition"); Console.WriteLine(input);
            input = input.Replace("CUZ", "because"); Console.WriteLine(input);
            input = input.Replace("YW", "you’re welcome"); Console.WriteLine(input);
            input = input.Replace("TTYL", "talk to you later"); Console.WriteLine(input);
            input = input.Replace("TY", "thank-you"); Console.WriteLine(input);
            

            //Output full end string.
            string output = input;
            lblOutput.Content = output;
        }
    }
}
