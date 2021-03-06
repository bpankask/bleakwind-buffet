﻿/*
 * Author: Brayden Pankaskie
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class to represent the Smokehouse Skeleton entree.
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
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
                return "Put some meat on those bones with a small stack of pancakes. Includes sausage links, eggs, " +
                    "and hash browns on the side. Topped with the syrup of your choice.";
            }
        }

        /// <summary>
        /// Private field declarations
        /// </summary>
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;

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
        /// Access to sausageLink field.
        /// </summary>
        public bool SausageLink 
        {
            get => sausageLink;

            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
            
        }

        /// <summary>
        /// Access to egg field.
        /// </summary>
        public bool Egg
        {
            get => egg;

            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to hashBrowns field.
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;

            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to pancake field.
        /// </summary>
        public bool Pancake
        {
            get => pancake;

            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Access to Price of entree.
        /// </summary>
        public override double Price => 5.62;

        /// <summary>
        /// Access to Calories of entree.
        /// </summary>
        public override uint Calories => 602;

        /// <summary>
        /// List of special instructions on how to handle entree.
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> specialInstructions = new List<string>();
                if (!sausageLink) 
                    specialInstructions.Add("Hold sausage");
                if (!egg) 
                    specialInstructions.Add("Hold eggs");
                if (!hashBrowns) 
                    specialInstructions.Add("Hold hash browns");
                if (!pancake) 
                    specialInstructions.Add("Hold pancakes");

                return specialInstructions;
            }
        }

        /// <summary>
        /// Returns name of entree.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
