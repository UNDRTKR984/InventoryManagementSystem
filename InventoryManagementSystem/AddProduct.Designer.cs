
namespace InventoryManagementSystem
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.minLabel = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.ProductPartsDataView = new System.Windows.Forms.DataGridView();
            this.AllCandidatePartsLabel = new System.Windows.Forms.Label();
            this.PartsAssociatedLabel = new System.Windows.Forms.Label();
            this.AssociatedPartsDataView = new System.Windows.Forms.DataGridView();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ResetPartsButton = new System.Windows.Forms.Button();
            this.PartsTextBox = new System.Windows.Forms.TextBox();
            this.SearchPartsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPartsDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(229, 345);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(122, 22);
            this.minTextBox.TabIndex = 50;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(59, 345);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(122, 22);
            this.maxTextBox.TabIndex = 49;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.priceTextBox.Location = new System.Drawing.Point(126, 293);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(187, 22);
            this.priceTextBox.TabIndex = 48;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.inventoryTextBox.Location = new System.Drawing.Point(126, 246);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(187, 22);
            this.inventoryTextBox.TabIndex = 47;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.Location = new System.Drawing.Point(126, 198);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(187, 22);
            this.nameTextBox.TabIndex = 46;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(126, 158);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(187, 22);
            this.idTextBox.TabIndex = 45;
            this.idTextBox.TabStop = false;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.Location = new System.Drawing.Point(187, 347);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(36, 20);
            this.minLabel.TabIndex = 44;
            this.minLabel.Text = "Min";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.Location = new System.Drawing.Point(13, 345);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(40, 20);
            this.maxLabel.TabIndex = 43;
            this.maxLabel.Text = "Max";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(13, 293);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(98, 20);
            this.priceLabel.TabIndex = 42;
            this.priceLabel.Text = "Price / Cost";
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryLabel.Location = new System.Drawing.Point(12, 248);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(76, 20);
            this.inventoryLabel.TabIndex = 41;
            this.inventoryLabel.Text = "Inventory";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(13, 198);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(53, 20);
            this.nameLabel.TabIndex = 40;
            this.nameLabel.Text = "Name";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(13, 158);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(26, 20);
            this.idLabel.TabIndex = 39;
            this.idLabel.Text = "ID";
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLabel.Location = new System.Drawing.Point(12, 9);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(145, 29);
            this.AddProductLabel.TabIndex = 36;
            this.AddProductLabel.Text = "Add Product";
            // 
            // ProductPartsDataView
            // 
            this.ProductPartsDataView.AllowUserToAddRows = false;
            this.ProductPartsDataView.AllowUserToDeleteRows = false;
            this.ProductPartsDataView.AllowUserToResizeColumns = false;
            this.ProductPartsDataView.AllowUserToResizeRows = false;
            this.ProductPartsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductPartsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductPartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductPartsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductPartsDataView.Location = new System.Drawing.Point(531, 44);
            this.ProductPartsDataView.MultiSelect = false;
            this.ProductPartsDataView.Name = "ProductPartsDataView";
            this.ProductPartsDataView.RowHeadersVisible = false;
            this.ProductPartsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProductPartsDataView.RowTemplate.Height = 24;
            this.ProductPartsDataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductPartsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductPartsDataView.Size = new System.Drawing.Size(645, 197);
            this.ProductPartsDataView.TabIndex = 51;
            this.ProductPartsDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductPartsDataView_CellContentClick);
            this.ProductPartsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductPartsDataView_CellContentClick);
            this.ProductPartsDataView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductPartsDataView_CellContentClick);
            // 
            // AllCandidatePartsLabel
            // 
            this.AllCandidatePartsLabel.AutoSize = true;
            this.AllCandidatePartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCandidatePartsLabel.Location = new System.Drawing.Point(527, 21);
            this.AllCandidatePartsLabel.Name = "AllCandidatePartsLabel";
            this.AllCandidatePartsLabel.Size = new System.Drawing.Size(153, 20);
            this.AllCandidatePartsLabel.TabIndex = 52;
            this.AllCandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // PartsAssociatedLabel
            // 
            this.PartsAssociatedLabel.AutoSize = true;
            this.PartsAssociatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsAssociatedLabel.Location = new System.Drawing.Point(527, 279);
            this.PartsAssociatedLabel.Name = "PartsAssociatedLabel";
            this.PartsAssociatedLabel.Size = new System.Drawing.Size(267, 20);
            this.PartsAssociatedLabel.TabIndex = 54;
            this.PartsAssociatedLabel.Text = "Parts Associated with this Product";
            // 
            // AssociatedPartsDataView
            // 
            this.AssociatedPartsDataView.AllowUserToAddRows = false;
            this.AssociatedPartsDataView.AllowUserToDeleteRows = false;
            this.AssociatedPartsDataView.AllowUserToResizeColumns = false;
            this.AssociatedPartsDataView.AllowUserToResizeRows = false;
            this.AssociatedPartsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AssociatedPartsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AssociatedPartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssociatedPartsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AssociatedPartsDataView.Location = new System.Drawing.Point(531, 302);
            this.AssociatedPartsDataView.MultiSelect = false;
            this.AssociatedPartsDataView.Name = "AssociatedPartsDataView";
            this.AssociatedPartsDataView.RowHeadersVisible = false;
            this.AssociatedPartsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AssociatedPartsDataView.RowTemplate.Height = 24;
            this.AssociatedPartsDataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AssociatedPartsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsDataView.Size = new System.Drawing.Size(645, 197);
            this.AssociatedPartsDataView.TabIndex = 53;
            this.AssociatedPartsDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataView_CellContentClick);
            this.AssociatedPartsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataView_CellContentClick);
            this.AssociatedPartsDataView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssociatedPartsDataView_CellContentClick);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(1096, 559);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 44);
            this.CancelButton.TabIndex = 55;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(998, 559);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(80, 44);
            this.SaveButton.TabIndex = 56;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(1096, 505);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(80, 44);
            this.DeleteButton.TabIndex = 57;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(1096, 247);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(80, 44);
            this.AddButton.TabIndex = 58;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ResetPartsButton
            // 
            this.ResetPartsButton.Location = new System.Drawing.Point(1080, 16);
            this.ResetPartsButton.Name = "ResetPartsButton";
            this.ResetPartsButton.Size = new System.Drawing.Size(96, 26);
            this.ResetPartsButton.TabIndex = 61;
            this.ResetPartsButton.Text = "Reset";
            this.ResetPartsButton.UseVisualStyleBackColor = true;
            this.ResetPartsButton.Click += new System.EventHandler(this.ResetPartsButton_Click);
            // 
            // PartsTextBox
            // 
            this.PartsTextBox.Location = new System.Drawing.Point(719, 15);
            this.PartsTextBox.MinimumSize = new System.Drawing.Size(4, 26);
            this.PartsTextBox.Name = "PartsTextBox";
            this.PartsTextBox.Size = new System.Drawing.Size(253, 22);
            this.PartsTextBox.TabIndex = 60;
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Location = new System.Drawing.Point(978, 16);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(96, 26);
            this.SearchPartsButton.TabIndex = 59;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 615);
            this.Controls.Add(this.ResetPartsButton);
            this.Controls.Add(this.PartsTextBox);
            this.Controls.Add(this.SearchPartsButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PartsAssociatedLabel);
            this.Controls.Add(this.AssociatedPartsDataView);
            this.Controls.Add(this.AllCandidatePartsLabel);
            this.Controls.Add(this.ProductPartsDataView);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.AddProductLabel);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.ProductPartsDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label inventoryLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.DataGridView ProductPartsDataView;
        private System.Windows.Forms.Label AllCandidatePartsLabel;
        private System.Windows.Forms.Label PartsAssociatedLabel;
        private System.Windows.Forms.DataGridView AssociatedPartsDataView;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ResetPartsButton;
        private System.Windows.Forms.TextBox PartsTextBox;
        private System.Windows.Forms.Button SearchPartsButton;
    }
}