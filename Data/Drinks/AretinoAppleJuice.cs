/*
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
    public class AretinoAppleJuice
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
        public uint Calories
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
                    return "Large Aretino Apple Juice";

                case Size.Medium:
                    return "Medium Aretino Apple Juice";

                default:
                    return "Small Aretino Apple Juice";
            }
        }

    }
}
