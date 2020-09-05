/*
 * Author: Brayden Pankaskie
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Warrior Water drink.
 */

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent the Warrior Water drink.
    /// </summary>
    public class WarriorWater
    {
        private bool ice = true;

        private bool lemon = false;

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
        /// Get, set lemon.
        /// </summary>
        public bool Lemon
        {
            get => lemon;

            set => lemon = value;
        }

        /// <summary>
        /// Get, set size.
        /// </summary>
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
            get => 0.00;
        }

        /// <summary>
        /// Access to Calories of a drink.
        /// </summary>
        public uint Calories
        {
            get => 0;
        }

        /// <summary>
        /// List of special instructions on how to handle drink.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (ice == false)
                    specialInstructions.Add("Hold ice");

                if(lemon == true)
                    specialInstructions.Add("Add lemon");
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
                    return "Large Warrior Water";

                case Size.Medium:
                    return "Medium Warrior Water";

                default:
                    return "Small Warrior Water";
            }
        }
    }
}
