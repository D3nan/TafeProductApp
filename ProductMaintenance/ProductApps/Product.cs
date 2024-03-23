using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApps
{
    class Product
    {
        private double price;
        private double quantity;
        private double totalPayment;
        private double delivery;
        private double wrapping;
        private double gst;
        private double totalCharge;
        private double totalChargeWrap;
        private double totalChargeGST;

        private double Price
        {
            get { return price; }
            set { price = value; }
        }

        private double Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double TotalPayment
        {
            get { return totalPayment; }
            set { totalPayment = value; }
        }
        public double TotalCharge
        {
            get { return totalCharge; }
            set { totalCharge = value; }
        }

        public double TotalChargeWrap
        {
            get { return totalChargeWrap; }
            set { totalChargeWrap = value; }
        }

        public double TotalChargeGST
        {
            get { return totalChargeGST; }
            set { totalChargeGST = value; }
        }


        private double Delivery
        {
            get { return delivery; }
            set { delivery = value; }
        }


        private double Wrapping
        {
            get { return wrapping; }
            set { wrapping = value; }
        }

        private double GST
        {
            get { return gst; }
            set { gst = value; }
        }

        //Constructor for Product
        public Product(double price, double quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        //Calculate the total payment
        public void calTotalPayment()
        {
            TotalPayment = Price * Quantity;
        }

        //Calculate the total charge
        public void calTotalCharge()
        {
            TotalCharge = TotalPayment + 25;
        }

        //Calculate the total charge and wrap
        public void calTotalChargeWrap()
        {
            TotalChargeWrap = TotalPayment + 25 + 5;
        }

        //Calculate the total charge with GST
        public void calTotalChargeGST()
        {
            TotalChargeGST = TotalChargeWrap * 1.1;
        }
    }
}
