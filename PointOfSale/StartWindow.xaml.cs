/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

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
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : UserControl
    {
        private Order order;

        public StartWindow(Order order)
        {
            InitializeComponent();
            this.order = order;
        }

        /// <summary>
        /// Method to make menu of entrees appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void EntreeMenu(object sender, RoutedEventArgs e)
        {
            entreesButton.Visibility = Visibility.Hidden;
            sidesButton.Visibility = Visibility.Hidden;
            drinksButton.Visibility = Visibility.Hidden;
            menuComponentPlace.Child = new EntreeMenu(order);
        }

        /// <summary>
        /// Method to make menu of sides appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SidesMenu(object sender, RoutedEventArgs e)
        {
            entreesButton.Visibility = Visibility.Hidden;
            sidesButton.Visibility = Visibility.Hidden;
            drinksButton.Visibility = Visibility.Hidden;
            menuComponentPlace.Child = new SideMenu(order);
        }

        /// <summary>
        /// Method to make menu of drinks appear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DrinksMenu(object sender, RoutedEventArgs e)
        {
            entreesButton.Visibility = Visibility.Hidden;
            sidesButton.Visibility = Visibility.Hidden;
            drinksButton.Visibility = Visibility.Hidden;
            menuComponentPlace.Child = new DrinkMenu(order);
        }

        /// <summary>
        /// Reverts back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BackButton(object sender, RoutedEventArgs e)
        {
            menuComponentPlace.Child = new StartWindow(order);
            entreesButton.Visibility = Visibility.Visible;
            sidesButton.Visibility = Visibility.Visible;
            drinksButton.Visibility = Visibility.Visible;
        }

    }
}