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
        private bool isCombo = false;

        public bool IsCombo
        {
            get { return isCombo; }
            set
            {
                isCombo = value;
            }
        }

        /// <summary>
        /// Records payment type for reciept
        /// </summary>
        public String PaymentType { get; set; }

        /// <summary>
        /// Records the total change owed customer
        /// </summary>
        public double ChangeOwed { get; set; }

        /// <summary>
        /// Constructor for Order class
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedEventListener;
        }

        void CollectionChangedEventListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            OnPropertyChanged(new PropertyChangedEventArgs("Calories"));

            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Size")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
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

                return Math.Round(subtotal, 2);
            }
        }

        /// <summary>
        /// Property to get total tax for order
        /// </summary>
        public double Tax
        {
            get
            {
                return Math.Round(Subtotal * SalesTaxRate, 2);
            }
        }

        /// <summary>
        /// Property for total price of order including tax
        /// </summary>
        public double Total
        {
            get
            {
                return Math.Round(Subtotal + Tax, 2);
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
