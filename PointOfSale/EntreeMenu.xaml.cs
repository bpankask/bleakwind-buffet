/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for EntreeMenu.xaml
    /// </summary>
    public partial class EntreeMenu : UserControl
    {
        public EntreeMenu()
        {
            InitializeComponent();
            PopulateEntreeMenu();
        }

        /// <summary>
        /// Populates entree menu
        /// </summary>
        private void PopulateEntreeMenu()
        {
            button0.Content = "Briarheart Burger";
            button1.Content = "Double Draugr";
            button2.Content = "Thalmor Triple";
            button3.Content = "Smokehouse Skeleton";
            button4.Content = "Garden Orc Omelette";
            button5.Content = "Philly Poacher";
            button6.Content = "Thugs T-Bone";
        }

        /// <summary>
        /// Click event to set up screen and send information to populate special instructions menu.
        /// Also sets up data context for databind.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MenuButtonClick(object sender, RoutedEventArgs e)
        {
            if(sender is Button button)
            {
                if (button == button0) this.DataContext = new BriarheartBurger();
                if (button == button1) this.DataContext = new DoubleDraugr();
                if (button == button2) this.DataContext = new ThalmorTriple();
                if (button == button3) this.DataContext = new SmokehouseSkeleton();
                if (button == button4) this.DataContext = new GardenOrcOmelette();
                if (button == button5) this.DataContext = new PhillyPoacher();
                if (button == button6) this.DataContext = new ThugsTBone();

                customizeWindow.Child = new ItemCustomization(button.Content.ToString());
            }
        }
    }
}
