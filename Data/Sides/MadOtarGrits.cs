﻿/*
 * Author: Brayden Pankaskie
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent the Mad Otar Grits side dish.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
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
                        return 1.93;

                    case Size.Medium:
                        return 1.58;

                    default:
                        return 1.22;
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
                        return 179;

                    case Size.Medium:
                        return 142;

                    default:
                        return 105;
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
                    return "Large Mad Otar Grits";

                case Size.Medium:
                    return "Medium Mad Otar Grits";

                default:
                    return "Small Mad Otar Grits";
            }
        }

    }
}
