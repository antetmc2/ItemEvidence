namespace ItemEvidence.PresentationLayer
{
    partial class ItemDetails
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
            this.ComboBox_Employee = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.btn_Assign = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ItemType = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDown_Employee = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.dataGridView_AssignedItems = new System.Windows.Forms.DataGridView();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Employee)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssignedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBox_Employee
            // 
            this.ComboBox_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBox_Employee.FormattingEnabled = true;
            this.ComboBox_Employee.Location = new System.Drawing.Point(3, 10);
            this.ComboBox_Employee.Name = "ComboBox_Employee";
            this.ComboBox_Employee.Size = new System.Drawing.Size(193, 24);
            this.ComboBox_Employee.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Item type:";
            // 
            // textBox_Author
            // 
            this.textBox_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Author.Location = new System.Drawing.Point(92, 218);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.ReadOnly = true;
            this.textBox_Author.Size = new System.Drawing.Size(409, 22);
            this.textBox_Author.TabIndex = 5;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(37, 68);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(49, 17);
            this.labelFirstName.TabIndex = 5;
            this.labelFirstName.Text = "Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(3, 119);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(83, 17);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Description:";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Description.Location = new System.Drawing.Point(92, 116);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ReadOnly = true;
            this.textBox_Description.Size = new System.Drawing.Size(409, 22);
            this.textBox_Description.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Name.Location = new System.Drawing.Point(92, 65);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(409, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // btn_Assign
            // 
            this.btn_Assign.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Assign.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Assign.Location = new System.Drawing.Point(120, 4);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(75, 25);
            this.btn_Assign.TabIndex = 8;
            this.btn_Assign.Text = "Assign";
            this.btn_Assign.UseVisualStyleBackColor = false;
            this.btn_Assign.Click += new System.EventHandler(this.btn_Assign_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Exit.Location = new System.Drawing.Point(201, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 25);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Author:";
            // 
            // textBox_ItemType
            // 
            this.textBox_ItemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ItemType.Location = new System.Drawing.Point(92, 14);
            this.textBox_ItemType.Name = "textBox_ItemType";
            this.textBox_ItemType.ReadOnly = true;
            this.textBox_ItemType.Size = new System.Drawing.Size(409, 22);
            this.textBox_ItemType.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.45815F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.54185F));
            this.tableLayoutPanel2.Controls.Add(this.btn_Assign, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_Exit, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(92, 309);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(409, 33);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.86878F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.13122F));
            this.tableLayoutPanel3.Controls.Add(this.ComboBox_Employee, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.numericUpDown_Employee, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(92, 258);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(409, 45);
            this.tableLayoutPanel3.TabIndex = 15;
            // 
            // numericUpDown_Employee
            // 
            this.numericUpDown_Employee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Employee.Location = new System.Drawing.Point(202, 11);
            this.numericUpDown_Employee.Name = "numericUpDown_Employee";
            this.numericUpDown_Employee.Size = new System.Drawing.Size(204, 22);
            this.numericUpDown_Employee.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Employee:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.71654F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.28346F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Author, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLastName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Description, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox_ItemType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Quantity, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 345);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Quantity.Location = new System.Drawing.Point(92, 167);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.ReadOnly = true;
            this.textBox_Quantity.Size = new System.Drawing.Size(409, 22);
            this.textBox_Quantity.TabIndex = 16;
            // 
            // dataGridView_AssignedItems
            // 
            this.dataGridView_AssignedItems.AllowUserToAddRows = false;
            this.dataGridView_AssignedItems.AllowUserToDeleteRows = false;
            this.dataGridView_AssignedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_AssignedItems.AutoGenerateColumns = false;
            this.dataGridView_AssignedItems.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_AssignedItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_AssignedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AssignedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.numberOfItemsDataGridViewTextBoxColumn});
            this.dataGridView_AssignedItems.DataSource = this.employeeItemsBindingSource;
            this.dataGridView_AssignedItems.Location = new System.Drawing.Point(533, 12);
            this.dataGridView_AssignedItems.Name = "dataGridView_AssignedItems";
            this.dataGridView_AssignedItems.ReadOnly = true;
            this.dataGridView_AssignedItems.RowTemplate.Height = 24;
            this.dataGridView_AssignedItems.Size = new System.Drawing.Size(330, 345);
            this.dataGridView_AssignedItems.TabIndex = 18;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfItemsDataGridViewTextBoxColumn
            // 
            this.numberOfItemsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfItemsDataGridViewTextBoxColumn.DataPropertyName = "NumberOfItems";
            this.numberOfItemsDataGridViewTextBoxColumn.FillWeight = 25F;
            this.numberOfItemsDataGridViewTextBoxColumn.HeaderText = "#";
            this.numberOfItemsDataGridViewTextBoxColumn.Name = "numberOfItemsDataGridViewTextBoxColumn";
            this.numberOfItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeItemsBindingSource
            // 
            this.employeeItemsBindingSource.DataSource = typeof(ItemEvidence.Model.EmployeeItems);
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(869, 369);
            this.Controls.Add(this.dataGridView_AssignedItems);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ItemDetails";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.ItemDetails_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Employee)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AssignedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Assign;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox_ItemType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBox_Employee;
        private System.Windows.Forms.NumericUpDown numericUpDown_Employee;
        private System.Windows.Forms.DataGridView dataGridView_AssignedItems;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.BindingSource employeeItemsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    }
}