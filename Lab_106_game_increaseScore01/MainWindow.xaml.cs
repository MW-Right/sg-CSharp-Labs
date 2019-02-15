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
using System.Windows.Forms;
using System.IO;

namespace Lab_106_game_increaseScore01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class ProgramStuff
    {
        public static int score = 0;
        public static int lineFound = 0;
        public static List<string> usernameList = new List<string>();
    }
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            //Create a gaming homepage
            //Name of player (Save to text file)
            //Level reached (Save to text file)
            //HighScore (Save to text file)
            InitializeComponent();
            System.Windows.Forms.Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Start();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("file.txt", username.Text + Environment.NewLine);
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            HighScore.Text = CurrentScore.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProgramStuff.score += 1;
            CurrentScore.Text = Convert.ToString(ProgramStuff.score);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProgramStuff.score -= 1;
            CurrentScore.Text = Convert.ToString(ProgramStuff.score);
        }
        private void Start()
        {
            if (File.Exists("file.txt") == true)
            {
                username.Text = File.ReadAllText("file.txt");
            }
        }
    }
}
