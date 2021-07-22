using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementSystem
{
    public class Product
    {
        //// private variables
        private BindingList<Part> associatedParts;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        //// public properties
        public BindingList<Part> AssociatedParts
        {
            get
            {
                return associatedParts;
            }
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        
        public decimal Price
        {
            get
            {
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
        public Product(int productID, string productName, decimal productPrice, int productStock, int productMin, int productMax, BindingList<Part> productAssociatedParts)
        {
            associatedParts = productAssociatedParts;
            ProductID = productID;
            Name = productName;
            Price = productPrice;
            InStock = productStock;
            Min = productMin;
            Max = productMax;
        }

        //// Public Methods /////

        // addAssociatedPart
        //      adds a part that is to be associated with this product
        public void addAssociatedPart (Part part)
        {
            associatedParts.Add(part);
        }

        // removeAssociatedPart
        //      removes a part from this product
        public bool removeAssociatedPart(int ID)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == ID)
                {
                    associatedParts.Remove(part);
                    return true;
                }
            }
            return false;
        }

        // lookupAssociated Part
        //      looks in the associated parts list, and if it finds it, returns the part
        public Part lookupAssociatedPart(int ID)
        {
            foreach (var part in AssociatedParts)
            {
                if (part.PartID == ID)
                {
                    return part;
                }
            }
            return null;
        }

        public override string ToString()
        {
            String format = "{0,5}{1,25}{2,25}{3,25}{4,15}{5,20}";
            return String.Format(format, ProductID, Name, InStock, Price, Min, Max);
        }
    }
}
