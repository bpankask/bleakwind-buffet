/*
 * Author: Brayden Pankaskie
 * Class name: BriarheartBurger.cs
 * Purpose: Class used to represent the Briarheart Burger entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Briarheart Burger entree.
    /// </summary>
    public class BriarheartBurger
    {
        private bool bun = true;

        private bool ketchup = true;

        private bool mustard = true;

        private bool pickle = true;

        private bool cheese = true;

        /// <summary>
        /// Access to bun field.
        /// </summary>
        public bool Bun
        {
            get => bun;

            set => bun = value;
        }

        /// <summary>
        /// Access to ketchup field.
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;

            set => ketchup = value;
        }

        /// <summary>
        /// Access to mustard field.
        /// </summary>
        public bool Mustard
        {
            get => mustard;

            set => mustard = value;
        }

        /// <summary>
        /// Access to pickle field.
        /// </summary>
        public bool Pickle
        {
            get => pickle;

            set => pickle = value;
        }

        /// <summary>
        /// Access to cheese field.
        /// </summary>
        public bool Cheese
        {
            get => cheese;

            set => cheese = value;
        }

        /// <summary>
        /// Access to Price of entree
        /// </summary>
        public double Price => 6.32;

        /// <summary>
        /// Access to Calories of entree
        /// </summary>
        public uint Calories => 743;

        /// <summary>
        /// List of special instructions on how to handle entree.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!bun) specialInstructions.Add("Hold bun");
                if (!ketchup) specialInstructions.Add("Hold ketchup");
                if (!mustard) specialInstructions.Add("Hold mustard");
                if (!pickle) specialInstructions.Add("Hold pickle");
                if (!cheese) specialInstructions.Add("Hold cheese");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overriden ToString method to return name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
