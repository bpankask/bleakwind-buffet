﻿/*
 * Author: Brayden Pankaskie
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent the Fried Miraak side dish.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to represent the Fried Miraak side.
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Description of item
        /// </summary>
        public string Description
        {
            get
            {
                return "Perfectly prepared hash brown pancakes";
            }
        }

        /// <summary>
        /// Hold name of item for binding 
        /// </summary>
        public string Name
        {
            get
            {
                return this.ToString();
            }

            set
            {
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// Private backing variable
        /// </summary>
        private Size size = Size.Small;

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// Access to Price of a side dish.
        /// </summary>
        public override double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Large:
                        return 2.88;

                    case Size.Medium:
                        return 2.01;

                    default:
                        return 1.78;
                }
            }
        }

        /// <summary>
        /// Access to Calories of a side dish.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Large:
                        return 306;

                    case Size.Medium:
                        return 236;

                    default:
                        return 151;
                }
            }

        }

        /// <summary>
        /// Always an empty list for sides.
        /// </summary>
        public override List<string> SpecialInstructions
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
                    return "Large Fried Miraak";

                case Size.Medium:
                    return "Medium Fried Miraak";

                default:
                    return "Small Fried Miraak";
            }
        }
    }
}
