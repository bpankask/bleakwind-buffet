/*
 * Author: Brayden Pankaskie
 * Last Updated: 10/04/2020
 * Purpose: Backend for XAML of same name
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
    {
        private Order order;

        public SideMenu(Order order)
        {
            InitializeComponent();
            PopulateSidesMenu();
            this.order = order;
        }

        /// <summary>
        /// Populates sides menu
        /// </summary>
        private void PopulateSidesMenu()
        {
            button0.Content = "Vokun Salad";
            button1.Content = "Fried Miraak";
            button2.Content = "Mad Otar Grits";
            button3.Content = "Dragonborn Waffle Fries";
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
                    VokunSalad vs = new VokunSalad();
                    this.DataContext = vs;
                    order.Add(vs);
                }
                if (button == button1)
                {
                    FriedMiraak fm = new FriedMiraak();
                    this.DataContext = fm;
                    order.Add(fm);
                }
                if (button == button2)
                {
                    MadOtarGrits mg = new MadOtarGrits();
                    this.DataContext = mg;
                    order.Add(mg);
                }
                if (button == button3)
                {
                    DragonbornWaffleFries df = new DragonbornWaffleFries();
                    this.DataContext = df;
                    order.Add(df);
                }

                customizeWindow.Child = new ItemCustomization(button.Content.ToString());
            }
        }

    }
}
