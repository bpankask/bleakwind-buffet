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
    public class MarkarthMilk
    {
        private bool ice = false;

        private Size size = Size.Small;

        public bool Ice
        {
            get => ice;

            set => ice = value;
        }

        public Size Size
        {
            get => size;

            set => size = value;
        }

        /// <summary>
        /// Access to Price of a drink.
        /// </summary>
        public double Price
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
        public uint Calories
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
        public List<string> SpecialInstructions
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
        /// <returns></returns>
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
