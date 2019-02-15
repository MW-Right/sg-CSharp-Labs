using System;
using System.Collections.Generic;
using System.IO;
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

namespace Lab_107_listFolders01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            LabsFolderList();
        }
        public void LabsFolderList()
        {
            List<string> folderList = new List<string>();
            DirectoryInfo dLabs = new DirectoryInfo(@"C:\\labs");
            DirectoryInfo[] cLabs = dLabs.GetDirectories();
            foreach (var i in cLabs)
            {
                folderList.Add(i.Name.ToString());
            }
            folderListBox.ItemsSource = folderList;
        }
        private void FolderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
