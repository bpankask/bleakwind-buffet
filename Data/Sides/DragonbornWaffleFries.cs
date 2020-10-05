/*
 * Author: Brayden Pankaskie
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent the Dragonborn WaffleFries side dish.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class to represent the Dragonborn Waffle Fries side.
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private backing variables
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Get, set size.
        /// </summary>
        public Size Size
        {
            get => size;

            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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
        public override uint Calories
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
                    return "Large Dragonborn Waffle Fries";

                case Size.Medium:
                    return "Medium Dragonborn Waffle Fries";

                default:
                    return "Small Dragonborn Waffle Fries";
                    
            }
        }
    }
}
