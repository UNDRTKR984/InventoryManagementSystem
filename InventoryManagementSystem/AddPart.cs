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
    public partial class AddPart : Form
    {
        // constructor
        public AddPart()
        {
            InitializeComponent();
        }

        // CancelButton_Click
        //      hides this form and resets the TextBoxes
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reset();
            ManagementSystem.ActivePart = null;
        }

        // Reset
        //      resets the form to blank TextBox entries with a white background
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
            machineCompanyNameIDTextBox.BackColor = System.Drawing.Color.White;
            machineCompanyNameIDTextBox.Text = "";
        }

        // InHouseRadio_CheckChanged
        //      if the InHouse radio button is selected set label to Machine ID
        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyNameLabel.Text = "      Machine ID";
        }

        // OutsourcedRadio_CheckChanged
        //      if the Outsourced radio button is select, set label to Company Name
        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            machineCompanyNameLabel.Text = "Company Name";
        }

        // saveButton_Click
        //      validates the entry for a part and if it's correct, will add a part to the inventory
        private void saveButton_Click(object sender, EventArgs e)
        {
            // part attributes
            string tempName;
            int tempInventory = -1;
            decimal tempPrice = -1;
            int tempMax = -1;
            int tempMin = -1;
            string tempCompanyNameID;
            int tempMachineID = 0;

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
            try {
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
            

            // if the outsourced radio box is checked create an Outsourced Part if not, create an Inhouse Part
            if (OutsourcedRadio.Checked)
            {
                tempCompanyNameID = machineCompanyNameIDTextBox.Text;
                Outsourced tempPart = new Outsourced(tempCompanyNameID, ManagementSystem.PartID++, tempName, tempPrice, tempInventory, tempMin, tempMax);
                ManagementSystem.Inventory.addPart(tempPart);
                Reset();
            }
            else
            {
                // check to make sure the Machine ID is an int, if not do not add InHouse part
                try
                {
                    tempMachineID = int.Parse(machineCompanyNameIDTextBox.Text);
                }
                catch
                {
                    errorBoxText += "Please enter a whole number for Machine ID";
                    MessageBox.Show(errorBoxText);
                    machineCompanyNameIDTextBox.BackColor = System.Drawing.Color.LightSalmon;
                    return;
                }
                Inhouse tempPart = new Inhouse(tempMachineID, ManagementSystem.PartID++, tempName, tempPrice, tempInventory, tempMin, tempMax);
                ManagementSystem.Inventory.addPart(tempPart);
                Reset();
            }
            this.Hide();
            ManagementSystem.ActivePart = null;
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
            if (machineCompanyNameIDTextBox.Text.Length == 0)
            {
                machineCompanyNameIDTextBox.BackColor = System.Drawing.Color.LightSalmon;
                incomplete = true;
            }
            else
            {
                machineCompanyNameIDTextBox.BackColor = System.Drawing.Color.White;
            }

            return incomplete;
        }
    }
}
