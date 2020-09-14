/*
 * Author: Brayden Pankaskie
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent Markarth Milk drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent the Markarth Milk drink.
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        private bool ice = false;

        private Size size = Size.Small;

        /// <summary>
        /// Get, set ice.
        /// </summary>
        public bool Ice
        {
            get => ice;

            set => ice = value;
        }

        /// <summary>
        /// Get, set size.
        /// </summary>
        public override Size Size
        {
            get => size;

            set => size = value;
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
                        return 1.22;

                    case Size.Medium:
                        return 1.11;

                    default:
                        return 1.05;
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
                        return 93;

                    case Size.Medium:
                        return 72;

                    default:
                        return 56;
                }
            }
        }

        /// <summary>
        /// List of special instructions on how to handle drink.
        /// </summary>
        /// <return>List of instruction for drink</return>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (ice == true)
                    specialInstructions.Add("Add ice");

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
                    return "Large Markarth Milk";

                case Size.Medium:
                    return "Medium Markarth Milk";

                default:
                    return "Small Markarth Milk";
            }
        }
    }
}
