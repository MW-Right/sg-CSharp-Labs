using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Lab_114_GUIEntity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Customer> customers = new List<Customer>();
        public static Customer cust = new Customer();
        public static List<string> blank = new List<string>();
        public static List<string> details = new List<string>();
        public static string[] cities = new string[] { "London", "Paris", "Berlin", "Porto", "Basel", "Madeira", "Rome", "Milan", "Marseilles", "Rotherham", "Canberra", "Los Angeles" };
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            SetCustomerList();
            dropdown.ItemsSource = cities.ToList<string>();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FullListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cust = (Customer)fullListBox.SelectedItem;
            try
            {
                nameTextBox.Text = cust.ContactName.ToString();
                city.Text = cust.City;
            }
            catch
            {
                Trace.WriteLine("Null reference error");
            }
            //Clears list box for update
            detailsListBox.ItemsSource = blank;
            ListBox2Content();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
             using(var db = new NorthwindEntities())
            {
                Customer updateCustomer = db.Customers.Where(c => c.ContactName == cust.ContactName).FirstOrDefault();
                if (updateCustomer.ContactName != nameTextBox.Text)
                {
                    updateCustomer.ContactName = nameTextBox.Text;
                    updateCustomer.City = dropdown.SelectedItem.ToString();
                }
                db.SaveChanges();
                Init();
            }
        }
        public void ListBox2Content()
        {
            try
            {
                detailsListBox.ItemsSource = details;
                details.Clear();
                details.Add($"Title: {cust.ContactTitle}");
                details.Add($"Name: {cust.ContactName}");
                details.Add($"Customer ID: {cust.CustomerID}");
                details.Add($"City: {cust.City}");
                details.Add($"Region: {cust.Region}");
            }
            catch
            {
                Trace.WriteLine("Null reference error");
            }
        }

        private void DetailsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void SetCustomerList()
        {
            using (var db = new NorthwindEntities())
            {
                customers.Clear();
                customers = db.Customers.ToList<Customer>();
                fullListBox.ItemsSource = customers;
                fullListBox.DisplayMemberPath = "ContactName";
            }
        }

        private void Dropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}
