﻿/*
 * Author: Brayden Pankaskie
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn WaffleFries side dish.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {

        private Size size = Size.Small;

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
                        return 0.96;
                       
                    case Size.Medium:
                        return 0.76;

                    default:
                        return 0.42;
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
                        return 100;

                    case Size.Medium:
                        return 89;

                    default:
                        return 77;
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
                    return "Large Dragonborn Waffle Fries";

                case Size.Medium:
                    return "Medium Dragonborn Waffle Fries";

                default:
                    return "Small Dragonborn Waffle Fries";
            }
        }
    }
}