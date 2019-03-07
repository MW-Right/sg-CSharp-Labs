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

namespace Lab_15_Panels
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int index;
        string headerName;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            index = 0;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            if (index == 2)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            displayPanel(index);

        }
        void displayPanel(int index)
        {
            switch (index)
            {
                case 0:
                    StackPanel00.Visibility = Visibility.Visible;
                    StackPanel01.Visibility = Visibility.Collapsed;
                    StackPanel02.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    StackPanel00.Visibility = Visibility.Collapsed;
                    StackPanel01.Visibility = Visibility.Visible;
                    StackPanel02.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    StackPanel00.Visibility = Visibility.Collapsed;
                    StackPanel01.Visibility = Visibility.Collapsed;
                    StackPanel02.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (TabContol00.SelectedIndex)
            {
                case 0:
                    TabContol00.Background = Brushes.Aqua;
                    break;
                case 1:
                    TabContol00.Background = Brushes.Azure;
                    break;
                case 2:
                    TabContol00.Background = Brushes.Bisque;
                    break;
            }
            if (TabContol00.SelectedIndex == TabContol00.Items.Count - 1)
            {
                TabContol00.SelectedIndex = 0;
            }
            else
            {
                TabContol00.SelectedIndex++;

            }
        }
        enum tabs
        {
            First,
            Second,
            Third
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ChangeTabByName((TabContol00.SelectedItem as TabItem).Header.ToString());
        }

        void ChangeTabByName(string headerName)
        {
            switch (headerName)
            {
                case "First":
                    TabContol00.SelectedItem = (int)tabs.Second;
                    break;
                case "Second":
                    TabContol00.SelectedIndex = (int)tabs.Third;
                    break;
                case "Third":
                    TabContol00.SelectedIndex = (int)tabs.First;
                    break;
            }
        }
    }
}
