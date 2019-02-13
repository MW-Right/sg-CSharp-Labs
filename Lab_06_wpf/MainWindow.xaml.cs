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
    public class ProgramVariables
    {
        public static bool gameOn = false;
        public static string input = "";
        public static DateTime finish = DateTime.Now.AddSeconds(10);
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InputBlock_TextChanged(object sender, TextChangedEventArgs e)
        {

            while (ProgramVariables.gameOn == true)
            {
                ProgramVariables.input = inputBlock.Text;
                if (DateTime.Compare(ProgramVariables.finish, DateTime.Now) <= 0)
                {
                    ProgramVariables.gameOn = false;
                    break;
                }
            }
            inputBlock.Text = "";
            inputBlock.Text = $"You scored {ProgramVariables.input}, hit start to try again" + ProgramVariables.input.Length;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            ProgramVariables.gameOn = true;
        }
    }    
}
