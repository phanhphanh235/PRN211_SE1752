namespace AutomobileWinform
{
    partial class frmCarDetails
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
            this.CarID = new System.Windows.Forms.Label();
            this.CarName = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.ReleasedYear = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtReleasedYear = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // CarID
            // 
            this.CarID.AutoSize = true;
            this.CarID.Location = new System.Drawing.Point(33, 40);
            this.CarID.Name = "CarID";
            this.CarID.Size = new System.Drawing.Size(41, 16);
            this.CarID.TabIndex = 0;
            this.CarID.Text = "CarID";
            this.CarID.Click += new System.EventHandler(this.CarID_Click);
            // 
            // CarName
            // 
            this.CarName.AutoSize = true;
            this.CarName.Location = new System.Drawing.Point(33, 107);
            this.CarName.Name = "CarName";
            this.CarName.Size = new System.Drawing.Size(65, 16);
            this.CarName.TabIndex = 1;
            this.CarName.Text = "CarName";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(33, 174);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(84, 16);
            this.Manufacturer.TabIndex = 2;
            this.Manufacturer.Text = "Manufacturer";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Location = new System.Drawing.Point(36, 234);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(38, 16);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price";
            // 
            // ReleasedYear
            // 
            this.ReleasedYear.AutoSize = true;
            this.ReleasedYear.Location = new System.Drawing.Point(33, 297);
            this.ReleasedYear.Name = "ReleasedYear";
            this.ReleasedYear.Size = new System.Drawing.Size(96, 16);
            this.ReleasedYear.TabIndex = 4;
            this.ReleasedYear.Text = "ReleasedYear";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(105, 353);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 353);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(154, 40);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(145, 22);
            this.txtCarID.TabIndex = 7;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(154, 104);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(145, 22);
            this.txtCarName.TabIndex = 8;
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Items:",
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(154, 166);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(145, 24);
            this.cboManufacturer.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(154, 234);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(145, 22);
            this.txtPrice.TabIndex = 10;
            // 
            // txtReleasedYear
            // 
            this.txtReleasedYear.Location = new System.Drawing.Point(154, 297);
            this.txtReleasedYear.Name = "txtReleasedYear";
            this.txtReleasedYear.Size = new System.Drawing.Size(145, 22);
            this.txtReleasedYear.TabIndex = 11;
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.txtReleasedYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ReleasedYear);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.CarName);
            this.Controls.Add(this.CarID);
            this.Name = "frmCarDetails";
            this.Text = "frmCarDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CarID;
        private System.Windows.Forms.Label CarName;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label ReleasedYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleasedYear;
    }
}