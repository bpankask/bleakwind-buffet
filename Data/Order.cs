using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class to represent an order which is a collection 
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        /// <summary>
        /// Private backing variable for unique order number
        /// </summary>
        private uint nextOrderNumber = 1;

        /// <summary>
        /// Constructor for Order class
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
        }

        public uint Number { get; set; }

        /// <summary>
        /// Property to get and set sales tax rate
        /// </summary>
        public double SalesTaxRate { get; set; } = .12;

        /// <summary>
        /// Property to get subtotal price of everything in order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;

                foreach(IOrderItem item in this.Items) subtotal += item.Price;

                return subtotal;
            }
        }

        /// <summary>
        /// Property to get total tax for order
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }

        /// <summary>
        /// Property for total price of order including tax
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }

        /// <summary>
        /// Property to get total calories from order
        /// </summary>
        public uint Calories
        {
            get
            {
                uint cal = 0;

                foreach (IOrderItem item in this.Items) cal += item.Calories;

                return cal;
            }
        }

    }
}
