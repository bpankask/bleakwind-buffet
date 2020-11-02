/*
 * Author: Brayden Pankaskie
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent the Double Draugr entree
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Double Draugr entree.
    /// </summary>
    public class DoubleDraugr : Entree, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event for changing properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Private field declarations
        /// </summary>
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

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
        /// Access to bun field.
        /// </summary>
        public bool Bun
        {
            get => bun;

            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to ketchup field.
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;

            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to mustard field.
        /// </summary>
        public bool Mustard
        {
            get => mustard;

            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to pickle field.
        /// </summary>
        public bool Pickle
        {
            get => pickle;

            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to cheese field.
        /// </summary>
        public bool Cheese
        {
            get => cheese;

            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to tomato field.
        /// </summary>
        public bool Tomato
        {
            get => tomato;

            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to lettuce field.
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;

            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to mayo field.
        /// </summary>
        public bool Mayo
        {
            get => mayo;

            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to Price of entree
        /// </summary>
        public override double Price => 7.32;

        /// <summary>
        /// Access to Calories of entree
        /// </summary>
        public override uint Calories => 843;

        /// <summary>
        /// List of special instructions on how to handle entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!bun) specialInstructions.Add("Hold bun");
                if (!ketchup) specialInstructions.Add("Hold ketchup");
                if (!mustard) specialInstructions.Add("Hold mustard");
                if (!pickle) specialInstructions.Add("Hold pickle");
                if (!cheese) specialInstructions.Add("Hold cheese");
                if (!tomato) specialInstructions.Add("Hold tomato");
                if (!lettuce) specialInstructions.Add("Hold lettuce");
                if (!mayo) specialInstructions.Add("Hold mayo");
              
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
