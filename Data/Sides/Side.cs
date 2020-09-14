using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    public abstract class Side
    {
        /// <summary>
        /// The size of the side dish
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// The price of the side dish
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side dish
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side dish
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
