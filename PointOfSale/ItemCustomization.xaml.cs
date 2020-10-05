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
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for ItemCustomization.xaml
    /// </summary>
    public partial class ItemCustomization : UserControl
    {
        private string item;

        /// <summary>
        /// Overriden constructor
        /// </summary>
        /// <param name="item"></param>
        public ItemCustomization(string item)
        {
            InitializeComponent();
            this.item = item;
            DetermineHowToPopulate();
        }

        /// <summary>
        /// Determines what customization information appears on screen
        /// </summary>
        void DetermineHowToPopulate()
        {
            switch (item)
            {
                case "Thalmor Triple":
                    PopulateCustomizationThalmorTriple();
                    break;

                case "Briarheart Burger":
                    PopulateCustomizationBriarheartBurger();
                    break;

                case "Double Draugr":
                    PopulateCustomizationDoubleDraugr();
                    break;

                case "Garden Orc Omelette":
                    PopulateCustomizationGardenOrcOmelette();
                    break;

                case "Philly Poacher":
                    PopulateCustomizationPhillyPoacher();
                    break;

                case "Smokehouse Skeleton":
                    PopulateCustomizationSmokeSkeleton();
                    break;

                case "Sailor’s Soda":
                    PopulateCustomizationSailorSoda();
                    break;

                case "Markarth Milk":
                    PopulateCustomizationMarkarthMilk();
                    break;

                case "Aretino Apple Juice":
                    PopulateCustomizationAppleJuice();
                    break;

                case "Candlehearth Coffee":
                    PopulateCustomizationCandlehearthCoffey();
                    break;

                case "Warrior Water":
                    PopulateCustomizationWarriorWater();
                    break;

                case "Vokun Salad":
                    PopulateCustomizationSides();
                    break;

                case "Fried Miraak":
                    PopulateCustomizationSides();
                    break;

                case "Mad Otar Grits":
                    PopulateCustomizationSides();
                    break;

                case "Dragonborn Waffle Fries":
                    PopulateCustomizationSides();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Populates all information to customize item
        /// </summary>
        void PopulateCustomizationSides()
        {
            sizeBox.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationBriarheartBurger()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Bun";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Bun");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Ketchup";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Ketchup");

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Mustard";
            radioButton2.SetBinding(ToggleButton.IsCheckedProperty, "Mustard");

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pickle";
            radioButton3.SetBinding(ToggleButton.IsCheckedProperty, "Pickle");

            radioButton4.Visibility = Visibility.Visible;
            radioButton4.Content = "Cheese";
            radioButton4.SetBinding(ToggleButton.IsCheckedProperty, "Cheese");
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationDoubleDraugr()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Bun";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Bun");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Ketchup";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Ketchup");

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Mustard";
            radioButton2.SetBinding(ToggleButton.IsCheckedProperty, "Mustard");

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pickle";
            radioButton3.SetBinding(ToggleButton.IsCheckedProperty, "Pickle");

            radioButton4.Visibility = Visibility.Visible;
            radioButton4.Content = "Cheese";
            radioButton4.SetBinding(ToggleButton.IsCheckedProperty, "Cheese");

            radioButton5.Visibility = Visibility.Visible;
            radioButton5.Content = "Tomato";
            radioButton5.SetBinding(ToggleButton.IsCheckedProperty, "Tomato");

            radioButton6.Visibility = Visibility.Visible;
            radioButton6.Content = "Lettuce";
            radioButton6.SetBinding(ToggleButton.IsCheckedProperty, "Lettuce");

            radioButton7.Visibility = Visibility.Visible;
            radioButton7.Content = "Mayo";
            radioButton7.SetBinding(ToggleButton.IsCheckedProperty, "Mayo");
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationThalmorTriple()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Bun";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Bun");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Ketchup";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Ketchup");

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Mustard";
            radioButton2.SetBinding(ToggleButton.IsCheckedProperty, "Mustard");

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pickle";
            radioButton3.SetBinding(ToggleButton.IsCheckedProperty, "Pickle");

            radioButton4.Visibility = Visibility.Visible;
            radioButton4.Content = "Cheese";
            radioButton4.SetBinding(ToggleButton.IsCheckedProperty, "Cheese");

            radioButton5.Visibility = Visibility.Visible;
            radioButton5.Content = "Tomato";
            radioButton5.SetBinding(ToggleButton.IsCheckedProperty, "Tomato");

            radioButton6.Visibility = Visibility.Visible;
            radioButton6.Content = "Lettuce";
            radioButton6.SetBinding(ToggleButton.IsCheckedProperty, "Lettuce");

            radioButton7.Visibility = Visibility.Visible;
            radioButton7.Content = "Mayo";
            radioButton7.SetBinding(ToggleButton.IsCheckedProperty, "Mayo");

            radioButton8.Visibility = Visibility.Visible;
            radioButton8.Content = "Bacon";
            radioButton8.SetBinding(ToggleButton.IsCheckedProperty, "Bacon");

            radioButton9.Visibility = Visibility.Visible;
            radioButton9.Content = "Egg";
            radioButton9.SetBinding(ToggleButton.IsCheckedProperty, "Egg");
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationGardenOrcOmelette()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Broccoli";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Broccoli");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Mushrooms";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Mushrooms");

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Tomato";
            radioButton2.SetBinding(ToggleButton.IsCheckedProperty, "Tomato");

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Cheddar";
            radioButton3.SetBinding(ToggleButton.IsCheckedProperty, "Cheddar");
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationPhillyPoacher()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Sirloin";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Sirloin");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Onion";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Onion");

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Roll";
            radioButton2.SetBinding(ToggleButton.IsCheckedProperty, "Roll");
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationSmokeSkeleton()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Sausage Link";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "SausageLink");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Egg";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Egg");

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Hash Browns";
            radioButton2.SetBinding(ToggleButton.IsCheckedProperty, "HashBrowns");

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pancake";
            radioButton3.SetBinding(ToggleButton.IsCheckedProperty, "Pancake");
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationSailorSoda()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Ice");

            sizeBox.Visibility = Visibility.Visible;
            flavorBox.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationMarkarthMilk()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Ice");

            sizeBox.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationAppleJuice()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Ice");

            sizeBox.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationCandlehearthCoffey()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Ice");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Decaf";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Decaf");

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Room For Cream";
            radioButton2.SetBinding(ToggleButton.IsCheckedProperty, "RoomForCream");

            sizeBox.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Populates all informations to customize item
        /// </summary>
        void PopulateCustomizationWarriorWater()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";
            radioButton0.SetBinding(ToggleButton.IsCheckedProperty, "Ice");

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Lemon";
            radioButton1.SetBinding(ToggleButton.IsCheckedProperty, "Lemon");

            sizeBox.Visibility = Visibility.Visible;
        }

    }
}
