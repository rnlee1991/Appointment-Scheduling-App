
namespace C969___PA
{
    partial class AddAppointment
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
            this.addAppt = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.Label();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.custID = new System.Windows.Forms.Label();
            this.custIDCombo = new System.Windows.Forms.ComboBox();
            this.typeTB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addAppt
            // 
            this.addAppt.AutoSize = true;
            this.addAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppt.Location = new System.Drawing.Point(54, 9);
            this.addAppt.Name = "addAppt";
            this.addAppt.Size = new System.Drawing.Size(172, 24);
            this.addAppt.TabIndex = 0;
            this.addAppt.Text = "Add Appointment";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(46, 117);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(31, 13);
            this.type.TabIndex = 13;
            this.type.Text = "Type";
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(92, 156);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(154, 20);
            this.startDatePicker.TabIndex = 17;
            this.startDatePicker.ValueChanged += new System.EventHandler(this.startDatePicker_ValueChanged);
            // 
            // startDate
            // 
            this.startDate.AutoSize = true;
            this.startDate.Location = new System.Drawing.Point(30, 163);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(55, 13);
            this.startDate.TabIndex = 18;
            this.startDate.Text = "Start Date";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "yyyy/MM/dd hh:mm tt";
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(92, 207);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(154, 20);
            this.endDatePicker.TabIndex = 19;
            this.endDatePicker.ValueChanged += new System.EventHandler(this.endDatePicker_ValueChanged);
            // 
            // endDate
            // 
            this.endDate.AutoSize = true;
            this.endDate.Location = new System.Drawing.Point(30, 214);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(52, 13);
            this.endDate.TabIndex = 20;
            this.endDate.Text = "End Date";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 276);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(213, 276);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // custID
            // 
            this.custID.AutoSize = true;
            this.custID.Location = new System.Drawing.Point(12, 72);
            this.custID.Name = "custID";
            this.custID.Size = new System.Drawing.Size(65, 13);
            this.custID.TabIndex = 3;
            this.custID.Text = "Customer ID";
            // 
            // custIDCombo
            // 
            this.custIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custIDCombo.FormattingEnabled = true;
            this.custIDCombo.Location = new System.Drawing.Point(92, 64);
            this.custIDCombo.Name = "custIDCombo";
            this.custIDCombo.Size = new System.Drawing.Size(154, 21);
            this.custIDCombo.TabIndex = 23;
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
            this.typeTB.Location = new System.Drawing.Point(92, 114);
            this.typeTB.Name = "typeTB";
            this.typeTB.Size = new System.Drawing.Size(121, 21);
            this.typeTB.TabIndex = 24;
            this.typeTB.SelectedIndexChanged += new System.EventHandler(this.typeTB_SelectedIndexChanged);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 311);
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
            this.Controls.Add(this.addAppt);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAppt;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label startDate;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.Label endDate;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label custID;
        private System.Windows.Forms.ComboBox custIDCombo;
        private System.Windows.Forms.ComboBox typeTB;
    }
}