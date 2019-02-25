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
using System.Data.Entity;

namespace Lab_10_Entity_Gui1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Customer> customers = new List<Customer>();
        public static List<string> customerList = new List<string>();
        Customer customer;
        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }
        void Initialize()
        {
            using(var db = new NorthwindEntities())
            {
                foreach (var customer in db.Customers)
                {
                    customers.Add(customer);
                    customerList.Add($"{customer.ContactName} has an ID {customer.CustomerID}");
                }
            }
            ListBox01.ItemsSource = customerList;

            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox02.ItemsSource = customers;
            }

            using(var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                ListBox03.ItemsSource = customers;
                ListBox03.DisplayMemberPath = "ContactName";

            }
        }

        private void ListBox01_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox02_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox03_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            customer = (Customer)ListBox03.SelectedItem;
            Yeet.Text = customer.ContactName;
        }

        private void ListBox04_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox05_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
