namespace ItemEvidence.PresentationLayer
{
    partial class EmployeeList
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
            this.Exit = new System.Windows.Forms.Button();
            this.EmployeesList_DataGridView = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddNewEmployee = new System.Windows.Forms.Button();
            this.DeleteSelectedEmployee = new System.Windows.Forms.Button();
            this.EditSelectedEmployee = new System.Windows.Forms.Button();
            this.btn_Items = new System.Windows.Forms.Button();
            this.textBox_Employee = new System.Windows.Forms.TextBox();
            this.label_Employee = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesList_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(546, 357);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 33);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // EmployeesList_DataGridView
            // 
            this.EmployeesList_DataGridView.AllowUserToAddRows = false;
            this.EmployeesList_DataGridView.AllowUserToDeleteRows = false;
            this.EmployeesList_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeesList_DataGridView.AutoGenerateColumns = false;
            this.EmployeesList_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.EmployeesList_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesList_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.EmployeesList_DataGridView.DataSource = this.employeeBindingSource;
            this.EmployeesList_DataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.EmployeesList_DataGridView.Location = new System.Drawing.Point(12, 51);
            this.EmployeesList_DataGridView.Name = "EmployeesList_DataGridView";
            this.EmployeesList_DataGridView.ReadOnly = true;
            this.EmployeesList_DataGridView.RowTemplate.Height = 24;
            this.EmployeesList_DataGridView.Size = new System.Drawing.Size(634, 300);
            this.EmployeesList_DataGridView.TabIndex = 0;
            this.EmployeesList_DataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeesList_DataGridView_CellEnter);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(ItemEvidence.Model.Employee);
            // 
            // AddNewEmployee
            // 
            this.AddNewEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNewEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewEmployee.Location = new System.Drawing.Point(12, 357);
            this.AddNewEmployee.Name = "AddNewEmployee";
            this.AddNewEmployee.Size = new System.Drawing.Size(100, 33);
            this.AddNewEmployee.TabIndex = 1;
            this.AddNewEmployee.Text = "Add";
            this.AddNewEmployee.UseVisualStyleBackColor = false;
            this.AddNewEmployee.Click += new System.EventHandler(this.AddNewEmployee_Click);
            // 
            // DeleteSelectedEmployee
            // 
            this.DeleteSelectedEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSelectedEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteSelectedEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteSelectedEmployee.Location = new System.Drawing.Point(330, 357);
            this.DeleteSelectedEmployee.Name = "DeleteSelectedEmployee";
            this.DeleteSelectedEmployee.Size = new System.Drawing.Size(100, 33);
            this.DeleteSelectedEmployee.TabIndex = 4;
            this.DeleteSelectedEmployee.Text = "Delete";
            this.DeleteSelectedEmployee.UseVisualStyleBackColor = false;
            this.DeleteSelectedEmployee.Click += new System.EventHandler(this.DeleteSelectedEmployee_Click);
            // 
            // EditSelectedEmployee
            // 
            this.EditSelectedEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditSelectedEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditSelectedEmployee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditSelectedEmployee.Location = new System.Drawing.Point(118, 357);
            this.EditSelectedEmployee.Name = "EditSelectedEmployee";
            this.EditSelectedEmployee.Size = new System.Drawing.Size(100, 33);
            this.EditSelectedEmployee.TabIndex = 2;
            this.EditSelectedEmployee.Text = "Edit";
            this.EditSelectedEmployee.UseVisualStyleBackColor = false;
            this.EditSelectedEmployee.Click += new System.EventHandler(this.EditSelectedEmployee_Click);
            // 
            // btn_Items
            // 
            this.btn_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Items.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Items.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Items.Location = new System.Drawing.Point(224, 357);
            this.btn_Items.Name = "btn_Items";
            this.btn_Items.Size = new System.Drawing.Size(100, 33);
            this.btn_Items.TabIndex = 3;
            this.btn_Items.Text = "Items";
            this.btn_Items.UseVisualStyleBackColor = false;
            this.btn_Items.Click += new System.EventHandler(this.btn_Items_Click);
            // 
            // textBox_Employee
            // 
            this.textBox_Employee.Location = new System.Drawing.Point(128, 12);
            this.textBox_Employee.Name = "textBox_Employee";
            this.textBox_Employee.ReadOnly = true;
            this.textBox_Employee.Size = new System.Drawing.Size(518, 22);
            this.textBox_Employee.TabIndex = 7;
            // 
            // label_Employee
            // 
            this.label_Employee.AutoSize = true;
            this.label_Employee.Location = new System.Drawing.Point(7, 15);
            this.label_Employee.Name = "label_Employee";
            this.label_Employee.Size = new System.Drawing.Size(124, 17);
            this.label_Employee.TabIndex = 9;
            this.label_Employee.Text = "Current employee:";
            // 
            // EmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(658, 396);
            this.Controls.Add(this.textBox_Employee);
            this.Controls.Add(this.label_Employee);
            this.Controls.Add(this.EditSelectedEmployee);
            this.Controls.Add(this.btn_Items);
            this.Controls.Add(this.DeleteSelectedEmployee);
            this.Controls.Add(this.AddNewEmployee);
            this.Controls.Add(this.EmployeesList_DataGridView);
            this.Controls.Add(this.Exit);
            this.MinimumSize = new System.Drawing.Size(565, 350);
            this.Name = "EmployeeList";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesList_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView EmployeesList_DataGridView;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddNewEmployee;
        private System.Windows.Forms.Button DeleteSelectedEmployee;
        private System.Windows.Forms.Button EditSelectedEmployee;
        private System.Windows.Forms.Button btn_Items;
        private System.Windows.Forms.TextBox textBox_Employee;
        private System.Windows.Forms.Label label_Employee;
    }
}