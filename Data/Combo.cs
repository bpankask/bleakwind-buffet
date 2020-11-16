/*
 * Author: Brayden Pankaskie
 * Last Modified: 10/11/2020
 * Purpose: To represent a combo order
 */

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class to represent a combanation of entree, side, and drink (combo)
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Event to signal combo property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public string Description
        {
            get
            {
                return "";
            }
        }

        /// <summary>
        /// Private backing variables
        /// </summary>
        private Entree entree;
        private Side side;
        private Drink drink;

        /// <summary>
        /// Property to interact with entree field 
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if(entree != value)
                {
                    if(entree != value)
                    {
                        
                        entree = value;
                        PropertyChanged += PropertyChangeEventListener;
                    }
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                }
            }
        }

        /// <summary>
        /// Property to interact with side field 
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != value)
                {
                    side = value;
                    PropertyChanged += PropertyChangeEventListener;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Property to interact with drink field 
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != value)
                {
                    drink = value;
                    PropertyChanged += PropertyChangeEventListener;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
                }
            }
        }

        /// <summary>
        /// Gets price of combo minus 1 dollar discount 
        /// </summary>
        public double Price
        {
            get
            {
                double price = entree.Price + side.Price + drink.Price;
                if(price > 1)
                {
                    return price - 1;
                }
                else
                    throw new Exception("Price of combo cannot be less than dollar.  Something went wrong");
            }
        }

        /// <summary>
        /// Gets total calries of combo
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = entree.Calories + side.Calories + drink.Calories;
                return calories;
            }
        }

        /// <summary>
        /// List of names of items (entree, side, drink) plus its special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();

                list.Add(entree.ToString());
                foreach(string str in entree.SpecialInstructions) list.Add(str);

                list.Add(side.ToString());
                foreach (string str in side.SpecialInstructions) list.Add(str);

                list.Add(drink.ToString());
                foreach (string str in drink.SpecialInstructions) list.Add(str);

                return list;
            }
        }

        /// <summary>
        /// Listens for change in property of an IOrderItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PropertyChangeEventListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }

            if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }

            if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}
