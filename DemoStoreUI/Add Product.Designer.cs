namespace DemoStoreUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.AddProductNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductSaveButton = new System.Windows.Forms.Button();
            this.addProductEditButton = new System.Windows.Forms.Button();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.deleteProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(21, 27);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(123, 20);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Product Name/Id";
            // 
            // AddProductNameTextBox
            // 
            this.AddProductNameTextBox.Location = new System.Drawing.Point(150, 24);
            this.AddProductNameTextBox.Name = "AddProductNameTextBox";
            this.AddProductNameTextBox.Size = new System.Drawing.Size(229, 27);
            this.AddProductNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product Price";
            // 
            // addProductSaveButton
            // 
            this.addProductSaveButton.BackColor = System.Drawing.Color.Green;
            this.addProductSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductSaveButton.ForeColor = System.Drawing.Color.White;
            this.addProductSaveButton.Location = new System.Drawing.Point(169, 113);
            this.addProductSaveButton.Name = "addProductSaveButton";
            this.addProductSaveButton.Size = new System.Drawing.Size(66, 29);
            this.addProductSaveButton.TabIndex = 4;
            this.addProductSaveButton.Text = "Save";
            this.addProductSaveButton.UseVisualStyleBackColor = false;
            this.addProductSaveButton.Click += new System.EventHandler(this.addProductSaveButton_Click);
            // 
            // addProductEditButton
            // 
            this.addProductEditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addProductEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addProductEditButton.ForeColor = System.Drawing.Color.White;
            this.addProductEditButton.Location = new System.Drawing.Point(241, 113);
            this.addProductEditButton.Name = "addProductEditButton";
            this.addProductEditButton.Size = new System.Drawing.Size(138, 29);
            this.addProductEditButton.TabIndex = 5;
            this.addProductEditButton.Text = "Edit Product";
            this.addProductEditButton.UseVisualStyleBackColor = false;
            this.addProductEditButton.Click += new System.EventHandler(this.addProductEditButton_Click);
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(150, 67);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(229, 27);
            this.ProductPriceTextBox.TabIndex = 6;
            // 
            // deleteProductButton
            // 
            this.deleteProductButton.BackColor = System.Drawing.Color.Red;
            this.deleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteProductButton.ForeColor = System.Drawing.Color.White;
            this.deleteProductButton.Location = new System.Drawing.Point(21, 113);
            this.deleteProductButton.Name = "deleteProductButton";
            this.deleteProductButton.Size = new System.Drawing.Size(142, 29);
            this.deleteProductButton.TabIndex = 7;
            this.deleteProductButton.Text = "Delete Product";
            this.deleteProductButton.UseVisualStyleBackColor = false;
            this.deleteProductButton.Click += new System.EventHandler(this.deleteProductButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "INSTRUCTIONS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "3. To \"Delete\" a product, enter Product Id ONLY .";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "2. To \"Edit\" a product price, enter Product Name and Price.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(21, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "1. To \"Save\" a new product, enter Product Name and Price.";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(403, 245);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteProductButton);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.addProductEditButton);
            this.Controls.Add(this.addProductSaveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.TextBox AddProductNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addProductSaveButton;
        private System.Windows.Forms.Button addProductEditButton;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Button deleteProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}