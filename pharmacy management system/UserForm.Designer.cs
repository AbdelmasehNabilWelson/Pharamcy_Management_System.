namespace pharmacy_management_system
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.drugNameTextBox = new System.Windows.Forms.TextBox();
            this.Drug_Name_label = new System.Windows.Forms.Label();
            this.addSaleButton = new System.Windows.Forms.Button();
            this.drugCodeLabel = new System.Windows.Forms.Label();
            this.drugCodeText = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityValue = new System.Windows.Forms.NumericUpDown();
            this.userDrugSalesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.userDrugSalesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userDrugSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDrugSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharamcyDataSet = new pharmacy_management_system.PharamcyDataSet();
            this.userDrugSalesTableAdapter = new pharmacy_management_system.PharamcyDataSetTableAdapters.UserDrugSalesTableAdapter();
            this.tableAdapterManager = new pharmacy_management_system.PharamcyDataSetTableAdapters.TableAdapterManager();
            this.drugsIdAndNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugsIdAndNameTableAdapter = new pharmacy_management_system.PharamcyDataSetTableAdapters.drugsIdAndNameTableAdapter();
            this.drugsIdAndNameDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quantityValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDrugSalesBindingNavigator)).BeginInit();
            this.userDrugSalesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDrugSalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDrugSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharamcyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsIdAndNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsIdAndNameDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // drugNameTextBox
            // 
            this.drugNameTextBox.Location = new System.Drawing.Point(301, 74);
            this.drugNameTextBox.Name = "drugNameTextBox";
            this.drugNameTextBox.Size = new System.Drawing.Size(263, 22);
            this.drugNameTextBox.TabIndex = 0;
            // 
            // Drug_Name_label
            // 
            this.Drug_Name_label.AutoSize = true;
            this.Drug_Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drug_Name_label.Location = new System.Drawing.Point(144, 67);
            this.Drug_Name_label.Name = "Drug_Name_label";
            this.Drug_Name_label.Size = new System.Drawing.Size(142, 29);
            this.Drug_Name_label.TabIndex = 1;
            this.Drug_Name_label.Text = "Drug Name:";
            // 
            // addSaleButton
            // 
            this.addSaleButton.Location = new System.Drawing.Point(301, 253);
            this.addSaleButton.Name = "addSaleButton";
            this.addSaleButton.Size = new System.Drawing.Size(91, 48);
            this.addSaleButton.TabIndex = 2;
            this.addSaleButton.Text = "Add Sale";
            this.addSaleButton.UseVisualStyleBackColor = true;
            this.addSaleButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // drugCodeLabel
            // 
            this.drugCodeLabel.AutoSize = true;
            this.drugCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drugCodeLabel.Location = new System.Drawing.Point(144, 133);
            this.drugCodeLabel.Name = "drugCodeLabel";
            this.drugCodeLabel.Size = new System.Drawing.Size(136, 29);
            this.drugCodeLabel.TabIndex = 3;
            this.drugCodeLabel.Text = "Drug Code:";
            // 
            // drugCodeText
            // 
            this.drugCodeText.Location = new System.Drawing.Point(301, 133);
            this.drugCodeText.Name = "drugCodeText";
            this.drugCodeText.Size = new System.Drawing.Size(263, 22);
            this.drugCodeText.TabIndex = 4;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(144, 192);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(106, 29);
            this.quantityLabel.TabIndex = 5;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityValue
            // 
            this.quantityValue.Location = new System.Drawing.Point(301, 192);
            this.quantityValue.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.quantityValue.Name = "quantityValue";
            this.quantityValue.Size = new System.Drawing.Size(263, 22);
            this.quantityValue.TabIndex = 6;
            this.quantityValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // userDrugSalesBindingNavigator
            // 
            this.userDrugSalesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userDrugSalesBindingNavigator.BindingSource = this.userDrugSalesBindingSource;
            this.userDrugSalesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userDrugSalesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userDrugSalesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.userDrugSalesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userDrugSalesBindingNavigatorSaveItem});
            this.userDrugSalesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userDrugSalesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userDrugSalesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userDrugSalesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userDrugSalesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userDrugSalesBindingNavigator.Name = "userDrugSalesBindingNavigator";
            this.userDrugSalesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userDrugSalesBindingNavigator.Size = new System.Drawing.Size(1261, 27);
            this.userDrugSalesBindingNavigator.TabIndex = 7;
            this.userDrugSalesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // userDrugSalesBindingNavigatorSaveItem
            // 
            this.userDrugSalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userDrugSalesBindingNavigatorSaveItem.Enabled = false;
            this.userDrugSalesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userDrugSalesBindingNavigatorSaveItem.Image")));
            this.userDrugSalesBindingNavigatorSaveItem.Name = "userDrugSalesBindingNavigatorSaveItem";
            this.userDrugSalesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.userDrugSalesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // userDrugSalesDataGridView
            // 
            this.userDrugSalesDataGridView.AutoGenerateColumns = false;
            this.userDrugSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDrugSalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.userDrugSalesDataGridView.DataSource = this.userDrugSalesBindingSource;
            this.userDrugSalesDataGridView.Location = new System.Drawing.Point(149, 307);
            this.userDrugSalesDataGridView.Name = "userDrugSalesDataGridView";
            this.userDrugSalesDataGridView.RowHeadersWidth = 51;
            this.userDrugSalesDataGridView.RowTemplate.Height = 24;
            this.userDrugSalesDataGridView.Size = new System.Drawing.Size(798, 220);
            this.userDrugSalesDataGridView.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "user_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "user_name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "drug_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "drug_name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sale_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "sale_date";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // userDrugSalesBindingSource
            // 
            this.userDrugSalesBindingSource.DataMember = "UserDrugSales";
            this.userDrugSalesBindingSource.DataSource = this.pharamcyDataSet;
            // 
            // pharamcyDataSet
            // 
            this.pharamcyDataSet.DataSetName = "PharamcyDataSet";
            this.pharamcyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDrugSalesTableAdapter
            // 
            this.userDrugSalesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.drugsTableAdapter = null;
            this.tableAdapterManager.salesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = pharmacy_management_system.PharamcyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // drugsIdAndNameBindingSource
            // 
            this.drugsIdAndNameBindingSource.DataMember = "drugsIdAndName";
            this.drugsIdAndNameBindingSource.DataSource = this.pharamcyDataSet;
            // 
            // drugsIdAndNameTableAdapter
            // 
            this.drugsIdAndNameTableAdapter.ClearBeforeFill = true;
            // 
            // drugsIdAndNameDataGridView
            // 
            this.drugsIdAndNameDataGridView.AutoGenerateColumns = false;
            this.drugsIdAndNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drugsIdAndNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.drugsIdAndNameDataGridView.DataSource = this.drugsIdAndNameBindingSource;
            this.drugsIdAndNameDataGridView.Location = new System.Drawing.Point(635, 30);
            this.drugsIdAndNameDataGridView.Name = "drugsIdAndNameDataGridView";
            this.drugsIdAndNameDataGridView.RowHeadersWidth = 51;
            this.drugsIdAndNameDataGridView.RowTemplate.Height = 24;
            this.drugsIdAndNameDataGridView.Size = new System.Drawing.Size(472, 220);
            this.drugsIdAndNameDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "drug_id";
            this.dataGridViewTextBoxColumn5.HeaderText = "drug_id";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "drug_name";
            this.dataGridViewTextBoxColumn6.HeaderText = "drug_name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 593);
            this.Controls.Add(this.drugsIdAndNameDataGridView);
            this.Controls.Add(this.userDrugSalesDataGridView);
            this.Controls.Add(this.userDrugSalesBindingNavigator);
            this.Controls.Add(this.quantityValue);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.drugCodeText);
            this.Controls.Add(this.drugCodeLabel);
            this.Controls.Add(this.addSaleButton);
            this.Controls.Add(this.Drug_Name_label);
            this.Controls.Add(this.drugNameTextBox);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantityValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDrugSalesBindingNavigator)).EndInit();
            this.userDrugSalesBindingNavigator.ResumeLayout(false);
            this.userDrugSalesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDrugSalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDrugSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharamcyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsIdAndNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugsIdAndNameDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox drugNameTextBox;
        private System.Windows.Forms.Label Drug_Name_label;
        private System.Windows.Forms.Button addSaleButton;
        private System.Windows.Forms.Label drugCodeLabel;
        private System.Windows.Forms.TextBox drugCodeText;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityValue;
        private PharamcyDataSet pharamcyDataSet;
        private System.Windows.Forms.BindingSource userDrugSalesBindingSource;
        private PharamcyDataSetTableAdapters.UserDrugSalesTableAdapter userDrugSalesTableAdapter;
        private PharamcyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userDrugSalesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userDrugSalesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView userDrugSalesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource drugsIdAndNameBindingSource;
        private PharamcyDataSetTableAdapters.drugsIdAndNameTableAdapter drugsIdAndNameTableAdapter;
        private System.Windows.Forms.DataGridView drugsIdAndNameDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}