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
    public partial class ModifyProduct : Form
    {
        // private variables
        private BindingList<Part> tempAssociatedParts;
        private Part activePart;
        private Part activeAssociatedPart;
        private Product activeProduct;
        private int activeIndex;

        private BindingList<Part> activePartList;

        // constructor -- takes in a selected product
        public ModifyProduct(Product product)
        {
            InitializeComponent();

            activeProduct = product;
            tempAssociatedParts = new BindingList<Part>();

            // fill in text boxes with Product info
            idTextBox.Text = product.ProductID.ToString();
            nameTextBox.Text = product.Name;
            inventoryTextBox.Text = product.InStock.ToString();
            priceTextBox.Text = product.Price.ToString();
            maxTextBox.Text = product.Max.ToString();
            minTextBox.Text = product.Min.ToString();
            foreach (var part in product.AssociatedParts)
            {
                tempAssociatedParts.Add(part);
            }

            ProductPartsDataView.DataSource = ManagementSystem.Inventory.AllParts;
            AssociatedPartsDataView.DataSource = tempAssociatedParts;
            activePartList = ManagementSystem.Inventory.AllParts;
            activePart = null;
        }

        // load -- clears the selections for both DataViews
        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            ProductPartsDataView.ClearSelection();
            AssociatedPartsDataView.ClearSelection();
        }

        ///// Form Functionality ////

        // ProductPartsDataView_CellContentClick
        //      sets activePart to be aassigned with the cell row and the corresponding Part that was clicked
        private void ProductPartsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            activeIndex = e.RowIndex;
            if (activeIndex != -1 && activeIndex < activePartList.Count)
            {
                activePart = ManagementSystem.Inventory.lookupPart(activePartList[activeIndex].PartID);
                activeIndex = -1;
            }
        }

        // AssociatedPartsDataView_CellContentClick
        //      sets activeAssociatedPart to be assigned with the cell row and corresponding Part that was clicked
        private void AssociatedPartsDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex < tempAssociatedParts.Count)
            {
                activeAssociatedPart = tempAssociatedParts[e.RowIndex];
            }
            
        }

        // CancelButton_Click
        //      Closes the form -- to access a ModifyProduct screen again, the form has to be recreated
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // SearchPartsButton_Click
        //      takes a string from the PartsTextBox and searches the parts inventory to see if any part contains the string.
        //      Displays the resuls in the ProductPartsDataView
        private void SearchPartsButton_Click(object sender, EventArgs e)
        {
            activePartList = new BindingList<Part>();
            bool found = false;

            if (PartsTextBox.Text != "")
            {
                foreach (var part in ManagementSystem.Inventory.AllParts)
                {
                    if (part.Name.ToUpper().Contains(PartsTextBox.Text.ToUpper()))
                    {
                        activePartList.Add(part);
                        found = true;
                    }
                }

                if (found)
                {
                    ProductPartsDataView.DataSource = activePartList;
                    ProductPartsDataView.ClearSelection();
                }
            }

            if (!found)
            {
                MessageBox.Show("Nothing Found");
                ProductPartsDataView.DataSource = ManagementSystem.Inventory.AllParts;
                activePartList = ManagementSystem.Inventory.AllParts;
                ProductPartsDataView.ClearSelection();
            }
        }

        // ResetPartsButton_Click
        //      clears all selections and sets activePart to null
        private void ResetPartsButton_Click(object sender, EventArgs e)
        {
            activePartList = ManagementSystem.Inventory.AllParts;
            ProductPartsDataView.DataSource = ManagementSystem.Inventory.AllParts;
            ProductPartsDataView.ClearSelection();
            activePart = null;
            PartsTextBox.Text = "";
        }
        


        // Reset
        //      resets the form to blank TextBox entries with a white background (optional method)
        private void Reset()
        {
            nameTextBox.BackColor = System.Drawing.Color.White;
            nameTextBox.Text = "";
            inventoryTextBox.BackColor = System.Drawing.Color.White;
            inventoryTextBox.Text = "";
            priceTextBox.BackColor = System.Drawing.Color.White;
            priceTextBox.Text = "";
            maxTextBox.BackColor = System.Drawing.Color.White;
            maxTextBox.Text = "";
            minTextBox.BackColor = System.Drawing.Color.White;
            minTextBox.Text = "";
            ProductPartsDataView.ClearSelection();
            AssociatedPartsDataView.ClearSelection();
        }

        // AddButton_Click
        //      adds the selected Part to this Product's associated Parts list
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (activePart != null)
            {
                if (tempAssociatedParts.Count == 0 || !tempAssociatedParts.Contains(activePart))
                {
                    tempAssociatedParts.Add(activePart);
                }
                else
                {
                    MessageBox.Show("Part is already associated with this product.");
                }
            }
            else
            {
                MessageBox.Show("Please select a part to add from the 'All Candidate Parts' section.");
            }

            activePart = null;
            ProductPartsDataView.ClearSelection();
            AssociatedPartsDataView.ClearSelection();
        }

        // DeleteButton_Click
        //      removes the selected associatedPart from the associatedParts list for this Product
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (activeAssociatedPart != null)
            {
                tempAssociatedParts.Remove(activeAssociatedPart);
                activeAssociatedPart = null;
                AssociatedPartsDataView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select an associated part to delete from this product.");
            }
        }



        // IncompleteEntry
        //      checks to see if all fields are field out -- if they aren't it returns true
        private bool IncompleteEntry()
        {
            bool incomplete = false;
            if (nameTextBox.Text.Length == 0)
            {
                nameTextBox.BackColor = System.Drawing.Color.LightSalmon;
                incomplete = true;
            }
            else
            {
                nameTextBox.BackColor = System.Drawing.Color.White;
            }
            if (inventoryTextBox.Text.Length == 0)
            {
                inventoryTextBox.BackColor = System.Drawing.Color.LightSalmon;
                incomplete = true;
            }
            else
            {
                inventoryTextBox.BackColor = System.Drawing.Color.White;
            }
            if (priceTextBox.Text.Length == 0)
            {
                priceTextBox.BackColor = System.Drawing.Color.LightSalmon;
                incomplete = true;
            }
            else
            {
                priceTextBox.BackColor = System.Drawing.Color.White;
            }
            if (maxTextBox.Text.Length == 0)
            {
                maxTextBox.BackColor = System.Drawing.Color.LightSalmon;
                incomplete = true;
            }
            else
            {
                maxTextBox.BackColor = System.Drawing.Color.White;
            }
            if (minTextBox.Text.Length == 0)
            {
                minTextBox.BackColor = System.Drawing.Color.LightSalmon;
                incomplete = true;
            }
            else
            {
                minTextBox.BackColor = System.Drawing.Color.White;
            }

            return incomplete;
        }

        // SaveButton_Click
        //      updates the Product in the Inventory with the updated information
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // part attributes
            string tempName;
            int tempInventory = -1;
            decimal tempPrice = -1;
            int tempMax = -1;
            int tempMin = -1;


            // exception handling and validation
            string errorBoxText = "Please correct the following:\n\n";
            bool errorFound = false;

            // checks if all fields are filled out
            if (IncompleteEntry())
            {
                MessageBox.Show("You have incomplete entries.  Please complete and resubmit.");
                return;
            }


            // checks if the Inventory field is an integer
            try
            {
                tempInventory = int.Parse(inventoryTextBox.Text);
                if (tempInventory < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                errorFound = true;
                errorBoxText += "Your inventory needs to be a whole non-negative number.\n";
                inventoryTextBox.BackColor = System.Drawing.Color.LightSalmon;
            }


            // checks if the price can be converted to decimal
            try
            {
                tempPrice = decimal.Parse(priceTextBox.Text);
                if (tempPrice < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                errorFound = true;
                errorBoxText += "Your price or cost needs to be a non-negative number.\n";
                priceTextBox.BackColor = System.Drawing.Color.LightSalmon;
            }

            // checks if Min can be converted to int
            try
            {
                tempMin = int.Parse(minTextBox.Text);
                if (tempMin < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                errorFound = true;
                errorBoxText += "Min needs to be a whole non-negative number.\n";
                minTextBox.BackColor = System.Drawing.Color.LightSalmon;
            }

            // checks if Max can be converted to int and if Max is equal to or greater than Min
            try
            {
                tempMax = int.Parse(maxTextBox.Text);
                if (tempMax < 0)
                {
                    errorBoxText += "Max needs to be a whole non-negative number.";
                    throw new ArgumentOutOfRangeException();
                }
                if (tempMax < tempMin && tempMin != 0)
                {
                    errorBoxText += "Max needs to be greater than or equal to Min";
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                errorFound = true;
                maxTextBox.BackColor = System.Drawing.Color.LightSalmon;
            }

            // checks to make sure Inventory is between Min and Max
            if (tempInventory > tempMax || tempInventory < tempMin)
            {
                errorBoxText += "Inventory needs to be equal to or between Min and Max";
                errorFound = true;
                inventoryTextBox.BackColor = System.Drawing.Color.LightSalmon;
            }

            // if an error was found, show the message box and do not add the part
            if (errorFound)
            {
                MessageBox.Show(errorBoxText);
                return;
            }

            // assign the name to tempName
            tempName = nameTextBox.Text;

            // update the newly modified product
            Product tempProduct = new Product(int.Parse(idTextBox.Text), tempName, tempPrice, tempInventory, tempMin, tempMax, tempAssociatedParts);
            ManagementSystem.Inventory.updateProduct(int.Parse(idTextBox.Text),tempProduct);


            this.Hide();
            ManagementSystem.ActiveProduct = null;
        }

        
    }
}
