/*
 * Author: Brayden Pankaskie
 * Class: ItemCustomization.xaml.cs
 * Purpose: Handles customization of order
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemCustomization.xaml
    /// </summary>
    public partial class ItemCustomization : UserControl
    {
        private string item;

        public ItemCustomization()
        {
            InitializeComponent();
        }

        public ItemCustomization(string item)
        {
            InitializeComponent();
            this.item = item;
            DetermineHowToPopulate();
        }

        void DetermineHowToPopulate()
        {
            switch (item)
            {
                case "Thalmor Triple":
                    PopulateCustomizationThalmorTriple();
                    break;

                case "Briarheart Burger":
                    PopulateCustomizationBriarheartBuger();
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

        void PopulateCustomizationSides()
        {
            sizeBox.Visibility = Visibility.Visible;
        }

        void PopulateCustomizationBriarheartBuger()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Bun";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Ketchup";

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Mustard";

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pickle";

            radioButton4.Visibility = Visibility.Visible;
            radioButton4.Content = "Cheese";
        }

        void PopulateCustomizationDoubleDraugr()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Bun";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Ketchup";

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Mustard";

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pickle";

            radioButton4.Visibility = Visibility.Visible;
            radioButton4.Content = "Cheese";

            radioButton5.Visibility = Visibility.Visible;
            radioButton5.Content = "Tomato";

            radioButton6.Visibility = Visibility.Visible;
            radioButton6.Content = "Lettuce";

            radioButton7.Visibility = Visibility.Visible;
            radioButton7.Content = "Mayo";
        }

        void PopulateCustomizationThalmorTriple()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Bun";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Ketchup";

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Mustard";

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pickle";

            radioButton4.Visibility = Visibility.Visible;
            radioButton4.Content = "Cheese";

            radioButton5.Visibility = Visibility.Visible;
            radioButton5.Content = "Tomato";

            radioButton6.Visibility = Visibility.Visible;
            radioButton6.Content = "Lettuce";

            radioButton7.Visibility = Visibility.Visible;
            radioButton7.Content = "Mayo";

            radioButton8.Visibility = Visibility.Visible;
            radioButton8.Content = "Bacon";

            radioButton9.Visibility = Visibility.Visible;
            radioButton9.Content = "Egg";
        }

        void PopulateCustomizationGardenOrcOmelette()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Broccoli";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Mushrooms";

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Tomato";

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Cheddar";
        }

        void PopulateCustomizationPhillyPoacher()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Sirloin";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Onion";

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Roll";
        }

        void PopulateCustomizationSmokeSkeleton()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Sausage Link";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Egg";

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Hash Browns";

            radioButton3.Visibility = Visibility.Visible;
            radioButton3.Content = "Pancake";
        }

        void PopulateCustomizationSailorSoda()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";

            sizeBox.Visibility = Visibility.Visible;
            flavorBox.Visibility = Visibility.Visible;
        }

        void PopulateCustomizationMarkarthMilk()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";

            sizeBox.Visibility = Visibility.Visible;
        }

        void PopulateCustomizationAppleJuice()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";

            sizeBox.Visibility = Visibility.Visible;
        }

        void PopulateCustomizationCandlehearthCoffey()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Decaf";

            radioButton2.Visibility = Visibility.Visible;
            radioButton2.Content = "Room For Cream";

            sizeBox.Visibility = Visibility.Visible;
        }

        void PopulateCustomizationWarriorWater()
        {
            radioButton0.Visibility = Visibility.Visible;
            radioButton0.Content = "Ice";

            radioButton1.Visibility = Visibility.Visible;
            radioButton1.Content = "Lemon";

            sizeBox.Visibility = Visibility.Visible;
        }

    }
}
