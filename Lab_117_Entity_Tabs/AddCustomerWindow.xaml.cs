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
using System.Windows.Shapes;

namespace Lab_117_Entity_Tabs
{
    /// <summary>
    /// Interaction logic for AddCustomerWindow.xaml
    /// </summary>
    public partial class AddCustomerWindow : Window
    {
        Customer addCustomer = new Customer();
        List<Customer> customers = new List<Customer>();
        List<string> customerIds = new List<string>();

        public AddCustomerWindow()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            using(var db = new NorthwindEntities())
            {
                customers = db.Customers.ToList<Customer>();
                foreach (var i in customers)
                {
                    customerIds.Add(i.CustomerID);
                }
                if (!(customerID.Text == "Customer ID" || contactName.Text == "Contact Name" || contactTitle.Text == "Contact Title" || city.Text == "City"))
                {
                    if (!customerIds.Contains(customerID.Text))
                    {
                        addCustomer.CustomerID = customerID.Text;
                    }
                    else
                    {
                        MessageBox.Show("ID must be unique, please try another. Or click random");
                    }
                    addCustomer.ContactName = contactName.Text;
                    addCustomer.ContactTitle = contactTitle.Text;
                    addCustomer.City = city.Text;
                    addCustomer.CompanyName = companyName.Text;
                    db.Customers.Add(addCustomer);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please fill out all the fields");
                }
                this.Close();
            }
        }

        private void RandomID_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            string rndID = "";
            for (int i = 0; i < 5; i++)
            {
            }
        }
    }
}
