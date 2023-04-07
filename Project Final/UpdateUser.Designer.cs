namespace Project_Final
{
    partial class ModifyUser
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
            this.dvgUsers = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PositionComb = new System.Windows.Forms.ComboBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgUsers
            // 
            this.dvgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsers.Location = new System.Drawing.Point(188, 51);
            this.dvgUsers.Name = "dvgUsers";
            this.dvgUsers.Size = new System.Drawing.Size(732, 294);
            this.dvgUsers.TabIndex = 0;
            this.dvgUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgUsers_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 113);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search by Name:";
            // 
            // PositionComb
            // 
            this.PositionComb.FormattingEnabled = true;
            this.PositionComb.Items.AddRange(new object[] {
            "Administrator",
            "Warehouse Manager",
            "Inventory Control Manager",
            "Accountant",
            "Staff Member"});
            this.PositionComb.Location = new System.Drawing.Point(12, 186);
            this.PositionComb.Name = "PositionComb";
            this.PositionComb.Size = new System.Drawing.Size(121, 21);
            this.PositionComb.TabIndex = 3;
            this.PositionComb.SelectedIndexChanged += new System.EventHandler(this.PositionComb_SelectedIndexChanged);
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(13, 170);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(80, 13);
            this.lblSP.TabIndex = 4;
            this.lblSP.Text = "Select Position:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(845, 415);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(18, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSP);
            this.Controls.Add(this.PositionComb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dvgUsers);
            this.Name = "ModifyUser";
            this.Text = "UpdateUser";
            this.Load += new System.EventHandler(this.RemoveUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgUsers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PositionComb;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
    }
}