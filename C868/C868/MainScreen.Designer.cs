
namespace C969___PA
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.alltimeRB = new System.Windows.Forms.RadioButton();
            this.deleteAppt = new System.Windows.Forms.Button();
            this.modAppt = new System.Windows.Forms.Button();
            this.addAppt = new System.Windows.Forms.Button();
            this.apptLabel = new System.Windows.Forms.Label();
            this.appts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u07xPrDataSet = new C969___PA.U07xPrDataSet();
            this.view = new System.Windows.Forms.Label();
            this.monthRadio = new System.Windows.Forms.RadioButton();
            this.weekRadio = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.userScheduleReport = new System.Windows.Forms.Button();
            this.apptTypebyMonth = new System.Windows.Forms.Button();
            this.appointmentTableAdapter = new C969___PA.U07xPrDataSetTableAdapters.appointmentTableAdapter();
            this.tableAdapterManager = new C969___PA.U07xPrDataSetTableAdapters.TableAdapterManager();
            this.customerTableAdapter = new C969___PA.U07xPrDataSetTableAdapters.customerTableAdapter();
            this.appointmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.apptsByCustomer = new System.Windows.Forms.Button();
            this.deleteCust = new System.Windows.Forms.Button();
            this.modCust = new System.Windows.Forms.Button();
            this.addCust = new System.Windows.Forms.Button();
            this.customers = new System.Windows.Forms.Label();
            this.custs = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.searchButton1 = new System.Windows.Forms.Button();
            this.searchButton2 = new System.Windows.Forms.Button();
            this.searchBox1 = new System.Windows.Forms.TextBox();
            this.searchBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07xPrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBox1);
            this.panel1.Controls.Add(this.searchButton1);
            this.panel1.Controls.Add(this.alltimeRB);
            this.panel1.Controls.Add(this.deleteAppt);
            this.panel1.Controls.Add(this.modAppt);
            this.panel1.Controls.Add(this.addAppt);
            this.panel1.Controls.Add(this.apptLabel);
            this.panel1.Controls.Add(this.appts);
            this.panel1.Controls.Add(this.view);
            this.panel1.Controls.Add(this.monthRadio);
            this.panel1.Controls.Add(this.weekRadio);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.calendar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 316);
            this.panel1.TabIndex = 0;
            // 
            // alltimeRB
            // 
            this.alltimeRB.AutoSize = true;
            this.alltimeRB.Checked = true;
            this.alltimeRB.Location = new System.Drawing.Point(288, 153);
            this.alltimeRB.Name = "alltimeRB";
            this.alltimeRB.Size = new System.Drawing.Size(62, 17);
            this.alltimeRB.TabIndex = 10;
            this.alltimeRB.TabStop = true;
            this.alltimeRB.Text = "All-Time";
            this.alltimeRB.UseVisualStyleBackColor = true;
            this.alltimeRB.CheckedChanged += new System.EventHandler(this.alltimeRB_CheckedChanged);
            // 
            // deleteAppt
            // 
            this.deleteAppt.Location = new System.Drawing.Point(805, 283);
            this.deleteAppt.Name = "deleteAppt";
            this.deleteAppt.Size = new System.Drawing.Size(75, 23);
            this.deleteAppt.TabIndex = 9;
            this.deleteAppt.Text = "Delete";
            this.deleteAppt.UseVisualStyleBackColor = true;
            this.deleteAppt.Click += new System.EventHandler(this.deleteAppt_Click);
            // 
            // modAppt
            // 
            this.modAppt.Location = new System.Drawing.Point(724, 283);
            this.modAppt.Name = "modAppt";
            this.modAppt.Size = new System.Drawing.Size(75, 23);
            this.modAppt.TabIndex = 8;
            this.modAppt.Text = "Modify";
            this.modAppt.UseVisualStyleBackColor = true;
            this.modAppt.Click += new System.EventHandler(this.modAppt_Click);
            // 
            // addAppt
            // 
            this.addAppt.Location = new System.Drawing.Point(643, 283);
            this.addAppt.Name = "addAppt";
            this.addAppt.Size = new System.Drawing.Size(75, 23);
            this.addAppt.TabIndex = 7;
            this.addAppt.Text = "Add";
            this.addAppt.UseVisualStyleBackColor = true;
            this.addAppt.Click += new System.EventHandler(this.addAppt_Click);
            // 
            // apptLabel
            // 
            this.apptLabel.AutoSize = true;
            this.apptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptLabel.Location = new System.Drawing.Point(390, 25);
            this.apptLabel.Name = "apptLabel";
            this.apptLabel.Size = new System.Drawing.Size(125, 20);
            this.apptLabel.TabIndex = 6;
            this.apptLabel.Text = "Appointments ";
            // 
            // appts
            // 
            this.appts.AllowUserToAddRows = false;
            this.appts.AllowUserToDeleteRows = false;
            this.appts.AutoGenerateColumns = false;
            this.appts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.appts.DataSource = this.appointmentBindingSource;
            this.appts.Location = new System.Drawing.Point(394, 56);
            this.appts.Name = "appts";
            this.appts.ReadOnly = true;
            this.appts.Size = new System.Drawing.Size(578, 221);
            this.appts.TabIndex = 5;
            this.appts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appts_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "customerId";
            this.dataGridViewTextBoxColumn2.HeaderText = "customerId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn8.HeaderText = "type";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "start";
            this.dataGridViewTextBoxColumn10.HeaderText = "start";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "end";
            this.dataGridViewTextBoxColumn11.HeaderText = "end";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "appointment";
            this.appointmentBindingSource.DataSource = this.u07xPrDataSet;
            // 
            // u07xPrDataSet
            // 
            this.u07xPrDataSet.DataSetName = "U07xPrDataSet";
            this.u07xPrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view
            // 
            this.view.AutoSize = true;
            this.view.Location = new System.Drawing.Point(267, 54);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(97, 13);
            this.view.TabIndex = 4;
            this.view.Text = "Appointments View";
            // 
            // monthRadio
            // 
            this.monthRadio.AutoSize = true;
            this.monthRadio.Location = new System.Drawing.Point(288, 117);
            this.monthRadio.Name = "monthRadio";
            this.monthRadio.Size = new System.Drawing.Size(55, 17);
            this.monthRadio.TabIndex = 3;
            this.monthRadio.TabStop = true;
            this.monthRadio.Text = "Month";
            this.monthRadio.UseVisualStyleBackColor = true;
            this.monthRadio.CheckedChanged += new System.EventHandler(this.monthRadio_CheckedChanged);
            // 
            // weekRadio
            // 
            this.weekRadio.AutoSize = true;
            this.weekRadio.Location = new System.Drawing.Point(288, 76);
            this.weekRadio.Name = "weekRadio";
            this.weekRadio.Size = new System.Drawing.Size(54, 17);
            this.weekRadio.TabIndex = 2;
            this.weekRadio.TabStop = true;
            this.weekRadio.Text = "Week";
            this.weekRadio.UseVisualStyleBackColor = true;
            this.weekRadio.CheckedChanged += new System.EventHandler(this.weekRadio_CheckedChanged);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(55, 32);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(150, 13);
            this.date.TabIndex = 1;
            this.date.Text = "Select Your Appointment Date";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(18, 54);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // userScheduleReport
            // 
            this.userScheduleReport.Location = new System.Drawing.Point(80, 101);
            this.userScheduleReport.Name = "userScheduleReport";
            this.userScheduleReport.Size = new System.Drawing.Size(124, 23);
            this.userScheduleReport.TabIndex = 12;
            this.userScheduleReport.Text = "User Schedule Report";
            this.userScheduleReport.UseVisualStyleBackColor = true;
            this.userScheduleReport.Click += new System.EventHandler(this.userScheduleReport_Click);
            // 
            // apptTypebyMonth
            // 
            this.apptTypebyMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.apptTypebyMonth.Location = new System.Drawing.Point(80, 45);
            this.apptTypebyMonth.Name = "apptTypebyMonth";
            this.apptTypebyMonth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.apptTypebyMonth.Size = new System.Drawing.Size(99, 23);
            this.apptTypebyMonth.TabIndex = 11;
            this.apptTypebyMonth.Text = "Appt Type Report";
            this.apptTypebyMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.apptTypebyMonth.UseVisualStyleBackColor = true;
            this.apptTypebyMonth.Click += new System.EventHandler(this.apptTypebyMonth_Click);
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.addressTableAdapter = null;
            this.tableAdapterManager.appointmentTableAdapter = this.appointmentTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cityTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.UpdateOrder = C969___PA.U07xPrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // appointmentBindingNavigator
            // 
            this.appointmentBindingNavigator.AddNewItem = null;
            this.appointmentBindingNavigator.BindingSource = this.appointmentBindingSource;
            this.appointmentBindingNavigator.CountItem = null;
            this.appointmentBindingNavigator.DeleteItem = null;
            this.appointmentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.appointmentBindingNavigator.MoveFirstItem = null;
            this.appointmentBindingNavigator.MoveLastItem = null;
            this.appointmentBindingNavigator.MoveNextItem = null;
            this.appointmentBindingNavigator.MovePreviousItem = null;
            this.appointmentBindingNavigator.Name = "appointmentBindingNavigator";
            this.appointmentBindingNavigator.PositionItem = null;
            this.appointmentBindingNavigator.Size = new System.Drawing.Size(1096, 25);
            this.appointmentBindingNavigator.TabIndex = 1;
            this.appointmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchBox2);
            this.panel2.Controls.Add(this.searchButton2);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.apptsByCustomer);
            this.panel2.Controls.Add(this.apptTypebyMonth);
            this.panel2.Controls.Add(this.userScheduleReport);
            this.panel2.Controls.Add(this.deleteCust);
            this.panel2.Controls.Add(this.modCust);
            this.panel2.Controls.Add(this.addCust);
            this.panel2.Controls.Add(this.customers);
            this.panel2.Controls.Add(this.custs);
            this.panel2.Location = new System.Drawing.Point(0, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1105, 310);
            this.panel2.TabIndex = 10;
            // 
            // apptsByCustomer
            // 
            this.apptsByCustomer.Location = new System.Drawing.Point(80, 155);
            this.apptsByCustomer.Name = "apptsByCustomer";
            this.apptsByCustomer.Size = new System.Drawing.Size(165, 23);
            this.apptsByCustomer.TabIndex = 13;
            this.apptsByCustomer.Text = "Appts by Customer Report";
            this.apptsByCustomer.UseVisualStyleBackColor = true;
            this.apptsByCustomer.Click += new System.EventHandler(this.apptsByCustomer_Click);
            // 
            // deleteCust
            // 
            this.deleteCust.Location = new System.Drawing.Point(834, 253);
            this.deleteCust.Name = "deleteCust";
            this.deleteCust.Size = new System.Drawing.Size(75, 23);
            this.deleteCust.TabIndex = 10;
            this.deleteCust.Text = "Delete";
            this.deleteCust.UseVisualStyleBackColor = true;
            this.deleteCust.Click += new System.EventHandler(this.deleteCust_Click);
            // 
            // modCust
            // 
            this.modCust.Location = new System.Drawing.Point(753, 253);
            this.modCust.Name = "modCust";
            this.modCust.Size = new System.Drawing.Size(75, 23);
            this.modCust.TabIndex = 9;
            this.modCust.Text = "Modify";
            this.modCust.UseVisualStyleBackColor = true;
            this.modCust.Click += new System.EventHandler(this.modCust_Click);
            // 
            // addCust
            // 
            this.addCust.Location = new System.Drawing.Point(672, 253);
            this.addCust.Name = "addCust";
            this.addCust.Size = new System.Drawing.Size(75, 23);
            this.addCust.TabIndex = 8;
            this.addCust.Text = "Add";
            this.addCust.UseVisualStyleBackColor = true;
            this.addCust.Click += new System.EventHandler(this.addCust_Click);
            // 
            // customers
            // 
            this.customers.AutoSize = true;
            this.customers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers.Location = new System.Drawing.Point(390, 22);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(95, 20);
            this.customers.TabIndex = 1;
            this.customers.Text = "Customers";
            // 
            // custs
            // 
            this.custs.AllowUserToAddRows = false;
            this.custs.AllowUserToDeleteRows = false;
            this.custs.AutoGenerateColumns = false;
            this.custs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn19});
            this.custs.DataSource = this.customerBindingSource;
            this.custs.Location = new System.Drawing.Point(394, 45);
            this.custs.Name = "custs";
            this.custs.ReadOnly = true;
            this.custs.Size = new System.Drawing.Size(545, 202);
            this.custs.TabIndex = 0;
            this.custs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custs_CellClick);
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "customerId";
            this.dataGridViewTextBoxColumn16.HeaderText = "customerId";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "customerName";
            this.dataGridViewTextBoxColumn17.HeaderText = "customerName";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "addressId";
            this.dataGridViewTextBoxColumn18.HeaderText = "addressId";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "active";
            this.dataGridViewCheckBoxColumn1.HeaderText = "active";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "createDate";
            this.dataGridViewTextBoxColumn19.HeaderText = "createDate";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.u07xPrDataSet;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(1009, 273);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchButton1
            // 
            this.searchButton1.Location = new System.Drawing.Point(672, 28);
            this.searchButton1.Name = "searchButton1";
            this.searchButton1.Size = new System.Drawing.Size(75, 23);
            this.searchButton1.TabIndex = 11;
            this.searchButton1.Text = "Search";
            this.searchButton1.UseVisualStyleBackColor = true;
            this.searchButton1.Click += new System.EventHandler(this.searchButton1_Click);
            // 
            // searchButton2
            // 
            this.searchButton2.Location = new System.Drawing.Point(643, 16);
            this.searchButton2.Name = "searchButton2";
            this.searchButton2.Size = new System.Drawing.Size(75, 23);
            this.searchButton2.TabIndex = 12;
            this.searchButton2.Text = "Search";
            this.searchButton2.UseVisualStyleBackColor = true;
            this.searchButton2.Click += new System.EventHandler(this.searchButton2_Click);
            // 
            // searchBox1
            // 
            this.searchBox1.Location = new System.Drawing.Point(753, 29);
            this.searchBox1.Name = "searchBox1";
            this.searchBox1.Size = new System.Drawing.Size(219, 20);
            this.searchBox1.TabIndex = 12;
            this.searchBox1.Text = "Search Appointment Types";
            this.searchBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox1.TextChanged += new System.EventHandler(this.searchBox1_TextChanged);
            // 
            // searchBox2
            // 
            this.searchBox2.Location = new System.Drawing.Point(724, 16);
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.Size = new System.Drawing.Size(215, 20);
            this.searchBox2.TabIndex = 13;
            this.searchBox2.Text = "Search Customer Names";
            this.searchBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBox2.TextChanged += new System.EventHandler(this.searchBox2_TextChanged);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.appointmentBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "MainScreen";
            this.Text = "Main Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.u07xPrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingNavigator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label view;
        private System.Windows.Forms.RadioButton monthRadio;
        private System.Windows.Forms.RadioButton weekRadio;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.MonthCalendar calendar;
        private U07xPrDataSet u07xPrDataSet;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private U07xPrDataSetTableAdapters.appointmentTableAdapter appointmentTableAdapter;
        private U07xPrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator appointmentBindingNavigator;
        private System.Windows.Forms.Button deleteAppt;
        private System.Windows.Forms.Button modAppt;
        private System.Windows.Forms.Button addAppt;
        private System.Windows.Forms.Label apptLabel;
        private System.Windows.Forms.DataGridView appts;
        private U07xPrDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.Button deleteCust;
        private System.Windows.Forms.Button modCust;
        private System.Windows.Forms.Button addCust;
        private System.Windows.Forms.Label customers;
        private System.Windows.Forms.DataGridView custs;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RadioButton alltimeRB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.Button userScheduleReport;
        private System.Windows.Forms.Button apptTypebyMonth;
        private System.Windows.Forms.Button apptsByCustomer;
        private System.Windows.Forms.TextBox searchBox1;
        private System.Windows.Forms.Button searchButton1;
        private System.Windows.Forms.TextBox searchBox2;
        private System.Windows.Forms.Button searchButton2;
    }
}