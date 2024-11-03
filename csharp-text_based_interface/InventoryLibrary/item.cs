using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// Class representing an item in the inventory
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// Name of the item
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Description of the item
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Price of the item, limited to 2 decimal points
        /// </summary>
        private float _price;
        public float price 
        { 
            get { return _price; } 
            set { _price = (float)Math.Round(value, 2); } 
        }

        /// <summary>
        /// Tags associated with the item
        /// </summary>
        public List<string> tags { get; set; }

        /// <summary>
        /// Constructor to initialize the item
        /// </summary>
        public Item()
        {
            this.tags = new List<string>();
        }
    }
}
