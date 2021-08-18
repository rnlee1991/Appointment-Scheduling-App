
namespace C969___PA
{
    partial class ApptsByCustomer
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
            this.reportLabel = new System.Windows.Forms.Label();
            this.custApptsCB = new System.Windows.Forms.ComboBox();
            this.apptsByCust = new System.Windows.Forms.DataGridView();
            this.homeButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apptsByCust)).BeginInit();
            this.SuspendLayout();
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.Location = new System.Drawing.Point(45, 9);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(201, 20);
            this.reportLabel.TabIndex = 0;
            this.reportLabel.Text = "Appointments by Customer";
            // 
            // custApptsCB
            // 
            this.custApptsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custApptsCB.FormattingEnabled = true;
            this.custApptsCB.Location = new System.Drawing.Point(93, 32);
            this.custApptsCB.Name = "custApptsCB";
            this.custApptsCB.Size = new System.Drawing.Size(121, 21);
            this.custApptsCB.TabIndex = 1;
            this.custApptsCB.SelectedIndexChanged += new System.EventHandler(this.custApptsCB_SelectedIndexChanged);
            // 
            // apptsByCust
            // 
            this.apptsByCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptsByCust.Location = new System.Drawing.Point(12, 96);
            this.apptsByCust.Name = "apptsByCust";
            this.apptsByCust.Size = new System.Drawing.Size(297, 266);
            this.apptsByCust.TabIndex = 2;
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(84, 391);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(162, 23);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Return to Main Screen";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(118, 67);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Run Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // ApptsByCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.apptsByCust);
            this.Controls.Add(this.custApptsCB);
            this.Controls.Add(this.reportLabel);
            this.Name = "ApptsByCustomer";
            this.Text = "Appointments by Customer Report";
            ((System.ComponentModel.ISupportInitialize)(this.apptsByCust)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.ComboBox custApptsCB;
        private System.Windows.Forms.DataGridView apptsByCust;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button reportButton;
    }
}