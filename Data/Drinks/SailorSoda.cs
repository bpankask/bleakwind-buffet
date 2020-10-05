/*
 * Author: Brayden Pankaskie
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent Sailor Soda drink.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent the Sailor Soda drink.
    /// </summary>
    public class SailorSoda : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variables
        /// </summary>
        private bool ice = true;
        private Size size = Size.Small;
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// Get, set ice.
        /// </summary>
        public bool Ice
        {
            get => ice;

            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
            }
        }

        /// <summary>
        /// Get, set size.
        /// </summary>
        public override Size Size
        {
            get => size;

            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Get, set flavor.
        /// </summary>
        public SodaFlavor Flavor
        {
            get => flavor;

            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
            }
        }

        /// <summary>
        /// Access to Price of a drink.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Large:
                        return 2.07;

                    case Size.Medium:
                        return 1.74;

                    default:
                        return 1.42;
                }
            }
        }

        /// <summary>
        /// Access to Calories of a drink.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Large:
                        return 205;

                    case Size.Medium:
                        return 153;

                    default:
                        return 117;
                }
            }

        }

        /// <summary>
        /// List of special instructions on how to handle drink.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!ice)
                    specialInstructions.Add("Hold ice");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overriden ToString method to return size, flavor and name of drink.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            switch (size)
            {
                case Size.Large:
                    sb.Append("Large ");
                    break;

                case Size.Medium:
                    sb.Append("Medium ");
                    break;

                default:
                    sb.Append("Small ");
                    break;
            }

            switch (flavor)
            {
                case SodaFlavor.Blackberry:
                    sb.Append("Blackberry ");
                    break;

                case SodaFlavor.Cherry:
                    sb.Append("Cherry ");
                    break;

                case SodaFlavor.Grapefruit:
                    sb.Append("Grapefruit ");
                    break;

                case SodaFlavor.Lemon:
                    sb.Append("Lemon ");
                    break;

                case SodaFlavor.Peach:
                    sb.Append("Peach ");
                    break;

                case SodaFlavor.Watermelon:
                    sb.Append("Watermelon ");
                    break;
            }

            sb.Append("Sailor Soda");

            return sb.ToString();
        }
    }
}
