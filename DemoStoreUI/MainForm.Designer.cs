namespace DemoStoreUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainFormAddProductButton = new System.Windows.Forms.Button();
            this.makeOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainFormAddProductButton
            // 
            this.mainFormAddProductButton.Location = new System.Drawing.Point(12, 23);
            this.mainFormAddProductButton.Name = "mainFormAddProductButton";
            this.mainFormAddProductButton.Size = new System.Drawing.Size(291, 29);
            this.mainFormAddProductButton.TabIndex = 0;
            this.mainFormAddProductButton.Text = "Product Management Centre";
            this.mainFormAddProductButton.UseVisualStyleBackColor = true;
            this.mainFormAddProductButton.Click += new System.EventHandler(this.mainFormAddProductButton_Click);
            // 
            // makeOrderButton
            // 
            this.makeOrderButton.Location = new System.Drawing.Point(12, 74);
            this.makeOrderButton.Name = "makeOrderButton";
            this.makeOrderButton.Size = new System.Drawing.Size(291, 29);
            this.makeOrderButton.TabIndex = 1;
            this.makeOrderButton.Text = "Make Order";
            this.makeOrderButton.UseVisualStyleBackColor = true;
            this.makeOrderButton.Click += new System.EventHandler(this.makeOrderButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(200)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(315, 126);
            this.Controls.Add(this.makeOrderButton);
            this.Controls.Add(this.mainFormAddProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Front";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mainFormAddProductButton;
        private System.Windows.Forms.Button makeOrderButton;
    }
}

