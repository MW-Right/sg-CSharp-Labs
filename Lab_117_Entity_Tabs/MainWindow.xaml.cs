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

namespace Lab_117_Entity_Tabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Customer> customers = new List<Customer>();
        List<string> customerDetails = new List<string>();
        Customer cust = new Customer();

        List<Order> orders = new List<Order>();
        Order ord = new Order();

        List<Order_Detail> orderDetails = new List<Order_Detail>();
        List<string> orderDetailsList = new List<string>();
        Order_Detail deets = new Order_Detail();

        List<Product> products = new List<Product>();
        List<string> productDeets = new List<string>();
        Product prod = new Product();

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            using (var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                customerListBox.ItemsSource = customers;
                customerListBox.DisplayMemberPath = "ContactName";
            }
        }
        private void CustomerListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cust = (customerListBox.SelectedItem as Customer);
            DetailsList();
            using(var db = new NorthwindEntities())
            {
                orders = db.Orders.Where(c => c.CustomerID == cust.CustomerID).ToList<Order>();
                OrderListBox.ItemsSource = orders;
                OrderListBox.DisplayMemberPath = "OrderID";
            }
        }

        private void OrderListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ord = (OrderListBox.SelectedItem as Order);
            using (var db = new NorthwindEntities())
            {
                orderDetails = db.Order_Details.Where(c => c.OrderID == ord.OrderID).ToList<Order_Detail>();
                OrderDetailsListBox.ItemsSource = orderDetails;
                OrderDetailsListBox.DisplayMemberPath = "ProductID";
            }
        }

        private void OrderDetailsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deets = OrderDetailsListBox.SelectedItem as Order_Detail;
            OrderDeets();
            using(var db = new NorthwindEntities())
            {
                products = db.Products.Where(p => p.ProductID == deets.ProductID).ToList<Product>();
                ProductListBox.ItemsSource = products;
                ProductListBox.DisplayMemberPath = "ProductID";
            }
        }

        private void ProductListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            prod = ProductListBox.SelectedItem as Product;
            ProductDeets();
        }

        public void DetailsList()
        {
            customerDetailsListBox.ItemsSource = customerDetails;
            customerDetails.Clear();
            customerDetails.Add($"Name: {cust.ContactName}");
            customerDetails.Add($"Title: {cust.ContactTitle}");
            customerDetails.Add($"CustomerID: {cust.CustomerID}");
        }

        void OrderDeets()
        {
            orderDetailsList.Clear();
            deetsListBox.ItemsSource = orderDetailsList;
            orderDetailsList.Add($"Unit Price: {deets.UnitPrice}");
            orderDetailsList.Add($"Quantity: {deets.Quantity}");
            orderDetailsList.Add($"Product ID: {deets.ProductID}");
        }

        void ProductDeets()
        {
            productDeets.Clear();
            ProductDetailsListBox.ItemsSource = productDeets;
            productDeets.Add($"Product Name: {prod.ProductName}");
            productDeets.Add($"Unit Price: {prod.UnitPrice}");
            productDeets.Add($"Supplier: {prod.SupplierID}");
            productDeets.Add($"Units in Stock: {prod.UnitsInStock}");

        }

        private void CustomerDetailsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DeetsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCustomerWindow newWin = new AddCustomerWindow();
            newWin.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Init();
        }
    }
}
