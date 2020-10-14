﻿/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using BleakwindBuffet.Data;
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

        public void OnRemoveClick(object sender, RoutedEventArgs e)
        {
            IOrderItem item = listView.SelectedItem as IOrderItem;
            order.Remove(item);
        }

    }
}
