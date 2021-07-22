using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace InventoryManagementSystem
{
    public class Inventory
    {
        // private variables
        private BindingList<Product> products;
        private BindingList<Part> allParts;


        // public properties
        public BindingList<Product> Products
        {
            get
            {
                return products;
            }
        }

        public BindingList<Part> AllParts
        {
            get 
            { 
                return allParts;
            }
        }

        // constructor
        public Inventory()
        {
            products = new BindingList<Product>();
            allParts = new BindingList<Part>();

            
        }

        //// public methods  //////

        ////// Product Methods //////

        // addProduct
        //      adds a product to the binding list of products
        public void addProduct(Product item)
        {
            products.Add(item);
        }

        // removeProduct
        //      removes a product to the binding list of products, given the ProductID
        public bool removeProduct(int ID)
        {
            foreach (var product in products)
            {
                if (product.ProductID == ID)
                {
                    if (product.AssociatedParts.Count() == 0)
                    {
                        products.Remove(product);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        // lookupProduct
        //      looks up a product given an ID and returns it if found
        public Product lookupProduct(int ID)
        {
            foreach (var product in products)
            {
                if (product.ProductID == ID)
                {
                    return product;
                }
            }
            return null;
        }

        // updateProduct
        //      updates a product given an ID and a new Product to update with
        public void updateProduct(int ID, Product update)
        {
            for (int i=0; i<products.Count(); i++)
            {
                if (products[i].ProductID == ID)
                {
                    products[i] = update;
                }
            }
        }

        ////// Part Methods //////


        // addPart
        //      adds a part to the BindingList of parts
        public void addPart(Part item)
        {
            allParts.Add(item);
        }

        // deletePart
        //      removes a part from the BindingList of parts
        public bool deletePart(Part item)
        {
            return allParts.Remove(item);
        }

        // lookupPart
        //      finds a part given an ID,  if found returns that part
        public Part lookupPart(int ID)
        {
            foreach (var part in allParts)
            {
                if (part.PartID == ID)
                {
                    return part;
                }
            }
            return null;
        }

        // updatePart
        //      updates a part given an ID and the updated Part information (via a Part)
        public void updatePart(int ID, Part update)
        {
            for (int i = 0; i < allParts.Count(); i++)
            {
                if (allParts[i].PartID == ID)
                {
                    allParts[i] = update;
                }
            }
        }
    }
}
