/*
 * Author: Brayden Pankaskie
 * Class: MainWindow.xaml.cs
 * Purpose: Startup window with buttons for to take user to entree, sides, and drink menus
 */

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
        public MainWindow()
        {
            InitializeComponent();
            orderComponentPlace.Child = new OrderComponent();
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
            menuComponentPlace.Child = new MenuSelection("entrees");
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
            menuComponentPlace.Child = new MenuSelection("sides");
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
            menuComponentPlace.Child = new MenuSelection("drinks");
        }

        /// <summary>
        /// Reverts back to main menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BackButton(object sender, RoutedEventArgs e)
        {
            menuComponentPlace.Child = new MenuSelection();
            entreesButton.Visibility = Visibility.Visible;
            sidesButton.Visibility = Visibility.Visible;
            drinksButton.Visibility = Visibility.Visible;
        }
    }
}
