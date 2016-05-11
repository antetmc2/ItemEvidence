namespace ItemEvidence.PresentationLayer
{
    partial class ItemList
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
            this.ItemList_DataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Exit = new System.Windows.Forms.Button();
            this.AddNewItem = new System.Windows.Forms.Button();
            this.DeleteSelectedItem = new System.Windows.Forms.Button();
            this.EditSelectedItem = new System.Windows.Forms.Button();
            this.DetailsItem = new System.Windows.Forms.Button();
            this.comboBox_ItemList = new System.Windows.Forms.ComboBox();
            this.label_Item = new System.Windows.Forms.Label();
            this.textBox_Item = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label_Type = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemList_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemList_DataGridView
            // 
            this.ItemList_DataGridView.AllowUserToAddRows = false;
            this.ItemList_DataGridView.AllowUserToDeleteRows = false;
            this.ItemList_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemList_DataGridView.AutoGenerateColumns = false;
            this.ItemList_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ItemList_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemList_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn});
            this.ItemList_DataGridView.DataSource = this.itemBindingSource;
            this.ItemList_DataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.ItemList_DataGridView.Location = new System.Drawing.Point(12, 43);
            this.ItemList_DataGridView.Name = "ItemList_DataGridView";
            this.ItemList_DataGridView.ReadOnly = true;
            this.ItemList_DataGridView.RowTemplate.Height = 24;
            this.ItemList_DataGridView.Size = new System.Drawing.Size(819, 375);
            this.ItemList_DataGridView.TabIndex = 0;
            this.ItemList_DataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemList_DataGridView_CellEnter);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 23F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 40F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 15F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.FillWeight = 22F;
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(ItemEvidence.Model.Item);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(731, 424);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 33);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddNewItem
            // 
            this.AddNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddNewItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNewItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddNewItem.Location = new System.Drawing.Point(12, 424);
            this.AddNewItem.Name = "AddNewItem";
            this.AddNewItem.Size = new System.Drawing.Size(100, 33);
            this.AddNewItem.TabIndex = 4;
            this.AddNewItem.Text = "Add";
            this.AddNewItem.UseVisualStyleBackColor = false;
            this.AddNewItem.Click += new System.EventHandler(this.AddNewItem_Click);
            // 
            // DeleteSelectedItem
            // 
            this.DeleteSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeleteSelectedItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteSelectedItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteSelectedItem.Location = new System.Drawing.Point(330, 424);
            this.DeleteSelectedItem.Name = "DeleteSelectedItem";
            this.DeleteSelectedItem.Size = new System.Drawing.Size(100, 33);
            this.DeleteSelectedItem.TabIndex = 7;
            this.DeleteSelectedItem.Text = "Delete";
            this.DeleteSelectedItem.UseVisualStyleBackColor = false;
            this.DeleteSelectedItem.Click += new System.EventHandler(this.DeleteSelectedItem_Click);
            // 
            // EditSelectedItem
            // 
            this.EditSelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EditSelectedItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EditSelectedItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditSelectedItem.Location = new System.Drawing.Point(118, 424);
            this.EditSelectedItem.Name = "EditSelectedItem";
            this.EditSelectedItem.Size = new System.Drawing.Size(100, 33);
            this.EditSelectedItem.TabIndex = 5;
            this.EditSelectedItem.Text = "Edit";
            this.EditSelectedItem.UseVisualStyleBackColor = false;
            this.EditSelectedItem.Click += new System.EventHandler(this.EditSelectedItem_Click);
            // 
            // DetailsItem
            // 
            this.DetailsItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DetailsItem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DetailsItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DetailsItem.Location = new System.Drawing.Point(224, 424);
            this.DetailsItem.Name = "DetailsItem";
            this.DetailsItem.Size = new System.Drawing.Size(100, 33);
            this.DetailsItem.TabIndex = 6;
            this.DetailsItem.Text = "Details";
            this.DetailsItem.UseVisualStyleBackColor = false;
            this.DetailsItem.Click += new System.EventHandler(this.DetailsItem_Click);
            // 
            // comboBox_ItemList
            // 
            this.comboBox_ItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox_ItemList.FormattingEnabled = true;
            this.comboBox_ItemList.Items.AddRange(new object[] {
            "All items",
            "Monitor",
            "Keyboard",
            "Mouse",
            "Headset",
            "Laptop",
            "Book"});
            this.comboBox_ItemList.Location = new System.Drawing.Point(437, 429);
            this.comboBox_ItemList.Name = "comboBox_ItemList";
            this.comboBox_ItemList.Size = new System.Drawing.Size(176, 24);
            this.comboBox_ItemList.TabIndex = 1;
            this.comboBox_ItemList.DropDownClosed += new System.EventHandler(this.comboBox_ItemList_DropDownClosed);
            // 
            // label_Item
            // 
            this.label_Item.AutoSize = true;
            this.label_Item.Location = new System.Drawing.Point(13, 13);
            this.label_Item.Name = "label_Item";
            this.label_Item.Size = new System.Drawing.Size(89, 17);
            this.label_Item.TabIndex = 4;
            this.label_Item.Text = "Current item:";
            // 
            // textBox_Item
            // 
            this.textBox_Item.Location = new System.Drawing.Point(108, 10);
            this.textBox_Item.Name = "textBox_Item";
            this.textBox_Item.ReadOnly = true;
            this.textBox_Item.Size = new System.Drawing.Size(261, 22);
            this.textBox_Item.TabIndex = 2;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(424, 11);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.ReadOnly = true;
            this.textBox_Type.Size = new System.Drawing.Size(261, 22);
            this.textBox_Type.TabIndex = 3;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(375, 13);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(44, 17);
            this.label_Type.TabIndex = 6;
            this.label_Type.Text = "Type:";
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(844, 469);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.textBox_Item);
            this.Controls.Add(this.label_Item);
            this.Controls.Add(this.comboBox_ItemList);
            this.Controls.Add(this.EditSelectedItem);
            this.Controls.Add(this.DetailsItem);
            this.Controls.Add(this.DeleteSelectedItem);
            this.Controls.Add(this.AddNewItem);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ItemList_DataGridView);
            this.MinimumSize = new System.Drawing.Size(750, 350);
            this.Name = "ItemList";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.ItemList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemList_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItemList_DataGridView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddNewItem;
        private System.Windows.Forms.Button DeleteSelectedItem;
        private System.Windows.Forms.Button EditSelectedItem;
        private System.Windows.Forms.Button DetailsItem;
        private System.Windows.Forms.ComboBox comboBox_ItemList;
        private System.Windows.Forms.Label label_Item;
        private System.Windows.Forms.TextBox textBox_Item;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}