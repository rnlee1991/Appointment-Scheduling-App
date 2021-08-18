
namespace C969___PA
{
    partial class AddCust
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
            this.addCustLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.postalLabel = new System.Windows.Forms.Label();
            this.postalTB = new System.Windows.Forms.TextBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.address2Label = new System.Windows.Forms.Label();
            this.address2TB = new System.Windows.Forms.TextBox();
            this.activeLabel = new System.Windows.Forms.Label();
            this.activeCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // addCustLabel
            // 
            this.addCustLabel.AutoSize = true;
            this.addCustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustLabel.Location = new System.Drawing.Point(60, 9);
            this.addCustLabel.Name = "addCustLabel";
            this.addCustLabel.Size = new System.Drawing.Size(143, 24);
            this.addCustLabel.TabIndex = 0;
            this.addCustLabel.Text = "Add Customer";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(62, 77);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.Salmon;
            this.nameTB.Location = new System.Drawing.Point(103, 70);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 2;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(21, 115);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(76, 13);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Street Address";
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.Color.Salmon;
            this.addressTB.Location = new System.Drawing.Point(103, 107);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(100, 20);
            this.addressTB.TabIndex = 4;
            this.addressTB.TextChanged += new System.EventHandler(this.addressTB_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(72, 213);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 5;
            this.cityLabel.Text = "City";
            // 
            // cityCombo
            // 
            this.cityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(102, 205);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.Size = new System.Drawing.Size(121, 21);
            this.cityCombo.TabIndex = 6;
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Location = new System.Drawing.Point(32, 239);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(64, 13);
            this.postalLabel.TabIndex = 7;
            this.postalLabel.Text = "Postal Code";
            // 
            // postalTB
            // 
            this.postalTB.BackColor = System.Drawing.Color.Salmon;
            this.postalTB.Location = new System.Drawing.Point(102, 232);
            this.postalTB.Name = "postalTB";
            this.postalTB.Size = new System.Drawing.Size(100, 20);
            this.postalTB.TabIndex = 8;
            this.postalTB.TextChanged += new System.EventHandler(this.postalTB_TextChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(53, 266);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 9;
            this.countryLabel.Text = "Country";
            // 
            // countryCombo
            // 
            this.countryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Location = new System.Drawing.Point(102, 258);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(121, 21);
            this.countryCombo.TabIndex = 10;
            this.countryCombo.SelectedIndexChanged += new System.EventHandler(this.countryCombo_SelectedIndexChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(21, 292);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 11;
            this.phoneLabel.Text = "Phone Number";
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.Salmon;
            this.phoneTB.Location = new System.Drawing.Point(102, 285);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 20);
            this.phoneTB.TabIndex = 12;
            this.phoneTB.TextChanged += new System.EventHandler(this.phoneTB_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(22, 327);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(149, 327);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(19, 144);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(77, 13);
            this.address2Label.TabIndex = 15;
            this.address2Label.Text = "Address Line 2";
            // 
            // address2TB
            // 
            this.address2TB.BackColor = System.Drawing.Color.White;
            this.address2TB.Location = new System.Drawing.Point(103, 137);
            this.address2TB.Name = "address2TB";
            this.address2TB.Size = new System.Drawing.Size(100, 20);
            this.address2TB.TabIndex = 16;
            this.address2TB.TextChanged += new System.EventHandler(this.address2TB_TextChanged);
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(12, 178);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(90, 13);
            this.activeLabel.TabIndex = 17;
            this.activeLabel.Text = "Active Customer?";
            // 
            // activeCB
            // 
            this.activeCB.AutoSize = true;
            this.activeCB.Location = new System.Drawing.Point(149, 177);
            this.activeCB.Name = "activeCB";
            this.activeCB.Size = new System.Drawing.Size(15, 14);
            this.activeCB.TabIndex = 18;
            this.activeCB.UseVisualStyleBackColor = true;
            // 
            // AddCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 369);
            this.Controls.Add(this.activeCB);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.address2TB);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.countryCombo);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.postalTB);
            this.Controls.Add(this.postalLabel);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addCustLabel);
            this.Name = "AddCust";
            this.Text = "Add Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addCustLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox cityCombo;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.TextBox postalTB;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox address2TB;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.CheckBox activeCB;
    }
}