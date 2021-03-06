﻿/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using BleakwindBuffet.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public StartWindow startWindow = null;
        public OrderComponent orderComponent = null;

        public MainWindow()
        {
            InitializeComponent();
            Order order = new Order();
            StartWindow sw = new StartWindow(order);
            OrderComponent oc = new OrderComponent(order);

            startWindow = sw;
            orderComponent = oc;

            menuComponentPlace.Child = sw;
            orderComponentPlace.Child = oc;
        }

        public void CancelOrder()
        {
            Order order = new Order();
            menuComponentPlace.Child = new StartWindow(order);
            orderComponentPlace.Child = new OrderComponent(order);
        }
    }
}
