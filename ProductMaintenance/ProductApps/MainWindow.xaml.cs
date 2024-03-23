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

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cProduct = new Product(Convert.ToDouble(priceTextBox.Text), Convert.ToDouble(quantityTextBox.Text));
                cProduct.calTotalPayment();
                cProduct.calTotalCharge();
                cProduct.calTotalChargeWrap();
                cProduct.calTotalChargeGST();
                totalPaymentTextBlock.Text = Convert.ToString(cProduct.TotalPayment);
                totalChargeTextBox.Text = Convert.ToString(cProduct.TotalCharge);
                totalChargeWrapTextBox.Text = Convert.ToString(cProduct.TotalChargeWrap);
                totalChargeGSTTextBox.Text = Convert.ToString(cProduct.TotalChargeGST);
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter data again", "Data Entry Error");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
            totalChargeTextBox.Text = "";
            totalChargeWrapTextBox.Text = "";
            totalChargeGSTTextBox.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
