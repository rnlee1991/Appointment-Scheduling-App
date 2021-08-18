
namespace C969___PA
{
    partial class ModAppointment
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
            this.endDate = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.type = new System.Windows.Forms.Label();
            this.custID = new System.Windows.Forms.Label();
            this.modAppt = new System.Windows.Forms.Label();
            this.custIDCombo = new System.Windows.Forms.ComboBox();
            this.typeTB = new System.Windows.Forms.ComboBox();
            this.customerName = new System.Windows.Forms.Label();
            this.customerNameCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(195, 292);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 45;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(7, 292);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 44;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(15, 239);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(52, 13);
            this.endDate.TabIndex = 43;
            this.endDate.Text = "End Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(92, 232);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(155, 20);
            this.endDatePicker.TabIndex = 42;
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(16, 196);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(55, 13);
            this.startDate.TabIndex = 41;
            this.startDate.Text = "Start Date";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(92, 189);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(155, 20);
            this.startDatePicker.TabIndex = 40;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(36, 153);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 36;
            this.type.Text = "Type";
            // 
            // custID
            // 
            this.custID.AutoSize = true;
            this.custID.Location = new System.Drawing.Point(4, 67);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(65, 13);
            this.custID.TabIndex = 26;
            this.custID.Text = "Customer ID";
            // 
            // modAppt
            // 
            this.modAppt.AutoSize = true;
            this.modAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modAppt.Location = new System.Drawing.Point(37, 9);
            this.modAppt.Name = "modAppt";
            this.modAppt.Size = new System.Drawing.Size(195, 24);
            this.modAppt.TabIndex = 23;
            this.modAppt.Text = "Modify Appointment";
            // 
            // custIDCombo
            // 
            this.custIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custIDCombo.FormattingEnabled = true;
            this.custIDCombo.Location = new System.Drawing.Point(92, 59);
            this.custIDCombo.Name = "custIDCombo";
            this.custIDCombo.Size = new System.Drawing.Size(121, 21);
            this.custIDCombo.TabIndex = 46;
            // 
            // typeTB
            // 
            this.typeTB.BackColor = System.Drawing.Color.White;
            this.typeTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeTB.FormattingEnabled = true;
            this.typeTB.Items.AddRange(new object[] {
            "Presentation",
            "Scrum",
            "Training",
            "Interview"});
            this.typeTB.Location = new System.Drawing.Point(92, 145);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(121, 21);
            this.typeTB.TabIndex = 47;
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(4, 111);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(82, 13);
            this.customerName.TabIndex = 49;
            this.customerName.Text = "Customer Name";
            // 
            // customerNameCombo
            // 
            this.customerNameCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerNameCombo.FormattingEnabled = true;
            this.customerNameCombo.Location = new System.Drawing.Point(92, 103);
            this.customerNameCombo.Name = "customerNameCombo";
            this.customerNameCombo.Size = new System.Drawing.Size(121, 21);
            this.customerNameCombo.TabIndex = 50;
            // 
            // ModAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 327);
            this.Controls.Add(this.customerNameCombo);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.typeTB);
            this.Controls.Add(this.custIDCombo);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.type);
            this.Controls.Add(this.custID);
            this.Controls.Add(this.modAppt);
            this.Name = "ModAppointment";
            this.Text = "Modify Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label custID;
        private System.Windows.Forms.Label modAppt;
        private System.Windows.Forms.ComboBox custIDCombo;
        private System.Windows.Forms.ComboBox typeTB;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.ComboBox customerNameCombo;
    }
}