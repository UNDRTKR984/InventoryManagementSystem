
namespace InventoryManagementSystem
{
    partial class ManagementSystem
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
            this.components = new System.ComponentModel.Container();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ProductDataView = new System.Windows.Forms.DataGridView();
            this.PartsDataView = new System.Windows.Forms.DataGridView();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.ModifyPartButton = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.ModifyProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchPartsButton = new System.Windows.Forms.Button();
            this.SearchProductsButton = new System.Windows.Forms.Button();
            this.PartsTextBox = new System.Windows.Forms.TextBox();
            this.ProductsTextBox = new System.Windows.Forms.TextBox();
            this.ResetPartsButton = new System.Windows.Forms.Button();
            this.ResetProductsButton = new System.Windows.Forms.Button();
            this.InventoryManagementSystemLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.inventoryBindingSource;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(InventoryManagementSystem.Inventory);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.inventoryBindingSource;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.inventoryBindingSource;
            // 
            // ProductDataView
            // 
            this.ProductDataView.AllowUserToAddRows = false;
            this.ProductDataView.AllowUserToDeleteRows = false;
            this.ProductDataView.AllowUserToResizeColumns = false;
            this.ProductDataView.AllowUserToResizeRows = false;
            this.ProductDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ProductDataView.Location = new System.Drawing.Point(744, 126);
            this.ProductDataView.MultiSelect = false;
            this.ProductDataView.Name = "ProductDataView";
            this.ProductDataView.RowHeadersVisible = false;
            this.ProductDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProductDataView.RowTemplate.Height = 24;
            this.ProductDataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataView.Size = new System.Drawing.Size(600, 311);
            this.ProductDataView.TabIndex = 1;
            this.ProductDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataView_CellContentClick);
            this.ProductDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataView_CellContentClick);
            this.ProductDataView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataView_CellContentClick);
            // 
            // PartsDataView
            // 
            this.PartsDataView.AllowUserToAddRows = false;
            this.PartsDataView.AllowUserToDeleteRows = false;
            this.PartsDataView.AllowUserToResizeColumns = false;
            this.PartsDataView.AllowUserToResizeRows = false;
            this.PartsDataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PartsDataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PartsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PartsDataView.Location = new System.Drawing.Point(12, 123);
            this.PartsDataView.MultiSelect = false;
            this.PartsDataView.Name = "PartsDataView";
            this.PartsDataView.RowHeadersVisible = false;
            this.PartsDataView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.PartsDataView.RowTemplate.Height = 24;
            this.PartsDataView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PartsDataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PartsDataView.Size = new System.Drawing.Size(600, 311);
            this.PartsDataView.TabIndex = 2;
            this.PartsDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataView_CellContentClick);
            this.PartsDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataView_CellContentClick);
            this.PartsDataView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PartsDataView_CellContentClick);
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(12, 91);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(68, 29);
            this.PartsLabel.TabIndex = 3;
            this.PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(739, 91);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(108, 29);
            this.ProductsLabel.TabIndex = 4;
            this.ProductsLabel.Text = "Products";
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Location = new System.Drawing.Point(515, 453);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(96, 49);
            this.DeletePartButton.TabIndex = 5;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // ModifyPartButton
            // 
            this.ModifyPartButton.Location = new System.Drawing.Point(413, 453);
            this.ModifyPartButton.Name = "ModifyPartButton";
            this.ModifyPartButton.Size = new System.Drawing.Size(96, 49);
            this.ModifyPartButton.TabIndex = 6;
            this.ModifyPartButton.Text = "Modify";
            this.ModifyPartButton.UseVisualStyleBackColor = true;
            this.ModifyPartButton.Click += new System.EventHandler(this.ModifyPartButton_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Location = new System.Drawing.Point(311, 453);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(96, 49);
            this.AddPartButton.TabIndex = 7;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(1044, 453);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(96, 49);
            this.AddProductButton.TabIndex = 8;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ModifyProductButton
            // 
            this.ModifyProductButton.Location = new System.Drawing.Point(1146, 453);
            this.ModifyProductButton.Name = "ModifyProductButton";
            this.ModifyProductButton.Size = new System.Drawing.Size(96, 49);
            this.ModifyProductButton.TabIndex = 9;
            this.ModifyProductButton.Text = "Modify";
            this.ModifyProductButton.UseVisualStyleBackColor = true;
            this.ModifyProductButton.Click += new System.EventHandler(this.ModifyProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(1248, 453);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(96, 49);
            this.DeleteProductButton.TabIndex = 10;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(1248, 550);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(96, 49);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SearchPartsButton
            // 
            this.SearchPartsButton.Location = new System.Drawing.Point(414, 91);
            this.SearchPartsButton.Name = "SearchPartsButton";
            this.SearchPartsButton.Size = new System.Drawing.Size(96, 26);
            this.SearchPartsButton.TabIndex = 13;
            this.SearchPartsButton.Text = "Search";
            this.SearchPartsButton.UseVisualStyleBackColor = true;
            this.SearchPartsButton.Click += new System.EventHandler(this.SearchPartsButton_Click);
            // 
            // SearchProductsButton
            // 
            this.SearchProductsButton.Location = new System.Drawing.Point(1146, 94);
            this.SearchProductsButton.Name = "SearchProductsButton";
            this.SearchProductsButton.Size = new System.Drawing.Size(96, 26);
            this.SearchProductsButton.TabIndex = 14;
            this.SearchProductsButton.Text = "Search";
            this.SearchProductsButton.UseVisualStyleBackColor = true;
            this.SearchProductsButton.Click += new System.EventHandler(this.SearchProductsButton_Click);
            // 
            // PartsTextBox
            // 
            this.PartsTextBox.Location = new System.Drawing.Point(127, 91);
            this.PartsTextBox.MinimumSize = new System.Drawing.Size(4, 26);
            this.PartsTextBox.Name = "PartsTextBox";
            this.PartsTextBox.Size = new System.Drawing.Size(280, 22);
            this.PartsTextBox.TabIndex = 15;
            // 
            // ProductsTextBox
            // 
            this.ProductsTextBox.Location = new System.Drawing.Point(860, 94);
            this.ProductsTextBox.MinimumSize = new System.Drawing.Size(4, 26);
            this.ProductsTextBox.Name = "ProductsTextBox";
            this.ProductsTextBox.Size = new System.Drawing.Size(280, 22);
            this.ProductsTextBox.TabIndex = 16;
            // 
            // ResetPartsButton
            // 
            this.ResetPartsButton.Location = new System.Drawing.Point(516, 91);
            this.ResetPartsButton.Name = "ResetPartsButton";
            this.ResetPartsButton.Size = new System.Drawing.Size(96, 26);
            this.ResetPartsButton.TabIndex = 17;
            this.ResetPartsButton.Text = "Reset";
            this.ResetPartsButton.UseVisualStyleBackColor = true;
            this.ResetPartsButton.Click += new System.EventHandler(this.ResetPartsButton_Click);
            // 
            // ResetProductsButton
            // 
            this.ResetProductsButton.Location = new System.Drawing.Point(1248, 94);
            this.ResetProductsButton.Name = "ResetProductsButton";
            this.ResetProductsButton.Size = new System.Drawing.Size(96, 26);
            this.ResetProductsButton.TabIndex = 18;
            this.ResetProductsButton.Text = "Reset";
            this.ResetProductsButton.UseVisualStyleBackColor = true;
            this.ResetProductsButton.Click += new System.EventHandler(this.ResetProductsButton_Click);
            // 
            // InventoryManagementSystemLabel
            // 
            this.InventoryManagementSystemLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InventoryManagementSystemLabel.AutoSize = true;
            this.InventoryManagementSystemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryManagementSystemLabel.Location = new System.Drawing.Point(455, 9);
            this.InventoryManagementSystemLabel.Name = "InventoryManagementSystemLabel";
            this.InventoryManagementSystemLabel.Size = new System.Drawing.Size(422, 36);
            this.InventoryManagementSystemLabel.TabIndex = 19;
            this.InventoryManagementSystemLabel.Text = "Inventory Management System";
            // 
            // ManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 611);
            this.Controls.Add(this.InventoryManagementSystemLabel);
            this.Controls.Add(this.ResetProductsButton);
            this.Controls.Add(this.ResetPartsButton);
            this.Controls.Add(this.ProductsTextBox);
            this.Controls.Add(this.PartsTextBox);
            this.Controls.Add(this.SearchProductsButton);
            this.Controls.Add(this.SearchPartsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ModifyProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.ModifyPartButton);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.PartsDataView);
            this.Controls.Add(this.ProductDataView);
            this.MinimumSize = new System.Drawing.Size(18, 50);
            this.Name = "ManagementSystem";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.InventoryManagementSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.DataGridView ProductDataView;
        private System.Windows.Forms.DataGridView PartsDataView;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button ModifyPartButton;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button ModifyProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SearchPartsButton;
        private System.Windows.Forms.Button SearchProductsButton;
        private System.Windows.Forms.TextBox PartsTextBox;
        private System.Windows.Forms.TextBox ProductsTextBox;
        private System.Windows.Forms.Button ResetPartsButton;
        private System.Windows.Forms.Button ResetProductsButton;
        private System.Windows.Forms.Label InventoryManagementSystemLabel;
    }
}

