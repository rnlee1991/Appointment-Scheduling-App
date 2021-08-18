
namespace C969___PA
{
    partial class AppointmentTypes
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
            this.apptTypeByMonthReport = new System.Windows.Forms.DataGridView();
            this.monthReportCB = new System.Windows.Forms.ComboBox();
            this.reportButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.reportLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.apptTypeByMonthReport)).BeginInit();
            this.SuspendLayout();
            // 
            // apptTypeByMonthReport
            // 
            this.apptTypeByMonthReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptTypeByMonthReport.Location = new System.Drawing.Point(12, 131);
            this.apptTypeByMonthReport.Name = "apptTypeByMonthReport";
            this.apptTypeByMonthReport.Size = new System.Drawing.Size(336, 253);
            this.apptTypeByMonthReport.TabIndex = 0;
            // 
            // monthReportCB
            // 
            this.monthReportCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthReportCB.FormattingEnabled = true;
            this.monthReportCB.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthReportCB.Location = new System.Drawing.Point(90, 57);
            this.monthReportCB.Name = "monthReportCB";
            this.monthReportCB.Size = new System.Drawing.Size(171, 21);
            this.monthReportCB.TabIndex = 1;
            this.monthReportCB.SelectedIndexChanged += new System.EventHandler(this.monthReportCB_SelectedIndexChanged);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(134, 102);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Run Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(102, 405);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(146, 23);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Return to Main Screen";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // reportLabel1
            // 
            this.reportLabel1.AutoSize = true;
            this.reportLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel1.Location = new System.Drawing.Point(69, 9);
            this.reportLabel1.Name = "reportLabel1";
            this.reportLabel1.Size = new System.Drawing.Size(215, 20);
            this.reportLabel1.TabIndex = 5;
            this.reportLabel1.Text = "Appointment Types by Month";
            // 
            // AppointmentTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.reportLabel1);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.monthReportCB);
            this.Controls.Add(this.apptTypeByMonthReport);
            this.Name = "AppointmentTypes";
            this.Text = "Appointment Types by Month";
            ((System.ComponentModel.ISupportInitialize)(this.apptTypeByMonthReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apptTypeByMonthReport;
        private System.Windows.Forms.ComboBox monthReportCB;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label reportLabel1;
    }
}