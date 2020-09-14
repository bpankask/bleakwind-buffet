using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// An interface for drinks, entrees, and sides
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The Price of the item
        /// </summary>
        /// <value>In US Dollars</value>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special Instructions for how to prepare item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
