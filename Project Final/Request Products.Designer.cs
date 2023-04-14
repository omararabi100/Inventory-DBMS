namespace Project_Final
{
    partial class Request_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request_Products));
            this.dvProduct = new System.Windows.Forms.DataGridView();
            this.dvcart = new System.Windows.Forms.DataGridView();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnRequestItem = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvcart)).BeginInit();
            this.SuspendLayout();
            // 
            // dvProduct
            // 
            this.dvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvProduct.Location = new System.Drawing.Point(16, 34);
            this.dvProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvProduct.Name = "dvProduct";
            this.dvProduct.RowHeadersWidth = 51;
            this.dvProduct.Size = new System.Drawing.Size(1165, 185);
            this.dvProduct.TabIndex = 0;
            // 
            // dvcart
            // 
            this.dvcart.BackgroundColor = System.Drawing.Color.White;
            this.dvcart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvcart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvcart.Location = new System.Drawing.Point(1189, 34);
            this.dvcart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvcart.Name = "dvcart";
            this.dvcart.RowHeadersWidth = 51;
            this.dvcart.Size = new System.Drawing.Size(335, 185);
            this.dvcart.TabIndex = 1;
            this.dvcart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvcart_CellContentClick);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(121, 249);
            this.btnAddtoCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(100, 28);
            this.btnAddtoCart.TabIndex = 2;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(1233, 249);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(155, 28);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnRequestItem
            // 
            this.btnRequestItem.Location = new System.Drawing.Point(1396, 277);
            this.btnRequestItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRequestItem.Name = "btnRequestItem";
            this.btnRequestItem.Size = new System.Drawing.Size(128, 28);
            this.btnRequestItem.TabIndex = 4;
            this.btnRequestItem.Text = "Request Items";
            this.btnRequestItem.UseVisualStyleBackColor = true;
            this.btnRequestItem.Click += new System.EventHandler(this.btnRequestItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 277);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Request_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1531, 313);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRequestItem);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.dvcart);
            this.Controls.Add(this.dvProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Request_Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request_Products";
            this.Load += new System.EventHandler(this.Request_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvcart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvProduct;
        private System.Windows.Forms.DataGridView dvcart;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnRequestItem;
        private System.Windows.Forms.Button btnExit;
    }
}