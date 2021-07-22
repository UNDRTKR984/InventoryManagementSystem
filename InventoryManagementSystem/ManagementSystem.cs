using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryManagementSystem
{
    public partial class ManagementSystem : Form
    {
        // public static variables
        public static int PartID { get; set; } = 0;
        public static int ProductID { get; set; } = 0;
        public static Product ActiveProduct = null;
        public static Part ActivePart = null;

        // public variables
        public static Inventory Inventory;

        // public forms
        public AddPart PartAdd;
        public ModifyPart ModifyPart;
        public AddProduct AddProduct;
        public ModifyProduct ModifyProduct;

        // private variables
        private int productsActiveIndex = -1;
        private int partsActiveIndex = -1;
        private BindingList<Part> activePartList;
        private BindingList<Product> activeProductList;

        // constructor
        public ManagementSystem()
        {
            InitializeComponent();
            // create the inventory
            Inventory = new Inventory();


            // dummy data
            Inventory.addProduct(new Product(ProductID++, "Bike", (decimal)459.99, 25, 2, 50, new BindingList<Part>()));
            Inventory.addProduct(new Product(ProductID++, "Skateboard", (decimal)259.99, 10, 2, 50, new BindingList<Part>()));
            Inventory.addPart(new Outsourced("System Techonology", PartID++, "Seat", (decimal)29.99, 22, 2, 50));
            Inventory.addPart(new Outsourced("Vogel Systems", PartID++, "Skateboard Wheel", (decimal)5.99, 60, 1, 900));
            Inventory.addPart(new Outsourced("Vogel Systems", PartID++, "Bike Wheel", (decimal)9.99, 120, 1, 900));
            Inventory.addPart(new Inhouse(0, PartID++, "Bike Frame", (decimal)50.00, 70, 1, 600));
            Inventory.addPart(new Inhouse(1, PartID++, "Board", (decimal)10.99, 80, 1, 600));

            // set the data source for each dataViewGrid
            ProductDataView.DataSource = Inventory.Products;
            PartsDataView.DataSource = Inventory.AllParts;

            activePartList = Inventory.AllParts;
            activeProductList = Inventory.Products;
            

            
        }

        // load
        private void InventoryManagementSystem_Load(object sender, EventArgs e)
        {
            // clears the "auto selection" when the page loads on the dataGridViews
            ProductDataView.ClearSelection();
            PartsDataView.ClearSelection();
        }

        // ExitButton_Click
        //      exits the entire application when clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //////// Parts Section //////////////

        // DeletePartButton_Click
        //      deletes a selected part from the list of parts
        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            if (ActivePart != null)
            {
                if (MessageBox.Show("Are you sure?", "Delete Part", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                if (Inventory.deletePart(ActivePart))
                {
                    ActivePart = null;
                    PartsDataView.DataSource = Inventory.AllParts;
                    PartsDataView.ClearSelection();
                    activePartList = Inventory.AllParts;
                }
                else
                {
                    MessageBox.Show("Failed to delete part");
                }
                return;
            }
            MessageBox.Show("Please select a part to delete");
        }

        // PartsDataView_CellContentClick
        //      finds the part associated with the click and assigns to ActivePart
        private void PartsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            partsActiveIndex = e.RowIndex;
            if (partsActiveIndex != -1)
            {
                ActivePart = Inventory.lookupPart(activePartList[partsActiveIndex].PartID);
                partsActiveIndex = -1;
            }
        }

        // SearchPartsButton_Click
        //      finds a part given a string of what the name might contain
        private void SearchPartsButton_Click(object sender, EventArgs e)
        {
            activePartList = new BindingList<Part>();
            bool found = false;

            if (PartsTextBox.Text != "")
            {
                foreach (var part in Inventory.AllParts)
                {
                    if (part.Name.ToUpper().Contains(PartsTextBox.Text.ToUpper()))
                    {
                        activePartList.Add(part);
                        found = true;
                    }
                }

                if (found)
                {
                    PartsDataView.DataSource = activePartList;
                    PartsDataView.ClearSelection();
                }
            }

            if (!found)
            {
                MessageBox.Show("Nothing Found");
                PartsDataView.DataSource = Inventory.AllParts;
                activePartList = Inventory.AllParts;
                PartsDataView.ClearSelection();
            }
        }

        // ResetPartsButton_Click
        //      resets the selections and sets ActivePart to null
        private void ResetPartsButton_Click(object sender, EventArgs e)
        {
            activePartList = Inventory.AllParts;
            PartsDataView.DataSource = Inventory.AllParts;
            PartsDataView.ClearSelection();
            ActivePart = null;
            PartsTextBox.Text = "";
        }

        // AddPartButton_Click
        //      opens up the PartAdd screen to add a part
        private void AddPartButton_Click(object sender, EventArgs e)
        {
            PartAdd = new AddPart();
            PartAdd.Show();
            PartsDataView.ClearSelection();
            ActivePart = null;
        }

        // ModifyPartButton_Click
        //      opens up the ModifyPart screen with the selected part
        //      allows the user to make changes to the part
        private void ModifyPartButton_Click(object sender, EventArgs e)
        {
            ModifyPart = new ModifyPart(ActivePart);
            if (ActivePart == null)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }
            else
            {
                if (ActivePart is Outsourced)
                {
                    ModifyPart.Initialize((Outsourced)Inventory.lookupPart(ActivePart.PartID));
                }
                else
                {
                    ModifyPart.Initialize((Inhouse)Inventory.lookupPart(ActivePart.PartID));
                }
                PartsDataView.ClearSelection();
                
                ModifyPart.Show();
            }
            ActivePart = null;

        }

        /////// Products Section ////////////

        // SearchProductsButton_Click
        //      searches the list of Products by name given a string
        //      if product contains the string it is added to the list and shown in the ProductDataView
        private void SearchProductsButton_Click(object sender, EventArgs e)
        {
            activeProductList = new BindingList<Product>();
            bool found = false;

            if (ProductsTextBox.Text != "")
            {
                foreach (var product in Inventory.Products)
                {
                    if (product.Name.ToUpper().Contains(ProductsTextBox.Text.ToUpper()))
                    {
                        activeProductList.Add(product);
                        found = true;
                    }
                }

                if (found)
                {
                    ProductDataView.DataSource = activeProductList;
                    ProductDataView.ClearSelection();
                }
            }

            if (!found)
            {
                MessageBox.Show("Nothing Found");
                ProductDataView.DataSource = Inventory.Products;
                activeProductList = Inventory.Products;
                ProductDataView.ClearSelection();
            }
        }

        // ResetProductsButton_Click
        //      resets the selections and sets ActiveProduct to null
        private void ResetProductsButton_Click(object sender, EventArgs e)
        {
            activeProductList = Inventory.Products;
            ProductDataView.DataSource = Inventory.Products;
            ProductDataView.ClearSelection();
            ActiveProduct = null;
            ProductsTextBox.Text = "";
        }

        // DeleteProductButton_Click
        //      deletes the selected product
        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            if (ActiveProduct != null)
            {
                if(MessageBox.Show("Are you sure?", "Delete Product", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
                if (Inventory.removeProduct(ActiveProduct.ProductID))
                {
                    ActiveProduct = null;
                    ProductDataView.DataSource = Inventory.Products;
                    ProductDataView.ClearSelection();
                    activeProductList = Inventory.Products;
                }
                else
                {
                    if (Inventory.lookupProduct(ActiveProduct.ProductID).AssociatedParts.Count() > 0)
                    {
                        MessageBox.Show("Cannot delete product because there are still associated parts with it.  Please remove the associated parts to delete product.");
                    }
                    else 
                    {
                        MessageBox.Show("Failed to delete product");
                    }
                }
                return;
            }
            MessageBox.Show("Please select a product to delete");

        }

        // ProductDataView_CellContentClick
        //      assigns the selected Product to ActiveProduct
        private void ProductDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productsActiveIndex = e.RowIndex;
            if (productsActiveIndex != -1)
            {
                ActiveProduct = Inventory.lookupProduct(activeProductList[productsActiveIndex].ProductID);
                productsActiveIndex = -1;
            }
        }
        // AddProductButton_Click
        //      opens up the AddProduct screen to add a Product
        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProduct = new AddProduct();
            AddProduct.Show();
            ProductDataView.ClearSelection();
            ActiveProduct = null;
        }

        // ModifyProductButton_Click
        //      opens up the ModifyProduct screen to modify the selected Product
        private void ModifyProductButton_Click(object sender, EventArgs e)
        {
            if (ActiveProduct == null)
            {
                MessageBox.Show("Please select a part to modify.");
                return;
            }
            else
            {
                ModifyProduct = new ModifyProduct(ActiveProduct);

                ProductDataView.ClearSelection();

                ModifyProduct.Show();
            }
            ActiveProduct = null;
        }
    }
}
