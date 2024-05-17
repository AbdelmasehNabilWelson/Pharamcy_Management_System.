namespace pharmacy_management_system
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.UserName_Label = new System.Windows.Forms.Label();
            this.ID_Lable = new System.Windows.Forms.Label();
            this.Password_Lable = new System.Windows.Forms.Label();
            this.UserName_Entry = new System.Windows.Forms.TextBox();
            this.ID_Entry = new System.Windows.Forms.TextBox();
            this.Password_Entry = new System.Windows.Forms.TextBox();
            this.Login_Button = new System.Windows.Forms.Button();
            this.RegisterForm_Button = new System.Windows.Forms.Button();
            this.Visable_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName_Label
            // 
            this.UserName_Label.AutoSize = true;
            this.UserName_Label.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Label.Location = new System.Drawing.Point(12, 9);
            this.UserName_Label.Name = "UserName_Label";
            this.UserName_Label.Size = new System.Drawing.Size(132, 35);
            this.UserName_Label.TabIndex = 0;
            this.UserName_Label.Text = "UserName";
            // 
            // ID_Lable
            // 
            this.ID_Lable.AutoSize = true;
            this.ID_Lable.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Lable.Location = new System.Drawing.Point(12, 60);
            this.ID_Lable.Name = "ID_Lable";
            this.ID_Lable.Size = new System.Drawing.Size(38, 35);
            this.ID_Lable.TabIndex = 1;
            this.ID_Lable.Text = "ID";
            // 
            // Password_Lable
            // 
            this.Password_Lable.AutoSize = true;
            this.Password_Lable.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Lable.Location = new System.Drawing.Point(12, 112);
            this.Password_Lable.Name = "Password_Lable";
            this.Password_Lable.Size = new System.Drawing.Size(127, 35);
            this.Password_Lable.TabIndex = 2;
            this.Password_Lable.Text = "Password";
            // 
            // UserName_Entry
            // 
            this.UserName_Entry.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_Entry.Location = new System.Drawing.Point(161, 9);
            this.UserName_Entry.Name = "UserName_Entry";
            this.UserName_Entry.Size = new System.Drawing.Size(323, 38);
            this.UserName_Entry.TabIndex = 3;
            // 
            // ID_Entry
            // 
            this.ID_Entry.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Entry.Location = new System.Drawing.Point(161, 60);
            this.ID_Entry.Name = "ID_Entry";
            this.ID_Entry.Size = new System.Drawing.Size(323, 38);
            this.ID_Entry.TabIndex = 4;
            // 
            // Password_Entry
            // 
            this.Password_Entry.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Entry.Location = new System.Drawing.Point(161, 112);
            this.Password_Entry.Name = "Password_Entry";
            this.Password_Entry.PasswordChar = '*';
            this.Password_Entry.Size = new System.Drawing.Size(323, 38);
            this.Password_Entry.TabIndex = 5;
            this.Password_Entry.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Login_Button
            // 
            this.Login_Button.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Button.Location = new System.Drawing.Point(76, 156);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(128, 43);
            this.Login_Button.TabIndex = 6;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            // 
            // RegisterForm_Button
            // 
            this.RegisterForm_Button.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterForm_Button.Location = new System.Drawing.Point(222, 156);
            this.RegisterForm_Button.Name = "RegisterForm_Button";
            this.RegisterForm_Button.Size = new System.Drawing.Size(194, 43);
            this.RegisterForm_Button.TabIndex = 7;
            this.RegisterForm_Button.Text = "Register Form";
            this.RegisterForm_Button.UseVisualStyleBackColor = true;
            this.RegisterForm_Button.Click += new System.EventHandler(this.RegisterForm_Button_Click);
            // 
            // Visable_Button
            // 
            this.Visable_Button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Visable_Button.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Visable_Button.Image = ((System.Drawing.Image)(resources.GetObject("Visable_Button.Image")));
            this.Visable_Button.Location = new System.Drawing.Point(435, 116);
            this.Visable_Button.Name = "Visable_Button";
            this.Visable_Button.Size = new System.Drawing.Size(41, 29);
            this.Visable_Button.TabIndex = 8;
            this.Visable_Button.UseVisualStyleBackColor = false;
            this.Visable_Button.Click += new System.EventHandler(this.Visable_Button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 208);
            this.Controls.Add(this.Visable_Button);
            this.Controls.Add(this.RegisterForm_Button);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Entry);
            this.Controls.Add(this.ID_Entry);
            this.Controls.Add(this.UserName_Entry);
            this.Controls.Add(this.Password_Lable);
            this.Controls.Add(this.ID_Lable);
            this.Controls.Add(this.UserName_Label);
            this.MaximumSize = new System.Drawing.Size(508, 255);
            this.MinimumSize = new System.Drawing.Size(508, 255);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName_Label;
        private System.Windows.Forms.Label ID_Lable;
        private System.Windows.Forms.Label Password_Lable;
        private System.Windows.Forms.TextBox UserName_Entry;
        private System.Windows.Forms.TextBox ID_Entry;
        private System.Windows.Forms.TextBox Password_Entry;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button RegisterForm_Button;
        private System.Windows.Forms.Button Visable_Button;
    }
}

