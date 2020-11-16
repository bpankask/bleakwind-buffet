/*
 * Author: Brayden Pankaskie
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Warrior Water drink.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class to represent the Warrior Water drink.
    /// </summary>
    public class WarriorWater : Drink, IOrderItem, INotifyPropertyChanged
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
                return "It’s water. Just water";
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
        /// Private backing variables
        /// </summary>
        private bool ice = true;
        private bool lemon = false;
        private Size size = Size.Small;

        /// <summary>
        /// Get, set ice.
        /// </summary>
        public bool Ice
        {
            get => ice;

            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Get, set lemon.
        /// </summary>
        public bool Lemon
        {
            get => lemon;

            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        /// <summary>
        /// Access to Price of a drink.
        /// </summary>
        public override double Price
        {
            get => 0.00;
        }

        /// <summary>
        /// Access to Calories of a drink.
        /// </summary>
        public override uint Calories
        {
            get => 0;
        }

        /// <summary>
        /// List of special instructions on how to handle drink.
        /// </summary>
        public override List<string> SpecialInstructions
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
