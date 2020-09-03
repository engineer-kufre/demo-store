namespace DemoStoreUI
{
    partial class MakeOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrder));
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.undoFilterButton = new System.Windows.Forms.Button();
            this.priceFilterTrackBar = new System.Windows.Forms.TrackBar();
            this.priceFilterTextBox = new System.Windows.Forms.TextBox();
            this.PriceFilterButton = new System.Windows.Forms.Button();
            this.addtoCartButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.cartDeleteButton = new System.Windows.Forms.Button();
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pNameFilterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFilterTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(109, 50);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.Size = new System.Drawing.Size(428, 207);
            this.productGridView.TabIndex = 0;
            this.productGridView.Text = "dataGridView1";
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // undoFilterButton
            // 
            this.undoFilterButton.BackColor = System.Drawing.Color.Red;
            this.undoFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.undoFilterButton.ForeColor = System.Drawing.Color.White;
            this.undoFilterButton.Location = new System.Drawing.Point(221, 283);
            this.undoFilterButton.Name = "undoFilterButton";
            this.undoFilterButton.Size = new System.Drawing.Size(120, 29);
            this.undoFilterButton.TabIndex = 2;
            this.undoFilterButton.Text = "Undo Filter";
            this.undoFilterButton.UseVisualStyleBackColor = false;
            this.undoFilterButton.Click += new System.EventHandler(this.undoFilterButton_Click);
            // 
            // priceFilterTrackBar
            // 
            this.priceFilterTrackBar.LargeChange = 500;
            this.priceFilterTrackBar.Location = new System.Drawing.Point(12, 352);
            this.priceFilterTrackBar.Maximum = 10000;
            this.priceFilterTrackBar.Name = "priceFilterTrackBar";
            this.priceFilterTrackBar.Size = new System.Drawing.Size(627, 56);
            this.priceFilterTrackBar.SmallChange = 100;
            this.priceFilterTrackBar.TabIndex = 0;
            this.priceFilterTrackBar.Scroll += new System.EventHandler(this.priceFilterTrackBar_Scroll);
            // 
            // priceFilterTextBox
            // 
            this.priceFilterTextBox.Location = new System.Drawing.Point(446, 285);
            this.priceFilterTextBox.Name = "priceFilterTextBox";
            this.priceFilterTextBox.Size = new System.Drawing.Size(190, 27);
            this.priceFilterTextBox.TabIndex = 3;
            // 
            // PriceFilterButton
            // 
            this.PriceFilterButton.BackColor = System.Drawing.Color.Green;
            this.PriceFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PriceFilterButton.ForeColor = System.Drawing.Color.White;
            this.PriceFilterButton.Location = new System.Drawing.Point(344, 283);
            this.PriceFilterButton.Name = "PriceFilterButton";
            this.PriceFilterButton.Size = new System.Drawing.Size(96, 29);
            this.PriceFilterButton.TabIndex = 4;
            this.PriceFilterButton.Text = "Filter";
            this.PriceFilterButton.UseVisualStyleBackColor = false;
            this.PriceFilterButton.Click += new System.EventHandler(this.PriceFilterButton_Click);
            // 
            // addtoCartButton
            // 
            this.addtoCartButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.addtoCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addtoCartButton.ForeColor = System.Drawing.Color.White;
            this.addtoCartButton.Location = new System.Drawing.Point(362, 501);
            this.addtoCartButton.Name = "addtoCartButton";
            this.addtoCartButton.Size = new System.Drawing.Size(274, 29);
            this.addtoCartButton.TabIndex = 6;
            this.addtoCartButton.Text = "Add To Cart";
            this.addtoCartButton.UseVisualStyleBackColor = false;
            this.addtoCartButton.Click += new System.EventHandler(this.addtoCartButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.BackColor = System.Drawing.Color.DarkRed;
            this.clearCartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearCartButton.ForeColor = System.Drawing.Color.White;
            this.clearCartButton.Location = new System.Drawing.Point(362, 639);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(274, 29);
            this.clearCartButton.TabIndex = 7;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = false;
            this.clearCartButton.Click += new System.EventHandler(this.clearCartButton_Click);
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(435, 684);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(124, 27);
            this.totalPriceTextBox.TabIndex = 8;
            this.totalPriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // orderListBox
            // 
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 20;
            this.orderListBox.Location = new System.Drawing.Point(12, 486);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(343, 264);
            this.orderListBox.TabIndex = 9;
            // 
            // cartDeleteButton
            // 
            this.cartDeleteButton.BackColor = System.Drawing.Color.Red;
            this.cartDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cartDeleteButton.ForeColor = System.Drawing.Color.White;
            this.cartDeleteButton.Location = new System.Drawing.Point(362, 548);
            this.cartDeleteButton.Name = "cartDeleteButton";
            this.cartDeleteButton.Size = new System.Drawing.Size(274, 29);
            this.cartDeleteButton.TabIndex = 10;
            this.cartDeleteButton.Text = "Delete From Cart";
            this.cartDeleteButton.UseVisualStyleBackColor = false;
            this.cartDeleteButton.Click += new System.EventHandler(this.cartDeleteButton_Click);
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.BackColor = System.Drawing.Color.Green;
            this.finishOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.finishOrderButton.ForeColor = System.Drawing.Color.White;
            this.finishOrderButton.Location = new System.Drawing.Point(362, 594);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(274, 29);
            this.finishOrderButton.TabIndex = 11;
            this.finishOrderButton.Text = "Finish Order";
            this.finishOrderButton.UseVisualStyleBackColor = false;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(455, 714);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(221, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter By Product Price Range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Filter By Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(459, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filter By Product Price";
            // 
            // previousButton
            // 
            this.previousButton.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.previousButton.Location = new System.Drawing.Point(9, 128);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(94, 51);
            this.previousButton.TabIndex = 15;
            this.previousButton.Text = "<";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(543, 128);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(94, 51);
            this.nextButton.TabIndex = 15;
            this.nextButton.Text = ">";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(230, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Product List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(97, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 38);
            this.label6.TabIndex = 16;
            this.label6.Text = "Order List";
            // 
            // pNameFilterTextBox
            // 
            this.pNameFilterTextBox.Location = new System.Drawing.Point(12, 283);
            this.pNameFilterTextBox.Name = "pNameFilterTextBox";
            this.pNameFilterTextBox.Size = new System.Drawing.Size(203, 27);
            this.pNameFilterTextBox.TabIndex = 17;
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(646, 777);
            this.Controls.Add(this.pNameFilterTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finishOrderButton);
            this.Controls.Add(this.cartDeleteButton);
            this.Controls.Add(this.orderListBox);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.addtoCartButton);
            this.Controls.Add(this.PriceFilterButton);
            this.Controls.Add(this.priceFilterTextBox);
            this.Controls.Add(this.priceFilterTrackBar);
            this.Controls.Add(this.undoFilterButton);
            this.Controls.Add(this.productGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MakeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Make Order";
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceFilterTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button undoFilterButton;
        private System.Windows.Forms.TrackBar priceFilterTrackBar;
        private System.Windows.Forms.TextBox priceFilterTextBox;
        private System.Windows.Forms.Button PriceFilterButton;
        private System.Windows.Forms.Button addtoCartButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button cartDeleteButton;
        private System.Windows.Forms.Button finishOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pNameFilterTextBox;
    }
}