namespace ShoppingCart
{
    partial class ShoppingCart
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.btnEmptyLstProducts = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.gbProductDetails = new System.Windows.Forms.GroupBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.tbProductCategory = new System.Windows.Forms.TextBox();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.gbProductDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(9, 9);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(105, 13);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Листа со продукти:";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(12, 25);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(220, 329);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.SelectedIndexChanged += new System.EventHandler(this.lstProducts_SelectedIndexChanged);
            // 
            // btnEmptyLstProducts
            // 
            this.btnEmptyLstProducts.Location = new System.Drawing.Point(12, 360);
            this.btnEmptyLstProducts.Name = "btnEmptyLstProducts";
            this.btnEmptyLstProducts.Size = new System.Drawing.Size(220, 23);
            this.btnEmptyLstProducts.TabIndex = 2;
            this.btnEmptyLstProducts.Text = "Испразни ја листата со продукти?";
            this.btnEmptyLstProducts.UseVisualStyleBackColor = true;
            this.btnEmptyLstProducts.Click += new System.EventHandler(this.btnEmptyLstProducts_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(444, 25);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(206, 290);
            this.lstCart.TabIndex = 3;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(441, 9);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(60, 13);
            this.lblCart.TabIndex = 4;
            this.lblCart.Text = "Кошничка:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(441, 332);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Вкупно:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(485, 329);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(165, 20);
            this.tbTotal.TabIndex = 6;
            this.tbTotal.Text = "0.00";
            this.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(444, 360);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(206, 23);
            this.btnEmptyCart.TabIndex = 7;
            this.btnEmptyCart.Text = "Испразни ја кошничката?";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.btnEmptyCart_Click);
            // 
            // gbProductDetails
            // 
            this.gbProductDetails.Controls.Add(this.tbProductPrice);
            this.gbProductDetails.Controls.Add(this.lblProductPrice);
            this.gbProductDetails.Controls.Add(this.tbProductCategory);
            this.gbProductDetails.Controls.Add(this.lblProductCategory);
            this.gbProductDetails.Controls.Add(this.tbProductName);
            this.gbProductDetails.Controls.Add(this.lblProductName);
            this.gbProductDetails.Location = new System.Drawing.Point(238, 25);
            this.gbProductDetails.Name = "gbProductDetails";
            this.gbProductDetails.Size = new System.Drawing.Size(200, 142);
            this.gbProductDetails.TabIndex = 8;
            this.gbProductDetails.TabStop = false;
            this.gbProductDetails.Text = "Детали за продуктот";
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(6, 110);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.ReadOnly = true;
            this.tbProductPrice.Size = new System.Drawing.Size(119, 20);
            this.tbProductPrice.TabIndex = 5;
            this.tbProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(6, 94);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(36, 13);
            this.lblProductPrice.TabIndex = 4;
            this.lblProductPrice.Text = "Цена:";
            // 
            // tbProductCategory
            // 
            this.tbProductCategory.Location = new System.Drawing.Point(9, 71);
            this.tbProductCategory.Name = "tbProductCategory";
            this.tbProductCategory.ReadOnly = true;
            this.tbProductCategory.Size = new System.Drawing.Size(185, 20);
            this.tbProductCategory.TabIndex = 3;
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.Location = new System.Drawing.Point(6, 55);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(65, 13);
            this.lblProductCategory.TabIndex = 2;
            this.lblProductCategory.Text = "Категорија:";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(9, 32);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.ReadOnly = true;
            this.tbProductName.Size = new System.Drawing.Size(185, 20);
            this.tbProductName.TabIndex = 1;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 16);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(32, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Име:";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(238, 173);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(200, 23);
            this.btnAddToCart.TabIndex = 9;
            this.btnAddToCart.Text = "Додади во кошничка >>";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(238, 215);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(200, 23);
            this.btnRemoveFromCart.TabIndex = 10;
            this.btnRemoveFromCart.Text = "Избриши од кошничка";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(238, 254);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(200, 23);
            this.btnAddNewProduct.TabIndex = 11;
            this.btnAddNewProduct.Text = "Додади нов Продукт";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(238, 292);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(200, 23);
            this.btnRemoveProduct.TabIndex = 12;
            this.btnRemoveProduct.Text = "Избриши продукт";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 388);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnAddNewProduct);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.gbProductDetails);
            this.Controls.Add(this.btnEmptyCart);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.btnEmptyLstProducts);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lblProducts);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.gbProductDetails.ResumeLayout(false);
            this.gbProductDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.Button btnEmptyLstProducts;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Button btnEmptyCart;
        private System.Windows.Forms.GroupBox gbProductDetails;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox tbProductCategory;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
    }
}

