namespace StoreInventory
{
    partial class Form1
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
            this.storeList = new System.Windows.Forms.ListBox();
            this.inventoryList = new System.Windows.Forms.ListBox();
            this.productList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.StoreStreetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StoreCityTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.StoreStateTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StoreZipTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.DeleteStoreButton = new System.Windows.Forms.Button();
            this.DeleteInventoryButton = new System.Windows.Forms.Button();
            this.AddInventoryButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductManufacturerTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ProductBrandTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // storeList
            // 
            this.storeList.FormattingEnabled = true;
            this.storeList.Location = new System.Drawing.Point(14, 26);
            this.storeList.Name = "storeList";
            this.storeList.Size = new System.Drawing.Size(120, 225);
            this.storeList.TabIndex = 1;
            this.storeList.SelectedIndexChanged += new System.EventHandler(this.storeList_SelectedIndexChanged);
            // 
            // inventoryList
            // 
            this.inventoryList.FormattingEnabled = true;
            this.inventoryList.Location = new System.Drawing.Point(14, 27);
            this.inventoryList.Name = "inventoryList";
            this.inventoryList.Size = new System.Drawing.Size(120, 225);
            this.inventoryList.TabIndex = 3;
            // 
            // productList
            // 
            this.productList.FormattingEnabled = true;
            this.productList.Location = new System.Drawing.Point(14, 26);
            this.productList.Name = "productList";
            this.productList.Size = new System.Drawing.Size(120, 225);
            this.productList.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Location = new System.Drawing.Point(9, 44);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StoreNameTextBox.TabIndex = 9;
            // 
            // StoreStreetTextBox
            // 
            this.StoreStreetTextBox.Location = new System.Drawing.Point(6, 96);
            this.StoreStreetTextBox.Name = "StoreStreetTextBox";
            this.StoreStreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.StoreStreetTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Street";
            // 
            // StoreCityTextBox
            // 
            this.StoreCityTextBox.Location = new System.Drawing.Point(6, 149);
            this.StoreCityTextBox.Name = "StoreCityTextBox";
            this.StoreCityTextBox.Size = new System.Drawing.Size(100, 20);
            this.StoreCityTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "City";
            // 
            // StoreStateTextBox
            // 
            this.StoreStateTextBox.Location = new System.Drawing.Point(6, 200);
            this.StoreStateTextBox.Name = "StoreStateTextBox";
            this.StoreStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.StoreStateTextBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "State";
            // 
            // StoreZipTextBox
            // 
            this.StoreZipTextBox.Location = new System.Drawing.Point(6, 254);
            this.StoreZipTextBox.Name = "StoreZipTextBox";
            this.StoreZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.StoreZipTextBox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Zip code";
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.Location = new System.Drawing.Point(14, 267);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(120, 23);
            this.AddStoreButton.TabIndex = 18;
            this.AddStoreButton.Text = "Add Store";
            this.AddStoreButton.UseVisualStyleBackColor = true;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click);
            // 
            // DeleteStoreButton
            // 
            this.DeleteStoreButton.Location = new System.Drawing.Point(14, 301);
            this.DeleteStoreButton.Name = "DeleteStoreButton";
            this.DeleteStoreButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteStoreButton.TabIndex = 19;
            this.DeleteStoreButton.Text = "Delete Store";
            this.DeleteStoreButton.UseVisualStyleBackColor = true;
            this.DeleteStoreButton.Click += new System.EventHandler(this.DeleteStoreButton_Click);
            // 
            // DeleteInventoryButton
            // 
            this.DeleteInventoryButton.Location = new System.Drawing.Point(14, 302);
            this.DeleteInventoryButton.Name = "DeleteInventoryButton";
            this.DeleteInventoryButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteInventoryButton.TabIndex = 21;
            this.DeleteInventoryButton.Text = "Delete Inventory";
            this.DeleteInventoryButton.UseVisualStyleBackColor = true;
            this.DeleteInventoryButton.Click += new System.EventHandler(this.DeleteInventoryButton_Click);
            // 
            // AddInventoryButton
            // 
            this.AddInventoryButton.Location = new System.Drawing.Point(14, 268);
            this.AddInventoryButton.Name = "AddInventoryButton";
            this.AddInventoryButton.Size = new System.Drawing.Size(120, 23);
            this.AddInventoryButton.TabIndex = 20;
            this.AddInventoryButton.Text = "Add Inventory";
            this.AddInventoryButton.UseVisualStyleBackColor = true;
            this.AddInventoryButton.Click += new System.EventHandler(this.AddInventoryButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(14, 301);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(120, 23);
            this.DeleteProductButton.TabIndex = 23;
            this.DeleteProductButton.Text = "Delete Product";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(14, 267);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(120, 23);
            this.AddProductButton.TabIndex = 22;
            this.AddProductButton.Text = "Add Product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProductManufacturerTextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ProductBrandTextBox);
            this.groupBox1.Location = new System.Drawing.Point(140, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 143);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manufacturer";
            // 
            // ProductManufacturerTextBox
            // 
            this.ProductManufacturerTextBox.Location = new System.Drawing.Point(9, 44);
            this.ProductManufacturerTextBox.Name = "ProductManufacturerTextBox";
            this.ProductManufacturerTextBox.Size = new System.Drawing.Size(148, 20);
            this.ProductManufacturerTextBox.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Brand";
            // 
            // ProductBrandTextBox
            // 
            this.ProductBrandTextBox.Location = new System.Drawing.Point(9, 96);
            this.ProductBrandTextBox.Name = "ProductBrandTextBox";
            this.ProductBrandTextBox.Size = new System.Drawing.Size(148, 20);
            this.ProductBrandTextBox.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.StoreNameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.StoreStreetTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.StoreCityTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.StoreStateTextBox);
            this.groupBox2.Controls.Add(this.StoreZipTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(140, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 304);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Store";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.storeList);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.AddStoreButton);
            this.groupBox3.Controls.Add(this.DeleteStoreButton);
            this.groupBox3.Location = new System.Drawing.Point(13, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 337);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Store";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inventoryList);
            this.groupBox4.Controls.Add(this.AddInventoryButton);
            this.groupBox4.Controls.Add(this.DeleteInventoryButton);
            this.groupBox4.Location = new System.Drawing.Point(317, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(149, 337);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Store Inventory";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.productList);
            this.groupBox5.Controls.Add(this.AddProductButton);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.DeleteProductButton);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(489, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 337);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "All Products";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 361);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Store Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox storeList;
        private System.Windows.Forms.ListBox inventoryList;
        private System.Windows.Forms.ListBox productList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.TextBox StoreStreetTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox StoreCityTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox StoreStateTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StoreZipTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AddStoreButton;
        private System.Windows.Forms.Button DeleteStoreButton;
        private System.Windows.Forms.Button DeleteInventoryButton;
        private System.Windows.Forms.Button AddInventoryButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductManufacturerTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ProductBrandTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

