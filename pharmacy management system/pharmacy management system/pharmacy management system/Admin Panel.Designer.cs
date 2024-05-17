namespace pharmacy_management_system
{
    partial class Admin_Panel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Users_Panel_Group = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FN_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LN_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Drug_Table = new System.Windows.Forms.DataGridView();
            this.Drug_Code_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drug_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Users_Panel_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Drug_Table)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Users_Panel_Group
            // 
            this.Users_Panel_Group.Controls.Add(this.dataGridView1);
            this.Users_Panel_Group.Controls.Add(this.groupBox2);
            this.Users_Panel_Group.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users_Panel_Group.Location = new System.Drawing.Point(12, 12);
            this.Users_Panel_Group.Name = "Users_Panel_Group";
            this.Users_Panel_Group.Size = new System.Drawing.Size(1189, 421);
            this.Users_Panel_Group.TabIndex = 0;
            this.Users_Panel_Group.TabStop = false;
            this.Users_Panel_Group.Text = "Users Panel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FN_Column,
            this.LN_Column,
            this.Username_Column,
            this.ID_Column,
            this.Address_Column,
            this.Email_Column,
            this.Phone_Column,
            this.Password_Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(176, 28);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 388);
            this.dataGridView1.TabIndex = 11;
            // 
            // FN_Column
            // 
            this.FN_Column.HeaderText = "FN";
            this.FN_Column.Name = "FN_Column";
            // 
            // LN_Column
            // 
            this.LN_Column.HeaderText = "LN";
            this.LN_Column.Name = "LN_Column";
            // 
            // Username_Column
            // 
            this.Username_Column.HeaderText = "Username";
            this.Username_Column.Name = "Username_Column";
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            // 
            // Address_Column
            // 
            this.Address_Column.HeaderText = "Address";
            this.Address_Column.Name = "Address_Column";
            // 
            // Email_Column
            // 
            this.Email_Column.HeaderText = "Email";
            this.Email_Column.Name = "Email_Column";
            // 
            // Phone_Column
            // 
            this.Phone_Column.HeaderText = "Phone";
            this.Phone_Column.Name = "Phone_Column";
            // 
            // Password_Column
            // 
            this.Password_Column.HeaderText = "Password";
            this.Password_Column.Name = "Password_Column";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.Delete_Button);
            this.groupBox2.Controls.Add(this.Edit_Button);
            this.groupBox2.Controls.Add(this.Add_Button);
            this.groupBox2.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(18, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 372);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control Panel";
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_Button.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Button.Image")));
            this.Delete_Button.Location = new System.Drawing.Point(15, 258);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(106, 99);
            this.Delete_Button.TabIndex = 11;
            this.Delete_Button.UseVisualStyleBackColor = false;
            // 
            // Edit_Button
            // 
            this.Edit_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Edit_Button.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Button.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Button.Image")));
            this.Edit_Button.Location = new System.Drawing.Point(15, 149);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(106, 99);
            this.Edit_Button.TabIndex = 8;
            this.Edit_Button.UseVisualStyleBackColor = false;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Add_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Add_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Add_Button.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Button.Image = ((System.Drawing.Image)(resources.GetObject("Add_Button.Image")));
            this.Add_Button.Location = new System.Drawing.Point(15, 44);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(106, 99);
            this.Add_Button.TabIndex = 7;
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Drug_Table);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 439);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1189, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drugs Panel";
            // 
            // Drug_Table
            // 
            this.Drug_Table.AllowUserToOrderColumns = true;
            this.Drug_Table.AllowUserToResizeColumns = false;
            this.Drug_Table.AllowUserToResizeRows = false;
            this.Drug_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Drug_Table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Drug_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Drug_Table.ColumnHeadersHeight = 35;
            this.Drug_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Drug_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Drug_Code_Column,
            this.Drug_Name_Column,
            this.Price_Column});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Drug_Table.DefaultCellStyle = dataGridViewCellStyle8;
            this.Drug_Table.EnableHeadersVisualStyles = false;
            this.Drug_Table.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Drug_Table.Location = new System.Drawing.Point(176, 27);
            this.Drug_Table.Name = "Drug_Table";
            this.Drug_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Drug_Table.RowTemplate.Height = 24;
            this.Drug_Table.Size = new System.Drawing.Size(1007, 366);
            this.Drug_Table.TabIndex = 14;
            // 
            // Drug_Code_Column
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Drug_Code_Column.DefaultCellStyle = dataGridViewCellStyle5;
            this.Drug_Code_Column.HeaderText = "Drug Code";
            this.Drug_Code_Column.Name = "Drug_Code_Column";
            this.Drug_Code_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Drug_Name_Column
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Drug_Name_Column.DefaultCellStyle = dataGridViewCellStyle6;
            this.Drug_Name_Column.HeaderText = "Drug Name";
            this.Drug_Name_Column.Name = "Drug_Name_Column";
            this.Drug_Name_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price_Column
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Price_Column.DefaultCellStyle = dataGridViewCellStyle7;
            this.Price_Column.HeaderText = "Price";
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(18, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 370);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control Panel";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(15, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 99);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(15, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 99);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(15, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 99);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 880);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Users_Panel_Group);
            this.MaximumSize = new System.Drawing.Size(1231, 927);
            this.MinimumSize = new System.Drawing.Size(1231, 927);
            this.Name = "Admin_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Admin Panel";
            this.Users_Panel_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Drug_Table)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Users_Panel_Group;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.DataGridViewTextBoxColumn FN_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn LN_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password_Column;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Drug_Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drug_Code_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drug_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.Button button3;
    }
}