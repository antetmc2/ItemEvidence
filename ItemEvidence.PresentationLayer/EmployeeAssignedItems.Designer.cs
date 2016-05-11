namespace ItemEvidence.PresentationLayer
{
    partial class EmployeeAssignedItems
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_TakeAll = new System.Windows.Forms.Button();
            this.btn_Take = new System.Windows.Forms.Button();
            this.numericUpDown_Take = new System.Windows.Forms.NumericUpDown();
            this.btn_AssignMore = new System.Windows.Forms.Button();
            this.numericUpDown_Assign = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_Items = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox_NumberOfItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Take)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Assign)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_LastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_FirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(421, 74);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_LastName.Location = new System.Drawing.Point(87, 44);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.ReadOnly = true;
            this.textBox_LastName.Size = new System.Drawing.Size(331, 22);
            this.textBox_LastName.TabIndex = 9;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_FirstName.Location = new System.Drawing.Point(87, 7);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.ReadOnly = true;
            this.textBox_FirstName.Size = new System.Drawing.Size(331, 22);
            this.textBox_FirstName.TabIndex = 8;
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(3, 47);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(78, 17);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(3, 10);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(78, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First name:";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Exit.Location = new System.Drawing.Point(12, 312);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 29);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_TakeAll
            // 
            this.btn_TakeAll.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_TakeAll.Location = new System.Drawing.Point(12, 269);
            this.btn_TakeAll.Name = "btn_TakeAll";
            this.btn_TakeAll.Size = new System.Drawing.Size(111, 29);
            this.btn_TakeAll.TabIndex = 5;
            this.btn_TakeAll.Text = "Take all";
            this.btn_TakeAll.UseVisualStyleBackColor = false;
            this.btn_TakeAll.Click += new System.EventHandler(this.btn_TakeAll_Click);
            // 
            // btn_Take
            // 
            this.btn_Take.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Take.Location = new System.Drawing.Point(12, 234);
            this.btn_Take.Name = "btn_Take";
            this.btn_Take.Size = new System.Drawing.Size(111, 29);
            this.btn_Take.TabIndex = 4;
            this.btn_Take.Text = "Take";
            this.btn_Take.UseVisualStyleBackColor = false;
            this.btn_Take.Click += new System.EventHandler(this.btn_Take_Click);
            // 
            // numericUpDown_Take
            // 
            this.numericUpDown_Take.Location = new System.Drawing.Point(129, 238);
            this.numericUpDown_Take.Name = "numericUpDown_Take";
            this.numericUpDown_Take.Size = new System.Drawing.Size(301, 22);
            this.numericUpDown_Take.TabIndex = 3;
            // 
            // btn_AssignMore
            // 
            this.btn_AssignMore.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AssignMore.Location = new System.Drawing.Point(12, 199);
            this.btn_AssignMore.Name = "btn_AssignMore";
            this.btn_AssignMore.Size = new System.Drawing.Size(111, 29);
            this.btn_AssignMore.TabIndex = 2;
            this.btn_AssignMore.Text = "Assign more";
            this.btn_AssignMore.UseVisualStyleBackColor = false;
            this.btn_AssignMore.Click += new System.EventHandler(this.btn_AssignMore_Click);
            // 
            // numericUpDown_Assign
            // 
            this.numericUpDown_Assign.Location = new System.Drawing.Point(129, 203);
            this.numericUpDown_Assign.Name = "numericUpDown_Assign";
            this.numericUpDown_Assign.Size = new System.Drawing.Size(301, 22);
            this.numericUpDown_Assign.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEE:";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(ItemEvidence.Model.Item);
            // 
            // dataGridView_Items
            // 
            this.dataGridView_Items.AllowUserToAddRows = false;
            this.dataGridView_Items.AllowUserToDeleteRows = false;
            this.dataGridView_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Items.AutoGenerateColumns = false;
            this.dataGridView_Items.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn});
            this.dataGridView_Items.DataSource = this.itemBindingSource;
            this.dataGridView_Items.Location = new System.Drawing.Point(441, 12);
            this.dataGridView_Items.Name = "dataGridView_Items";
            this.dataGridView_Items.ReadOnly = true;
            this.dataGridView_Items.RowTemplate.Height = 24;
            this.dataGridView_Items.Size = new System.Drawing.Size(431, 329);
            this.dataGridView_Items.TabIndex = 0;
            this.dataGridView_Items.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Items_CellEnter);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 30F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Left";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.FillWeight = 80F;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox_NumberOfItem
            // 
            this.textBox_NumberOfItem.Location = new System.Drawing.Point(197, 160);
            this.textBox_NumberOfItem.Name = "textBox_NumberOfItem";
            this.textBox_NumberOfItem.ReadOnly = true;
            this.textBox_NumberOfItem.Size = new System.Drawing.Size(233, 22);
            this.textBox_NumberOfItem.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of assigned items:";
            // 
            // EmployeeAssignedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(882, 353);
            this.Controls.Add(this.textBox_NumberOfItem);
            this.Controls.Add(this.numericUpDown_Assign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Take);
            this.Controls.Add(this.btn_AssignMore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Take);
            this.Controls.Add(this.btn_TakeAll);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dataGridView_Items);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(890, 390);
            this.Name = "EmployeeAssignedItems";
            this.Text = "Assigned Items";
            this.Load += new System.EventHandler(this.EmployeeAssignedItems_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Take)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Assign)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_TakeAll;
        private System.Windows.Forms.Button btn_Take;
        private System.Windows.Forms.NumericUpDown numericUpDown_Take;
        private System.Windows.Forms.Button btn_AssignMore;
        private System.Windows.Forms.NumericUpDown numericUpDown_Assign;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Items;
        private System.Windows.Forms.TextBox textBox_NumberOfItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    }
}