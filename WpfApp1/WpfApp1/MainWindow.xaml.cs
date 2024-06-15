using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Windows;
using System.Windows.Markup;

namespace WpfApp1
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        SqlConnection Conn = new SqlConnection("Data Source =.; Initial Catalog = products; User ID = sa; Password=********;Connect Timeout = 30; Encrypt=False;Trust Server Certificate=False;Application Intent = ReadWrite; Multi Subnet Failover=False");

        public void clearData()
        {
            pname.Clear();
            desc.Clear();
            price.Clear();
            qty.Clear();
            cat.Clear();
        }
        private bool|isValid()
        {
            if (pname.Text == string.Empty|| desc.Text==string.Empty|| price.Text == string.Empty || qty.Text == string.Empty || cat.Text == string.Empty)
            {
                MessageBox.Show("All fields are required","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void ClearFields(object sender, RoutedEventArgs e)
        {
            clearData();
        }

        private void AddProduct(object sender, RoutedEventArgs e)
        {
            if (isValid() == true)
            {
                SqlCommand addProduct = new SqlCommand("Insert into products values(@pname,@desc,@price,@qty,@cat)",Conn);
                Conn.Open();
                addProduct.CommandType = CommandType.Text;

                addProduct.Parameters.AddWithValue("@pname", pname.Text);
                addProduct.Parameters.AddWithValue("@desc", desc.Text);
                addProduct.Parameters.AddWithValue("@price", price.Text);
                addProduct.Parameters.AddWithValue("@cat", cat.Text);
                addProduct.Parameters.AddWithValue("@qty", qty.Text);
                addProduct.ExecuteNonQuery();

                Conn.Close();

                MessageBox.Show("Product added successfully!","Success",
                MessageBoxButton.OK, MessageBoxImage.Information);
                clearData();

            }
        }
    }
}
