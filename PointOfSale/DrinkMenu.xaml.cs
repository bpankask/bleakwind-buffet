/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Data;
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
        private Order order;

        public DrinkMenu(Order order)
        {
            InitializeComponent();
            PopulateDrinksMenu();
            this.order = order;
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
                if (button == button0)
                {
                    SailorSoda ss = new SailorSoda();
                    this.DataContext = ss;
                    order.Add(ss);
                }
                if (button == button1) 
                { 
                    MarkarthMilk mm = new MarkarthMilk();
                    this.DataContext = mm;
                    order.Add(mm);
                }
                if (button == button2)
                {
                    AretinoAppleJuice aj = new AretinoAppleJuice();
                    this.DataContext = aj;
                    order.Add(aj);
                }
                if (button == button3)
                {
                    CandlehearthCoffee cc = new CandlehearthCoffee();
                    this.DataContext = cc;
                    order.Add(cc);
                }
                if (button == button4)
                {
                    WarriorWater ww = new WarriorWater();
                    this.DataContext = ww;
                    order.Add(ww);
                }

                customizeWindow.Child = new ItemCustomization(button.Content.ToString());
            }
        }
    }
}
