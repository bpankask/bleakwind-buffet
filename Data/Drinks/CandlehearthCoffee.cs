/*
 * Author: Brayden Pankaskie
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Candlehearth Coffee drink.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent the Candlehearth Coffee drink.
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variables
        /// </summary>
        private bool ice = false;
        private bool decaf = false;
        private bool roomForCream = false;
        private Size size = Size.Small;

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
        /// Get, set decaf.
        /// </summary>
        public bool Decaf
        {
            get => decaf;

            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
            }
        }

        /// <summary>
        /// Get, set roomForCream.
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;

            set
            {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
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
        /// Access to Price of a drink.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Large:
                        return 1.75;

                    case Size.Medium:
                        return 1.25;

                    default:
                        return .75;
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
                        return 20;

                    case Size.Medium:
                        return 10;

                    default:
                        return 7;
                }
            }
        }

        /// <summary>
        /// List of special instructions on how to handle drink.
        /// </summary>
        /// <return>List of instructions for drink</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (ice == true)
                    specialInstructions.Add("Add ice");

                if (roomForCream == true)
                    specialInstructions.Add("Add cream");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overriden ToString method to return name and size of drink.
        /// </summary>
        /// <returns>Name of drink</returns>
        public override string ToString()
        {
            switch (size)
            {
                case Size.Large:
                    if (!decaf)
                        return "Large Candlehearth Coffee";
                    else
                        return "Large Decaf Candlehearth Coffee";

                case Size.Medium:
                    if (!decaf)
                        return "Medium Candlehearth Coffee";
                    else
                        return "Medium Decaf Candlehearth Coffee";

                default:
                    if (!decaf)
                        return "Small Candlehearth Coffee";
                    else
                        return "Small Decaf Candlehearth Coffee";
            }   
        }
    }
}
