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

namespace Lab_115_Northwind_Entity_With_OOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// 
    /// Read customers and cast to ActiveCustomers and 
    /// set IsActive to true for all customers
    /// 
    /// Create 2 list boxes and a radio button to enable or disable our ActiveCustomer
    /// Click on Customer to select and display all the details on the screen
    /// 
    /// When you click on the enable/disable button it will reverse the state of the IsActive
    /// 
    /// Primary ListBox, only for active customers
    /// If the state becomes inactive, remove it from the listBox1
    /// 
    /// Second ListBox only for inactive customers
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<string> custName = new List<string>();
        public List<ActiveCustomer> active = new List<ActiveCustomer>();
        public List<ActiveCustomer> inactive = new List<ActiveCustomer>();
        public ActiveCustomer cust = new ActiveCustomer();

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }
        void Initialize()
        {
            using (var db = new NorthwindEntities1())
            {
                customers = db.Customers.ToList<Customer>();
            }
            foreach (var i in customers)
            {
                active.Add(new ActiveCustomer(i));
            }
            Active.ItemsSource = active;
            Active.DisplayMemberPath = "ContactName";
            Inactive.ItemsSource = inactive;
            Inactive.DisplayMemberPath = "ContactName";
        }

        private void MakeActive_Checked(object sender, RoutedEventArgs e)
        {
            if (makeActive.IsChecked == true)
            {
                makeActive.Content = "Make Inactive";
                cust = (ActiveCustomer)Active.SelectedItem;
                8cust.IsActive = false;
                active.Remove(cust);
                inactive.Add(cust);
                Refresh();
            }
            else if (makeActive.IsChecked == false)
            {
                makeActive.Content = "Make Active";
                cust = (ActiveCustomer)Inactive.SelectedItem;
                cust.IsActive = true;
                inactive.Remove(cust);
                active.Add(cust);
                Refresh();
            }
        }


        private void Inactive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Active_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public void Refresh()
        {
            List<Customer> blank = new List<Customer>();
            Active.ItemsSource = blank;
            Active.ItemsSource = active;
            Inactive.ItemsSource = blank;
            Inactive.ItemsSource = inactive;
            if (makeActive.IsChecked == true)
            {
                makeActive.IsChecked = false;
            }
            else if (makeActive.IsChecked == false)
            {
                makeActive.IsChecked = true;
            }
        }
    }

    public class ActiveCustomer : Customer
    {
        public bool IsActive;
        public ActiveCustomer() { }
        public ActiveCustomer(Customer c)
        {
            Address = c.Address;
            City = c.City;
            ContactName = c.ContactName;
            CompanyName = c.CompanyName;
            ContactTitle = c.ContactTitle;
            Country = c.Country;
            CustomerID = c.CustomerID;
            Fax = c.Fax;
            Phone = c.Phone;
            PostalCode = c.PostalCode;
            Region = c.Region;
            IsActive = true;
        }
    }
}
