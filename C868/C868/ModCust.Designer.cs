
namespace C969___PA
{
    partial class ModCust
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.postalTB = new System.Windows.Forms.TextBox();
            this.postalLabel = new System.Windows.Forms.Label();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.modCustLabel = new System.Windows.Forms.Label();
            this.adress2Label = new System.Windows.Forms.Label();
            this.address2TB = new System.Windows.Forms.TextBox();
            this.activeCB = new System.Windows.Forms.CheckBox();
            this.activeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(139, 342);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 28;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 342);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 27;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // phoneTB
            // 
            this.phoneTB.BackColor = System.Drawing.Color.Salmon;
            this.phoneTB.Location = new System.Drawing.Point(93, 282);
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(100, 20);
            this.phoneTB.TabIndex = 26;
            this.phoneTB.TextChanged += new System.EventHandler(this.phoneTB_TextChanged);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(7, 289);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(78, 13);
            this.phoneLabel.TabIndex = 25;
            this.phoneLabel.Text = "Phone Number";
            // 
            // countryCombo
            // 
            this.countryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Location = new System.Drawing.Point(92, 255);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(121, 21);
            this.countryCombo.TabIndex = 24;
            this.countryCombo.SelectedIndexChanged += new System.EventHandler(this.countryCombo_SelectedIndexChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(43, 263);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(43, 13);
            this.countryLabel.TabIndex = 23;
            this.countryLabel.Text = "Country";
            // 
            // postalTB
            // 
            this.postalTB.BackColor = System.Drawing.Color.Salmon;
            this.postalTB.Location = new System.Drawing.Point(92, 229);
            this.postalTB.Name = "postalTB";
            this.postalTB.Size = new System.Drawing.Size(100, 20);
            this.postalTB.TabIndex = 22;
            this.postalTB.TextChanged += new System.EventHandler(this.postalTB_TextChanged);
            // 
            // postalLabel
            // 
            this.postalLabel.AutoSize = true;
            this.postalLabel.Location = new System.Drawing.Point(24, 236);
            this.postalLabel.Name = "postalLabel";
            this.postalLabel.Size = new System.Drawing.Size(64, 13);
            this.postalLabel.TabIndex = 21;
            this.postalLabel.Text = "Postal Code";
            // 
            // cityCombo
            // 
            this.cityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(92, 202);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.Size = new System.Drawing.Size(121, 21);
            this.cityCombo.TabIndex = 20;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(61, 210);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(24, 13);
            this.cityLabel.TabIndex = 19;
            this.cityLabel.Text = "City";
            // 
            // addressTB
            // 
            this.addressTB.BackColor = System.Drawing.Color.Salmon;
            this.addressTB.Location = new System.Drawing.Point(93, 84);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(100, 20);
            this.addressTB.TabIndex = 18;
            this.addressTB.TextChanged += new System.EventHandler(this.addressTB_TextChanged);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 91);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(76, 13);
            this.addressLabel.TabIndex = 17;
            this.addressLabel.Text = "Street Address";
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.Color.Salmon;
            this.nameTB.Location = new System.Drawing.Point(92, 49);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(100, 20);
            this.nameTB.TabIndex = 16;
            this.nameTB.TextChanged += new System.EventHandler(this.nameTB_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(51, 56);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Name";
            // 
            // modCustLabel
            // 
            this.modCustLabel.AutoSize = true;
            this.modCustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modCustLabel.Location = new System.Drawing.Point(47, 9);
            this.modCustLabel.Name = "modCustLabel";
            this.modCustLabel.Size = new System.Drawing.Size(160, 27);
            this.modCustLabel.TabIndex = 29;
            this.modCustLabel.Text = "Modify Cutsomer";
            this.modCustLabel.UseCompatibleTextRendering = true;
            // 
            // adress2Label
            // 
            this.adress2Label.AutoSize = true;
            this.adress2Label.Location = new System.Drawing.Point(8, 121);
            this.adress2Label.Name = "adress2Label";
            this.adress2Label.Size = new System.Drawing.Size(77, 13);
            this.adress2Label.TabIndex = 30;
            this.adress2Label.Text = "Address Line 2";
            // 
            // address2TB
            // 
            this.address2TB.BackColor = System.Drawing.Color.White;
            this.address2TB.Location = new System.Drawing.Point(93, 114);
            this.address2TB.Name = "address2TB";
            this.address2TB.Size = new System.Drawing.Size(100, 20);
            this.address2TB.TabIndex = 31;
            // 
            // activeCB
            // 
            this.activeCB.AutoSize = true;
            this.activeCB.Location = new System.Drawing.Point(144, 164);
            this.activeCB.Name = "activeCB";
            this.activeCB.Size = new System.Drawing.Size(15, 14);
            this.activeCB.TabIndex = 33;
            this.activeCB.UseVisualStyleBackColor = true;
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(7, 165);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(90, 13);
            this.activeLabel.TabIndex = 32;
            this.activeLabel.Text = "Active Customer?";
            // 
            // ModCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 399);
            this.Controls.Add(this.activeCB);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.address2TB);
            this.Controls.Add(this.adress2Label);
            this.Controls.Add(this.modCustLabel);
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
            this.Name = "ModCust";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.ComboBox countryCombo;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox postalTB;
        private System.Windows.Forms.Label postalLabel;
        private System.Windows.Forms.ComboBox cityCombo;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label modCustLabel;
        private System.Windows.Forms.Label adress2Label;
        private System.Windows.Forms.TextBox address2TB;
        private System.Windows.Forms.CheckBox activeCB;
        private System.Windows.Forms.Label activeLabel;
    }
}