﻿/*
 * Author: Brayden Pankaskie
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent Sailor Soda drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda
    {
        private bool ice = true;

        private Size size = Size.Small;

        private SodaFlavor flavor = SodaFlavor.Cherry;

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

        public SodaFlavor Flavor
        {
            get => flavor;

            set => flavor = value;
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
        public uint Calories
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
        public List<string> SpecialInstructions
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
                    sb.Append("Meduim ");
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
