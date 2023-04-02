namespace Project_Final
{
    partial class addProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProduct));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pbimage = new System.Windows.Forms.PictureBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtICMID = new System.Windows.Forms.TextBox();
            this.database1DataSet1 = new Project_Final.Database1DataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Project_Final.Database1DataSet1TableAdapters.ProductTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet2 = new Project_Final.Database1DataSet2();
            this.iMGSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iMGSTableAdapter = new Project_Final.Database1DataSet2TableAdapters.IMGSTableAdapter();
            this.iIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMGDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(8, 250);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 26);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscard.Location = new System.Drawing.Point(438, 250);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(64, 26);
            this.btnDiscard.TabIndex = 19;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(294, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(294, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Size";
            // 
            // txtQuality
            // 
            this.txtQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuality.Location = new System.Drawing.Point(368, 103);
            this.txtQuality.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(169, 24);
            this.txtQuality.TabIndex = 10;
            this.txtQuality.TextChanged += new System.EventHandler(this.txtQuality_TextChanged);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(368, 57);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(169, 24);
            this.txtColor.TabIndex = 9;
            this.txtColor.TextChanged += new System.EventHandler(this.txtColor_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(368, 11);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 24);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(86, 60);
            this.txtSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(169, 24);
            this.txtSize.TabIndex = 6;
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(86, 12);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(169, 24);
            this.txtID.TabIndex = 11;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(507, 250);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pbimage
            // 
            this.pbimage.Image = ((System.Drawing.Image)(resources.GetObject("pbimage.Image")));
            this.pbimage.Location = new System.Drawing.Point(86, 149);
            this.pbimage.Margin = new System.Windows.Forms.Padding(2);
            this.pbimage.Name = "pbimage";
            this.pbimage.Size = new System.Drawing.Size(96, 98);
            this.pbimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbimage.TabIndex = 21;
            this.pbimage.TabStop = false;
            this.pbimage.Click += new System.EventHandler(this.pbimage_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(507, 220);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(70, 26);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert Image";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "ICMID";
            // 
            // txtICMID
            // 
            this.txtICMID.Location = new System.Drawing.Point(86, 103);
            this.txtICMID.Name = "txtICMID";
            this.txtICMID.Size = new System.Drawing.Size(169, 20);
            this.txtICMID.TabIndex = 23;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.database1DataSet1;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.pIDDataGridViewTextBoxColumn,
            this.iMGDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.iMGSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iMGSBindingSource
            // 
            this.iMGSBindingSource.DataMember = "IMGS";
            this.iMGSBindingSource.DataSource = this.database1DataSet2;
            // 
            // iMGSTableAdapter
            // 
            this.iMGSTableAdapter.ClearBeforeFill = true;
            // 
            // iIDDataGridViewTextBoxColumn
            // 
            this.iIDDataGridViewTextBoxColumn.DataPropertyName = "IID";
            this.iIDDataGridViewTextBoxColumn.HeaderText = "IID";
            this.iIDDataGridViewTextBoxColumn.Name = "iIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // pIDDataGridViewTextBoxColumn
            // 
            this.pIDDataGridViewTextBoxColumn.DataPropertyName = "PID";
            this.pIDDataGridViewTextBoxColumn.HeaderText = "PID";
            this.pIDDataGridViewTextBoxColumn.Name = "pIDDataGridViewTextBoxColumn";
            // 
            // iMGDataGridViewImageColumn
            // 
            this.iMGDataGridViewImageColumn.DataPropertyName = "IMG";
            this.iMGDataGridViewImageColumn.HeaderText = "IMG";
            this.iMGDataGridViewImageColumn.Name = "iMGDataGridViewImageColumn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "fileName:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(268, 222);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(200, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "IID";
            // 
            // txtIID
            // 
            this.txtIID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIID.Location = new System.Drawing.Point(247, 145);
            this.txtIID.Margin = new System.Windows.Forms.Padding(2);
            this.txtIID.Name = "txtIID";
            this.txtIID.Size = new System.Drawing.Size(169, 24);
            this.txtIID.TabIndex = 28;
            // 
            // addProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 439);
            this.Controls.Add(this.txtIID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtICMID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbimage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuality);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add product";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pbimage;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtICMID;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource productBindingSource;
        private Database1DataSet1TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource iMGSBindingSource;
        private Database1DataSet2TableAdapters.IMGSTableAdapter iMGSTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iMGDataGridViewImageColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIID;
    }
}