/*
 * Author: Brayden Pankaskie
 * Class name: GardenOrcOmelette.cs
 * Purpose: Class used to represent the Garden Orc Omelette entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Garden Orc Omelette entree.
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Private field declarations
        /// </summary>
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// Access to get or set broccoli field.
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;

            set => broccoli = value;
        }

        /// <summary>
        /// Access to get or set mushrooms field.
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;

            set => mushrooms = value;
        }

        /// <summary>
        /// Access to get or set tomato field.
        /// </summary>
        public bool Tomato
        {
            get => tomato;

            set => tomato = value;
        }

        /// <summary>
        /// Access to get or set cheddar field.
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;

            set => cheddar = value;
        }

        /// <summary>
        /// Access to Price of entree.
        /// </summary>
        public override double Price => 4.57;

        /// <summary>
        /// Access to Calories of entree.
        /// </summary>
        public override uint Calories => 404;

        /// <summary>
        /// List of special instructions on how to handle entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!broccoli) 
                    specialInstructions.Add("Hold broccoli");
                if (!mushrooms) 
                    specialInstructions.Add("Hold mushrooms");
                if (!tomato) 
                    specialInstructions.Add("Hold tomato");
                if (!cheddar) 
                    specialInstructions.Add("Hold cheddar");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Returns name of entree.
        /// </summary>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

    }
}
