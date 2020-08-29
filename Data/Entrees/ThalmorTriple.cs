/*
 * Author: Brayden Pankaskie
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent the Thalmor Triple entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class ThalmorTriple
    {
        private bool bun = true;

        private bool ketchup = true;

        private bool mustard = true;

        private bool pickle = true;

        private bool cheese = true;

        private bool tomato = true;

        private bool lettuce = true;

        private bool mayo = true;

        private bool bacon = true;

        private bool egg = true;

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
        /// Access to tomato field.
        /// </summary>
        public bool Tomato
        {
            get => tomato;

            set => tomato = value;
        }

        /// <summary>
        /// Access to lettuce field.
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;

            set => lettuce = value;
        }

        /// <summary>
        /// Access to mayo field.
        /// </summary>
        public bool Mayo
        {
            get => mayo;

            set => mayo = value;
        }

        /// <summary>
        /// Access to bacon field.
        /// </summary>
        public bool Bacon
        {
            get => bacon;

            set => bacon = value;
        }

        /// <summary>
        /// Access to egg field.
        /// </summary>
        public bool Egg
        {
            get => egg;

            set => egg = value;
        }

        /// <summary>
        /// Access to Price of entree
        /// </summary>
        public double Price => 8.32;

        /// <summary>
        /// Access to Calories of entree
        /// </summary>
        public uint Calories => 943;

        /// <summary>
        /// List of special instructions on how to handle entree.
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!bacon) specialInstructions.Add("Hold bacon");
                if (!egg) specialInstructions.Add("Hold egg");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Overriden ToString method to return name of entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
