namespace ShoppingCart
{
    partial class NewProduct
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
            this.lblNewProductName = new System.Windows.Forms.Label();
            this.tbNewProductName = new System.Windows.Forms.TextBox();
            this.lblNewProductCategory = new System.Windows.Forms.Label();
            this.lblNewProductPrice = new System.Windows.Forms.Label();
            this.tbNewProductCategory = new System.Windows.Forms.TextBox();
            this.tbNewProductPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPrice = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewProductName
            // 
            this.lblNewProductName.AutoSize = true;
            this.lblNewProductName.Location = new System.Drawing.Point(12, 9);
            this.lblNewProductName.Name = "lblNewProductName";
            this.lblNewProductName.Size = new System.Drawing.Size(32, 13);
            this.lblNewProductName.TabIndex = 0;
            this.lblNewProductName.Text = "Име:";
            // 
            // tbNewProductName
            // 
            this.tbNewProductName.Location = new System.Drawing.Point(12, 25);
            this.tbNewProductName.Name = "tbNewProductName";
            this.tbNewProductName.Size = new System.Drawing.Size(259, 20);
            this.tbNewProductName.TabIndex = 1;
            this.tbNewProductName.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewProductName_Validating);
            // 
            // lblNewProductCategory
            // 
            this.lblNewProductCategory.AutoSize = true;
            this.lblNewProductCategory.Location = new System.Drawing.Point(12, 62);
            this.lblNewProductCategory.Name = "lblNewProductCategory";
            this.lblNewProductCategory.Size = new System.Drawing.Size(65, 13);
            this.lblNewProductCategory.TabIndex = 2;
            this.lblNewProductCategory.Text = "Категорија:";
            // 
            // lblNewProductPrice
            // 
            this.lblNewProductPrice.AutoSize = true;
            this.lblNewProductPrice.Location = new System.Drawing.Point(12, 113);
            this.lblNewProductPrice.Name = "lblNewProductPrice";
            this.lblNewProductPrice.Size = new System.Drawing.Size(36, 13);
            this.lblNewProductPrice.TabIndex = 3;
            this.lblNewProductPrice.Text = "Цена:";
            // 
            // tbNewProductCategory
            // 
            this.tbNewProductCategory.Location = new System.Drawing.Point(12, 78);
            this.tbNewProductCategory.Name = "tbNewProductCategory";
            this.tbNewProductCategory.Size = new System.Drawing.Size(259, 20);
            this.tbNewProductCategory.TabIndex = 4;
            this.tbNewProductCategory.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewProductCategory_Validating);
            // 
            // tbNewProductPrice
            // 
            this.tbNewProductPrice.Location = new System.Drawing.Point(12, 129);
            this.tbNewProductPrice.Name = "tbNewProductPrice";
            this.tbNewProductPrice.Size = new System.Drawing.Size(172, 20);
            this.tbNewProductPrice.TabIndex = 5;
            this.tbNewProductPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewProductPrice_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(202, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Додади";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(115, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Откажи";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorName
            // 
            this.errorName.ContainerControl = this;
            // 
            // errorCategory
            // 
            this.errorCategory.ContainerControl = this;
            // 
            // errorPrice
            // 
            this.errorPrice.ContainerControl = this;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 190);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNewProductPrice);
            this.Controls.Add(this.tbNewProductCategory);
            this.Controls.Add(this.lblNewProductPrice);
            this.Controls.Add(this.lblNewProductCategory);
            this.Controls.Add(this.tbNewProductName);
            this.Controls.Add(this.lblNewProductName);
            this.Name = "NewProduct";
            this.Text = "Нов продукт";
            ((System.ComponentModel.ISupportInitialize)(this.errorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewProductName;
        private System.Windows.Forms.TextBox tbNewProductName;
        private System.Windows.Forms.Label lblNewProductCategory;
        private System.Windows.Forms.Label lblNewProductPrice;
        private System.Windows.Forms.TextBox tbNewProductCategory;
        private System.Windows.Forms.TextBox tbNewProductPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorName;
        private System.Windows.Forms.ErrorProvider errorCategory;
        private System.Windows.Forms.ErrorProvider errorPrice;
    }
}