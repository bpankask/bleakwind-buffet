/*
 * Author: Brayden Pankaskie
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent the Vokun Salad side dish.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to represent the Vokun Salad side.
    /// </summary>
    public class VokunSalad
    {
        private Size size = Size.Small;

        /// <summary>
        /// Get, set size.
        /// </summary>
        public Size Size
        {
            get => size;

            set => size = value;
        }

        /// <summary>
        /// Access to Price of a side dish.
        /// </summary>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Large:
                        return 1.82;

                    case Size.Medium:
                        return 1.28;

                    default:
                        return .93;
                }
            }
        }

        /// <summary>
        /// Access to Calories of a side dish.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Large:
                        return 73;

                    case Size.Medium:
                        return 52;

                    default:
                        return 41;
                }
            }
        }

        /// <summary>
        /// Always an empty list for sides.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>();
        }

        /// <summary>
        /// Overriden ToString method to return name of side.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (size)
            {
                case Size.Large:
                    return "Large Vokun Salad";

                case Size.Medium:
                    return "Medium Vokun Salad";

                default:
                    return "Small Vokun Salad";
            }
        }

    }
}
