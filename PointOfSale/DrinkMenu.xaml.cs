/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using BleakwindBuffet.Data.Drinks;
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
    /// Interaction logic for DrinkMenu.xaml
    /// </summary>
    public partial class DrinkMenu : UserControl
    {
        public DrinkMenu()
        {
            InitializeComponent();
            PopulateDrinksMenu();
        }

        /// <summary>
        /// Populates drinks menu
        /// </summary>
        private void PopulateDrinksMenu()
        {
            button0.Content = "Sailor’s Soda";
            button1.Content = "Markarth Milk";
            button2.Content = "Aretino Apple Juice";
            button3.Content = "Candlehearth Coffee";
            button4.Content = "Warrior Water";
        }

        /// <summary>
        /// Click event to set up screen and send information to populate special instructions menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MenuButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (button == button0) this.DataContext = new SailorSoda();
                if (button == button1) this.DataContext = new MarkarthMilk();
                if (button == button2) this.DataContext = new AretinoAppleJuice();
                if (button == button3) this.DataContext = new CandlehearthCoffee();
                if (button == button4) this.DataContext = new WarriorWater();

                customizeWindow.Child = new ItemCustomization(button.Content.ToString());
            }
        }
    }
}
