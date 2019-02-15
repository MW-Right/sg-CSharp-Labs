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
    internal class ProgramVariables
    {
        public static string address = "";
    }
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
        public void SelectedFileList()
        {
            DirectoryInfo dSelected = new DirectoryInfo(@ProgramVariables.address);
            DirectoryInfo[] cSelectedFolders = dSelected.GetDirectories();
            System.IO.FileInfo[] cSelectedFiles = dSelected.GetFiles();
            List<FileInfo> folderList = new List<FileInfo>();
            List<FileInfo> fileList = new List<FileInfo>();
            List<string> listBoxRight = new List<string>();
            for (int i = 0; i < cSelectedFolders.Length; i++)
            {
                FileInfo folder = new FileInfo(cSelectedFolders[i].Name, "folder");
                folderList.Add(folder);
            }
            foreach (var i in cSelectedFiles)
            {
                string name = i.Name.ToString();
                listBoxRight.Add(name);
            }
            foreach (var i in folderList)
            {
                listBoxRight.Add(i.Name.ToString());
            }
            fileListBox.ItemsSource = fileList;
        }
        private void FolderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            FilePath.folderSelection = folderListBox.SelectedItem.ToString();
            ProgramVariables.address = $"C:\\labs/{FilePath.folderSelection}";
            SelectedFileList();
        }

        //private void SelectFromFiles_Click(object sender, RoutedEventArgs e)
        //{
        //    if (true)
        //    {
        //        FilePath.folderSelection = fileListBox.SelectedItem.ToString();
        //        ProgramVariables.address = $"C:\\labs/{FilePath.folderSelection}";
        //    }
            
        //}
    }
    public class FilePath
    {
        public static string folderSelection = "";

        public string FolderSelection { get => folderSelection; set => folderSelection = value; }

    }
    class FileInfo
    {
        public string name = "";
        public string type = "";

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }

        public FileInfo()
        {

        }
        public FileInfo(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}
