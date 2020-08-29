/*
 * Author: Brayden Pankaskie
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent the Smokehouse Skeleton entree
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        private bool sausageLink = true;

        private bool egg = true;

        private bool hashBrowns = true;

        private bool pancake = true;

        /// <summary>
        /// Access to sausageLink field.
        /// </summary>
        public bool SausageLink 
        {
            get => sausageLink;

            set => sausageLink = value;
            
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
        /// Access to hashBrowns field.
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;

            set => hashBrowns = value;
        }

        /// <summary>
        /// Access to pancake field.
        /// </summary>
        public bool Pancake
        {
            get => pancake;

            set => pancake = value;
        }

        /// <summary>
        /// Access to Price of entree.
        /// </summary>
        public double Price => 5.62;

        /// <summary>
        /// Access to Calories of entree.
        /// </summary>
        public uint Calories => 602;

        /// <summary>
        /// List of special instructions on how to handle entree.
        /// </summary>
        public List<string> SpecialInstructions
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
