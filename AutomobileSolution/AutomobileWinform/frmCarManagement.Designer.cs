namespace AutomobileWinform
{
    partial class frmCarManagement
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
            this.IbCarID = new System.Windows.Forms.Label();
            this.IbCarName = new System.Windows.Forms.Label();
            this.IbManufacturer = new System.Windows.Forms.Label();
            this.IbPrice = new System.Windows.Forms.Label();
            this.IbReleasedYear = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReleasedYear = new System.Windows.Forms.TextBox();
            this.dgvCarList = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // IbCarID
            // 
            this.IbCarID.AutoSize = true;
            this.IbCarID.Location = new System.Drawing.Point(54, 34);
            this.IbCarID.Name = "IbCarID";
            this.IbCarID.Size = new System.Drawing.Size(41, 16);
            this.IbCarID.TabIndex = 0;
            this.IbCarID.Text = "CarID";
            // 
            // IbCarName
            // 
            this.IbCarName.AutoSize = true;
            this.IbCarName.Location = new System.Drawing.Point(54, 90);
            this.IbCarName.Name = "IbCarName";
            this.IbCarName.Size = new System.Drawing.Size(65, 16);
            this.IbCarName.TabIndex = 1;
            this.IbCarName.Text = "CarName";
            // 
            // IbManufacturer
            // 
            this.IbManufacturer.AutoSize = true;
            this.IbManufacturer.Location = new System.Drawing.Point(54, 150);
            this.IbManufacturer.Name = "IbManufacturer";
            this.IbManufacturer.Size = new System.Drawing.Size(84, 16);
            this.IbManufacturer.TabIndex = 2;
            this.IbManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            this.IbPrice.AutoSize = true;
            this.IbPrice.Location = new System.Drawing.Point(286, 34);
            this.IbPrice.Name = "IbPrice";
            this.IbPrice.Size = new System.Drawing.Size(38, 16);
            this.IbPrice.TabIndex = 3;
            this.IbPrice.Text = "Price";
            // 
            // IbReleasedYear
            // 
            this.IbReleasedYear.AutoSize = true;
            this.IbReleasedYear.Location = new System.Drawing.Point(274, 93);
            this.IbReleasedYear.Name = "IbReleasedYear";
            this.IbReleasedYear.Size = new System.Drawing.Size(96, 16);
            this.IbReleasedYear.TabIndex = 4;
            this.IbReleasedYear.Text = "ReleasedYear";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(144, 28);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(100, 22);
            this.txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(144, 84);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(100, 22);
            this.txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(144, 144);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(100, 22);
            this.txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(376, 28);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtReleasedYear
            // 
            this.txtReleasedYear.Location = new System.Drawing.Point(376, 90);
            this.txtReleasedYear.Name = "txtReleasedYear";
            this.txtReleasedYear.Size = new System.Drawing.Size(100, 22);
            this.txtReleasedYear.TabIndex = 9;
            // 
            // dgvCarList
            // 
            this.dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarList.Location = new System.Drawing.Point(49, 247);
            this.dgvCarList.Name = "dgvCarList";
            this.dgvCarList.RowHeadersWidth = 51;
            this.dgvCarList.RowTemplate.Height = 24;
            this.dgvCarList.Size = new System.Drawing.Size(478, 95);
            this.dgvCarList.TabIndex = 10;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(86, 199);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(255, 199);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(423, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(255, 370);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmCarManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 434);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgvCarList);
            this.Controls.Add(this.txtReleasedYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.IbReleasedYear);
            this.Controls.Add(this.IbPrice);
            this.Controls.Add(this.IbManufacturer);
            this.Controls.Add(this.IbCarName);
            this.Controls.Add(this.IbCarID);
            this.Name = "frmCarManagement";
            this.Text = "frmCarManagement";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbCarID;
        private System.Windows.Forms.Label IbCarName;
        private System.Windows.Forms.Label IbManufacturer;
        private System.Windows.Forms.Label IbPrice;
        private System.Windows.Forms.Label IbReleasedYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleasedYear;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}