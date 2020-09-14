﻿/*
 * Author: Brayden Pankaskie
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Aretino Apple Juice drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent the Aretino Apple Juice drink.
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
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
                        return 1.01;

                    case Size.Medium:
                        return 0.87;

                    default:
                        return .62;
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
                        return 132;

                    case Size.Medium:
                        return 88;

                    default:
                        return 44;
                }
            }
        }

        /// <summary>
        /// List of special instructions on how to handle drink.
        /// </summary>
        /// <return>A list of instructions for drink</return>
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
                    return "Large Aretino Apple Juice";

                case Size.Medium:
                    return "Medium Aretino Apple Juice";

                default:
                    return "Small Aretino Apple Juice";
            }
        }

    }
}
