/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        private Order order;

        public OrderComponent(Order order)
        {
            InitializeComponent();
            this.order = order;
            DataContext = order;
        }

        /// <summary>
        /// Listener for removing an item from order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnRemoveClick(object sender, RoutedEventArgs e)
        {
            IOrderItem item = listView.SelectedItem as IOrderItem;
            order.Remove(item);
        }

        /// <summary>
        /// Handles cancel button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelOrderClick(object sender, RoutedEventArgs e)
        {
            DependencyObject parent = this;
            do
            {
                // Get this node's parent
                parent = LogicalTreeHelper.GetParent(parent);
            } 
            while (!(parent is null || parent is MainWindow));

            MainWindow mw = parent as MainWindow;
            mw.CancelOrder();
            
        }

        void OnFinalizeClick(object sender, RoutedEventArgs e)
        {
            String[] recieptArr = { "Order #" + order.Number.ToString(), GetDataTime(), "SubTotal: " + order.Subtotal.ToString(),
            "Tax: " + order.Tax.ToString(), "Total: " + order.Total.ToString() };
            try
            {
                foreach (String str in recieptArr)
                {
                    if (str.ToCharArray().Length > 40)
                    {
                        throw new Exception("Content for Reciept to long");
                    }
                }

                RecieptPrinter.PrintLine("Order #" + order.Number.ToString());
                RecieptPrinter.PrintLine(GetDataTime());
                foreach (IOrderItem item in order)
                {
                    RecieptPrinter.PrintLine(item.ToString() + ":");
                    foreach (String spec in item.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("-" + spec);
                    }
                }
                RecieptPrinter.PrintLine("");
                RecieptPrinter.PrintLine("SubTotal: " + order.Subtotal.ToString());
                RecieptPrinter.PrintLine("Tax: " + order.Tax.ToString());
                RecieptPrinter.PrintLine("Total: " + order.Total.ToString());
                RecieptPrinter.PrintLine("Payment Type: " + order.PaymentType);
                RecieptPrinter.PrintLine("Change: " + order.ChangeOwed);
                RecieptPrinter.CutTape();

                DependencyObject parent = this;
                do
                {
                    // Get this node's parent
                    parent = LogicalTreeHelper.GetParent(parent);
                }
                while (!(parent is null || parent is MainWindow));

                MainWindow mw = parent as MainWindow;
                mw.CancelOrder();
            }
            catch
            {
                throw new Exception("Error in Printing Reciept");
            }
           
        }

        public static String GetDataTime()
        {
            DateTime localDate = DateTime.Now;
            return localDate.ToString();

        }
        

    }
}
