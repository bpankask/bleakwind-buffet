/*
 * Author: Brayden Pankaskie
 * Class: MenuSelection.xaml.cs
 * Purpose: Handles menu items of sides, entrees, and drinks
 */

using System;
using System.Collections.Generic;
using System.DirectoryServices;
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
    /// Interaction logic for MenuSelection.xaml
    /// </summary>
    public partial class MenuSelection : UserControl
    {
        string menuIndicator = "";

        /// <summary>
        /// Constructo for MenuSelection
        /// </summary>
        public MenuSelection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overloaded constructor for Menu Selection
        /// </summary>
        /// <param name="menuName"></param>
        public MenuSelection(string menuName)
        {
            InitializeComponent();
            menuIndicator = menuName;
            DetermineHowToPopulate();
        }

        /// <summary>
        /// Method to determine which helper method to call to populate entree, sides, and drink menus
        /// </summary>
        void DetermineHowToPopulate()
        {
            switch (menuIndicator)
            {
                case "entrees":
                    PopulateEntreeMenu();
                    break;

                case "sides":
                    PopulateSidesMenu();
                    break;

                case "drinks":
                    PopulateDrinksMenu();
                    break;

                default:
                    throw new Exception();
            }
        }

        /// <summary>
        /// Populates entree menu
        /// </summary>
        void PopulateEntreeMenu()
        {
            button0.Visibility = Visibility.Visible;
            button0.Content = "Briarheart Burger";

            button1.Visibility = Visibility.Visible;
            button1.Content = "Double Draugr";

            button2.Visibility = Visibility.Visible;
            button2.Content = "Thalmor Triple";

            button3.Visibility = Visibility.Visible;
            button3.Content = "Smokehouse Skeleton";

            button4.Visibility = Visibility.Visible;
            button4.Content = "Garden Orc Omelette";

            button5.Visibility = Visibility.Visible;
            button5.Content = "Philly Poacher";

            button6.Visibility = Visibility.Visible;
            button6.Content = "Thugs T-Bone";
        }

        /// <summary>
        /// Populates sides menu
        /// </summary>
        void PopulateSidesMenu()
        {
            button0.Visibility = Visibility.Visible;
            button0.Content = "Vokun Salad";

            button1.Visibility = Visibility.Visible;
            button1.Content = "Fried Miraak";

            button2.Visibility = Visibility.Visible;
            button2.Content = "Mad Otar Grits";

            button3.Visibility = Visibility.Visible;
            button3.Content = "Dragonborn Waffle Fries";
        }

        /// <summary>
        /// Populates drinks menu
        /// </summary>
        void PopulateDrinksMenu()
        {
            button0.Visibility = Visibility.Visible;
            button0.Content = "Sailor’s Soda";

            button1.Visibility = Visibility.Visible;
            button1.Content = "Markarth Milk";

            button2.Visibility = Visibility.Visible;
            button2.Content = "Aretino Apple Juice";

            button3.Visibility = Visibility.Visible;
            button3.Content = "Candlehearth Coffee";

            button4.Visibility = Visibility.Visible;
            button4.Content = "Warrior Water";
        }

        /// <summary>
        /// Click event to set up screen and send information to populate special instructions menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MenuButtonClick(object sender, RoutedEventArgs e)
        {
            button0.Visibility = Visibility.Hidden;
            button1.Visibility = Visibility.Hidden;
            button2.Visibility = Visibility.Hidden;
            button3.Visibility = Visibility.Hidden;
            button4.Visibility = Visibility.Hidden;
            button5.Visibility = Visibility.Hidden;
            button6.Visibility = Visibility.Hidden;

            string item = (sender as Button).Content.ToString();
            generalMenuBorder.Child = new ItemCustomization(item);
        }
    }
}
