using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections;
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
    /// Interaction logic for PaymentType.xaml
    /// </summary>
    public partial class PaymentType : UserControl
    {
        private Order order = null;

        public PaymentType(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        void OnCardTransactionClick(object sender, RoutedEventArgs e)
        {

            order.PaymentType = "Debit/Credit Card";

            CardTransactionResult result =  CardReader.RunCard(order.Total);

            cardButton.Visibility = Visibility.Hidden;
            cashButton.Visibility = Visibility.Hidden;
            paymentBorder.Background = Brushes.Gray;

            TextBlock b = new TextBlock();
            b.Foreground = Brushes.Beige;
            b.FontSize = 40;
            b.VerticalAlignment = VerticalAlignment.Center;
            b.HorizontalAlignment = HorizontalAlignment.Center;

            switch (result)
            {
                case CardTransactionResult.Approved:
                    b.Text = "Approved";
                    SetFinalizeSaleButton();
                    break;

                case CardTransactionResult.Declined:
                    b.Text = "Declined";
                    break;

                case CardTransactionResult.ReadError:
                    b.Text = "Read Error";
                    break;

                case CardTransactionResult.InsufficientFunds:
                    b.Text = "Insufficient Funds";
                    break;

                case CardTransactionResult.IncorrectPin:
                    b.Text = "Incorrect Pin";
                    break;
            }

            paymentBorder.Child = b;
        }

        /// <summary>
        /// Activates finalize sale button to finalize sale
        /// </summary>
        public void SetFinalizeSaleButton()
        {
            DependencyObject parent = this;
            do
            {
                // Get this node's parent
                parent = LogicalTreeHelper.GetParent(parent);
            }
            while (!(parent is null || parent is MainWindow));

            MainWindow mw = parent as MainWindow;

            mw.orderComponent.finalizeButton.IsEnabled = true; ;
            
        }

        void OnCashButtonClick(object sender, RoutedEventArgs e)
        {
            order.PaymentType = "Cash";
            SetFinalizeSaleButton();
            paymentBorder.Child = new CashRegister(order);
        }
    }
}
