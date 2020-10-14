/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using BleakwindBuffet.Data;
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
        private Order order;

        public EntreeMenu(Order order)
        {
            InitializeComponent();
            PopulateEntreeMenu();
            this.order = order;
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
                if (button == button0)
                {
                    BriarheartBurger bb = new BriarheartBurger();
                    this.DataContext = bb;
                    order.Add(bb);
                }
                if (button == button1)
                {
                    DoubleDraugr dd = new DoubleDraugr();
                    this.DataContext = dd;
                    order.Add(dd);
                }
                if (button == button2)
                {
                    ThalmorTriple tt = new ThalmorTriple();
                    this.DataContext = tt;
                    order.Add(tt);
                }
                if (button == button3)
                {
                    SmokehouseSkeleton ss = new SmokehouseSkeleton();
                    this.DataContext = ss;
                    order.Add(ss);
                }
                if (button == button4)
                {
                    GardenOrcOmelette go = new GardenOrcOmelette();
                    this.DataContext = go;
                    order.Add(go);
                }
                if (button == button5)
                {
                    PhillyPoacher pp = new PhillyPoacher();
                    this.DataContext = pp;
                    order.Add(pp);
                }
                if (button == button6)
                {
                    ThugsTBone tt = new ThugsTBone();
                    this.DataContext = tt;
                    order.Add(tt);
                }

                customizeWindow.Child = new ItemCustomization(button.Content.ToString());
            }
        }
    }
}
