using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
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

namespace Lab_06_wpf
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
        public class ProgramVariables
        {
            public static DateTime startTime = new DateTime();
            public static int timeTaken = 0;
        }
        private void InputBlock_TextChanged(object sender, TextChangedEventArgs e)
        {
            string input = "";
            input = inputBlock.Text;
            timerBlock.Text = $"{(ProgramVariables.startTime - DateTime.Now).TotalSeconds}";
            if (inputBlock.Text.Length == 250)
            {
                inputBlock.AppendText($"You took {ProgramVariables.timeTaken}");
            }
        }
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramVariables.startTime = DateTime.Now;

        }
    }    
}
