namespace pharmacy_management_system
{
    partial class Main_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Drug_Table = new System.Windows.Forms.DataGridView();
            this.Drug_Code_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drug_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drug_Code_Label = new System.Windows.Forms.Label();
            this.Drug_Code_Entry = new System.Windows.Forms.TextBox();
            this.Drug_Name_Entry = new System.Windows.Forms.TextBox();
            this.Drug_Name_Label = new System.Windows.Forms.Label();
            this.Quantity_Label = new System.Windows.Forms.Label();
            this.Quantity_UP_DOWN = new System.Windows.Forms.NumericUpDown();
            this.Add_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Print_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.Drug_Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_UP_DOWN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Drug_Table
            // 
            this.Drug_Table.AllowUserToOrderColumns = true;
            this.Drug_Table.AllowUserToResizeColumns = false;
            this.Drug_Table.AllowUserToResizeRows = false;
            this.Drug_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Drug_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Drug_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Drug_Table.ColumnHeadersHeight = 35;
            this.Drug_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Drug_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drug_Code_Column,
            this.Drug_Name_Column,
            this.Price_Column,
            this.Quantity_Column,
            this.Total_Price_Column});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Drug_Table.DefaultCellStyle = dataGridViewCellStyle7;
            this.Drug_Table.EnableHeadersVisualStyles = false;
            this.Drug_Table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Drug_Table.Location = new System.Drawing.Point(12, 251);
            this.Drug_Table.Name = "Drug_Table";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Drug_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Drug_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Drug_Table.RowTemplate.Height = 24;
            this.Drug_Table.Size = new System.Drawing.Size(1127, 556);
            this.Drug_Table.TabIndex = 0;
            // 
            // Drug_Code_Column
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Drug_Code_Column.DefaultCellStyle = dataGridViewCellStyle2;
            this.Drug_Code_Column.HeaderText = "Drug Code";
            this.Drug_Code_Column.Name = "Drug_Code_Column";
            this.Drug_Code_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Drug_Name_Column
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Drug_Name_Column.DefaultCellStyle = dataGridViewCellStyle3;
            this.Drug_Name_Column.HeaderText = "Drug Name";
            this.Drug_Name_Column.Name = "Drug_Name_Column";
            this.Drug_Name_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price_Column
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Price_Column.DefaultCellStyle = dataGridViewCellStyle4;
            this.Price_Column.HeaderText = "Price";
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Quantity_Column
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity_Column.DefaultCellStyle = dataGridViewCellStyle5;
            this.Quantity_Column.HeaderText = "Quantity";
            this.Quantity_Column.Name = "Quantity_Column";
            this.Quantity_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Total_Price_Column
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Total_Price_Column.DefaultCellStyle = dataGridViewCellStyle6;
            this.Total_Price_Column.HeaderText = "Total Price";
            this.Total_Price_Column.Name = "Total_Price_Column";
            this.Total_Price_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Drug_Code_Label
            // 
            this.Drug_Code_Label.AutoSize = true;
            this.Drug_Code_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Drug_Code_Label.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drug_Code_Label.ForeColor = System.Drawing.Color.Black;
            this.Drug_Code_Label.Location = new System.Drawing.Point(22, 50);
            this.Drug_Code_Label.Name = "Drug_Code_Label";
            this.Drug_Code_Label.Size = new System.Drawing.Size(134, 35);
            this.Drug_Code_Label.TabIndex = 1;
            this.Drug_Code_Label.Text = "Drug Code";
            // 
            // Drug_Code_Entry
            // 
            this.Drug_Code_Entry.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drug_Code_Entry.Location = new System.Drawing.Point(192, 47);
            this.Drug_Code_Entry.Name = "Drug_Code_Entry";
            this.Drug_Code_Entry.Size = new System.Drawing.Size(301, 38);
            this.Drug_Code_Entry.TabIndex = 2;
            this.Drug_Code_Entry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Drug_Name_Entry
            // 
            this.Drug_Name_Entry.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drug_Name_Entry.Location = new System.Drawing.Point(192, 109);
            this.Drug_Name_Entry.Name = "Drug_Name_Entry";
            this.Drug_Name_Entry.Size = new System.Drawing.Size(301, 38);
            this.Drug_Name_Entry.TabIndex = 4;
            // 
            // Drug_Name_Label
            // 
            this.Drug_Name_Label.AutoSize = true;
            this.Drug_Name_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Drug_Name_Label.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drug_Name_Label.ForeColor = System.Drawing.Color.Black;
            this.Drug_Name_Label.Location = new System.Drawing.Point(22, 112);
            this.Drug_Name_Label.Name = "Drug_Name_Label";
            this.Drug_Name_Label.Size = new System.Drawing.Size(140, 35);
            this.Drug_Name_Label.TabIndex = 3;
            this.Drug_Name_Label.Text = "Drug Name";
            // 
            // Quantity_Label
            // 
            this.Quantity_Label.AutoSize = true;
            this.Quantity_Label.BackColor = System.Drawing.SystemColors.Control;
            this.Quantity_Label.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_Label.ForeColor = System.Drawing.Color.Black;
            this.Quantity_Label.Location = new System.Drawing.Point(22, 171);
            this.Quantity_Label.Name = "Quantity_Label";
            this.Quantity_Label.Size = new System.Drawing.Size(113, 35);
            this.Quantity_Label.TabIndex = 5;
            this.Quantity_Label.Text = "Quantity";
            // 
            // Quantity_UP_DOWN
            // 
            this.Quantity_UP_DOWN.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity_UP_DOWN.Location = new System.Drawing.Point(192, 172);
            this.Quantity_UP_DOWN.Name = "Quantity_UP_DOWN";
            this.Quantity_UP_DOWN.Size = new System.Drawing.Size(301, 38);
            this.Quantity_UP_DOWN.TabIndex = 6;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Add_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add_Button.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Image = ((System.Drawing.Image)(resources.GetObject("Add_Button.Image")));
            this.Add_Button.Location = new System.Drawing.Point(528, 18);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(106, 99);
            this.Add_Button.TabIndex = 7;
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.Edit_Button);
            this.groupBox1.Controls.Add(this.Add_Button);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 232);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Panel";
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Edit_Button.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Button.Image")));
            this.Edit_Button.Location = new System.Drawing.Point(528, 123);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(106, 99);
            this.Edit_Button.TabIndex = 8;
            this.Edit_Button.UseVisualStyleBackColor = false;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_Button.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Button.Image")));
            this.Delete_Button.Location = new System.Drawing.Point(53, 19);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(106, 99);
            this.Delete_Button.TabIndex = 10;
            this.Delete_Button.UseVisualStyleBackColor = false;
            // 
            // Print_Button
            // 
            this.Print_Button.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Print_Button.Image = ((System.Drawing.Image)(resources.GetObject("Print_Button.Image")));
            this.Print_Button.Location = new System.Drawing.Point(53, 124);
            this.Print_Button.Name = "Print_Button";
            this.Print_Button.Size = new System.Drawing.Size(106, 99);
            this.Print_Button.TabIndex = 11;
            this.Print_Button.UseVisualStyleBackColor = true;
            this.Print_Button.Click += new System.EventHandler(this.Print_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Print_Button);
            this.groupBox2.Controls.Add(this.Delete_Button);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(882, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 233);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete and Print Panel";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 819);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Quantity_UP_DOWN);
            this.Controls.Add(this.Quantity_Label);
            this.Controls.Add(this.Drug_Name_Entry);
            this.Controls.Add(this.Drug_Name_Label);
            this.Controls.Add(this.Drug_Code_Entry);
            this.Controls.Add(this.Drug_Code_Label);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Drug_Table);
            this.MaximumSize = new System.Drawing.Size(1169, 866);
            this.MinimumSize = new System.Drawing.Size(1169, 866);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Drug_Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity_UP_DOWN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Drug_Table;
        private System.Windows.Forms.Label Drug_Code_Label;
        private System.Windows.Forms.TextBox Drug_Code_Entry;
        private System.Windows.Forms.TextBox Drug_Name_Entry;
        private System.Windows.Forms.Label Drug_Name_Label;
        private System.Windows.Forms.Label Quantity_Label;
        private System.Windows.Forms.NumericUpDown Quantity_UP_DOWN;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Print_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drug_Code_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drug_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Price_Column;
    }
}