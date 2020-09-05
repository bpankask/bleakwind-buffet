/*
 * Author: Brayden Pankaskie
 * Class name: ThugsTBone.cs
 * Purpose: Class used to represent the Thugs T-Bone entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Thugs T Bone entree.
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Access to Price of entree
        /// </summary>
        public double Price => 6.44;

        /// <summary>
        /// Access to Calories of entree
        /// </summary>
        public uint Calories => 982;

        /// <summary>
        /// Empty list always.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get => new List<string>(); 
        }

        /// <summary>
        /// Overriden ToString method to return name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
