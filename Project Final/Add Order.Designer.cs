namespace Project_Final
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.btnClear = new System.Windows.Forms.Button();
            this.btmExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSpent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dvAdd = new System.Windows.Forms.DataGridView();
            this.dvSelected = new System.Windows.Forms.DataGridView();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.RemoveProductBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(15, 460);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 32);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btmExit
            // 
            this.btmExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmExit.Location = new System.Drawing.Point(568, 460);
            this.btmExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(85, 32);
            this.btmExit.TabIndex = 41;
            this.btmExit.Text = "Exit";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 25);
            this.label6.TabIndex = 40;
            this.label6.Text = "ID";
            // 
            // txtOID
            // 
            this.txtOID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOID.Location = new System.Drawing.Point(92, 33);
            this.txtOID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOID.Name = "txtOID";
            this.txtOID.Size = new System.Drawing.Size(212, 28);
            this.txtOID.TabIndex = 38;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(659, 460);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 32);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Amount Spent";
            // 
            // txtSpent
            // 
            this.txtSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpent.Location = new System.Drawing.Point(517, 34);
            this.txtSpent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSpent.Name = "txtSpent";
            this.txtSpent.Size = new System.Drawing.Size(212, 28);
            this.txtSpent.TabIndex = 37;
            this.txtSpent.TextChanged += new System.EventHandler(this.txtSpent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "AID";
            // 
            // txtAID
            // 
            this.txtAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAID.Location = new System.Drawing.Point(92, 90);
            this.txtAID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAID.Name = "txtAID";
            this.txtAID.Size = new System.Drawing.Size(212, 28);
            this.txtAID.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(517, 92);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(212, 28);
            this.txtPhoneNumber.TabIndex = 48;
            // 
            // dvAdd
            // 
            this.dvAdd.BackgroundColor = System.Drawing.Color.White;
            this.dvAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAdd.Location = new System.Drawing.Point(31, 218);
            this.dvAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvAdd.Name = "dvAdd";
            this.dvAdd.RowHeadersWidth = 51;
            this.dvAdd.Size = new System.Drawing.Size(312, 144);
            this.dvAdd.TabIndex = 49;
            this.dvAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dvSelected
            // 
            this.dvSelected.BackgroundColor = System.Drawing.Color.White;
            this.dvSelected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvSelected.Location = new System.Drawing.Point(429, 218);
            this.dvSelected.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dvSelected.Name = "dvSelected";
            this.dvSelected.RowHeadersWidth = 51;
            this.dvSelected.Size = new System.Drawing.Size(320, 144);
            this.dvSelected.TabIndex = 50;
            this.dvSelected.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(109, 393);
            this.AddProductBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(111, 28);
            this.AddProductBtn.TabIndex = 51;
            this.AddProductBtn.Text = "Add Item";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // RemoveProductBtn
            // 
            this.RemoveProductBtn.Location = new System.Drawing.Point(517, 393);
            this.RemoveProductBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveProductBtn.Name = "RemoveProductBtn";
            this.RemoveProductBtn.Size = new System.Drawing.Size(111, 28);
            this.RemoveProductBtn.TabIndex = 52;
            this.RemoveProductBtn.Text = "Remove Item";
            this.RemoveProductBtn.UseVisualStyleBackColor = true;
            this.RemoveProductBtn.Click += new System.EventHandler(this.RemoveProductBtn_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 507);
            this.Controls.Add(this.RemoveProductBtn);
            this.Controls.Add(this.AddProductBtn);
            this.Controls.Add(this.dvSelected);
            this.Controls.Add(this.dvAdd);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSpent);
            this.Controls.Add(this.txtOID);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add order";
            this.Load += new System.EventHandler(this.Form15_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvSelected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSpent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DataGridView dvAdd;
        private System.Windows.Forms.DataGridView dvSelected;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.Button RemoveProductBtn;
    }
}