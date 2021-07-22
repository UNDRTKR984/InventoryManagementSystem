using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public abstract class Part
    {
        // private varibles
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        // public properties
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { 
            get {
                return price;
            }
            set
            {
                // validate price
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
             value, $"{nameof(Price)} must be >= 0");
                }
                else
                {
                    price = value;
                }
            }
        }

        public int InStock
        {
            get
            {
                return inStock;
            }
            set
            {
                // anything less than 0 just gets set to 0
                if (value < 0)
                {
                    inStock = 0;
                }
                else
                {
                    inStock = value;
                }
            }
        }

        public int Min
        {
            get
            {
                return min;
            }
            set
            {
                // if value is less than 0, just set to 0
                if (value < 0)
                {
                    min = 0;
                }
                else
                {
                    min = value;
                }
            }
        }

        public int Max
        {
            get
            {
                return max;
            }
            set
            {
                // if value is less than 0, just set to 0
                if (value < 0)
                {
                    max = 0;
                }
                else
                {
                    max = value;
                }
            }
        }

        // constructor
        public Part (int partID, string name, decimal partPrice, int partStock, int partMin, int partMax)
        {
            PartID = partID;
            Name = name;
            Price = partPrice;
            InStock = partStock;
            Min = partMin;
            Max = partMax;

        }
    }
}
