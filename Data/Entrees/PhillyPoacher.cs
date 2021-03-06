﻿/*
 * Author: Brayden Pankaskie
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent the Philly Poacher entree
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Philly Poacher entree.
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
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
                return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll";
            }
        }

        /// <summary>
        /// Private field declarations
        /// </summary>
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

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
        /// Access get or set sirloin field.
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;

            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access get or set onion field.
        /// </summary>
        public bool Onion
        {
            get => onion;

            set
            {
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access get or set roll field.
        /// </summary>
        public bool Roll
        {
            get => roll;

            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access get Price field.
        /// </summary>
        public override double Price => 7.23;

        /// <summary>
        /// Access to Calories field.
        /// </summary>
        public override uint Calories => 784;

        /// <summary>
        /// List of special instructions on how to handle entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!sirloin) 
                    specialInstructions.Add("Hold sirloin");
                if (!onion) 
                    specialInstructions.Add("Hold onions");
                if (!roll) 
                    specialInstructions.Add("Hold roll");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Returns name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
