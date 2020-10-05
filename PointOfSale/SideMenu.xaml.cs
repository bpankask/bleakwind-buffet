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
        public SideMenu()
        {
            InitializeComponent();
            PopulateSidesMenu();
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
                if (button == button0) this.DataContext = new VokunSalad();
                if (button == button1) this.DataContext = new FriedMiraak();
                if (button == button2) this.DataContext = new MadOtarGrits();
                if (button == button3) this.DataContext = new DragonbornWaffleFries();

                customizeWindow.Child = new ItemCustomization(button.Content.ToString());
            }
        }

    }
}
