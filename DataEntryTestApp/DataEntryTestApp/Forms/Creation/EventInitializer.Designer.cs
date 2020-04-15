namespace DataEntryTestApp
{
    partial class EventInitializer
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
            this.FormHeader = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ItemButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.StoreButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StoreListBox = new System.Windows.Forms.ListBox();
            this.ManagerListBox = new System.Windows.Forms.ListBox();
            this.EventNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StaffMemberLabel = new System.Windows.Forms.Label();
            this.StoresLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ELabel = new System.Windows.Forms.Label();
            this.FormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormHeader.Controls.Add(this.MinimizeButton);
            this.FormHeader.Controls.Add(this.label1);
            this.FormHeader.Controls.Add(this.CloseButton);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(800, 50);
            this.FormHeader.TabIndex = 81;
            this.FormHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseDown);
            this.FormHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseMove);
            this.FormHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimizeButton.Location = new System.Drawing.Point(701, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 42);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Test Form For ODBC Connection";
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CloseButton.Location = new System.Drawing.Point(752, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(45, 42);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(335, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 84;
            this.label8.Text = "Stores:";
            // 
            // ItemButton
            // 
            this.ItemButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ItemButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ItemButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ItemButton.Location = new System.Drawing.Point(2, 139);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(160, 45);
            this.ItemButton.TabIndex = 82;
            this.ItemButton.Text = "Item";
            this.ItemButton.UseVisualStyleBackColor = false;
            this.ItemButton.Click += new System.EventHandler(this.ItemButton_Click);
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.EmployeeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmployeeButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EmployeeButton.Location = new System.Drawing.Point(2, 95);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(160, 45);
            this.EmployeeButton.TabIndex = 75;
            this.EmployeeButton.Text = "Employee";
            this.EmployeeButton.UseVisualStyleBackColor = false;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // StoreButton
            // 
            this.StoreButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StoreButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoreButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoreButton.Location = new System.Drawing.Point(2, 53);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(160, 45);
            this.StoreButton.TabIndex = 74;
            this.StoreButton.Text = "Store";
            this.StoreButton.UseVisualStyleBackColor = false;
            this.StoreButton.Click += new System.EventHandler(this.StoreButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(2, 316);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 45);
            this.button6.TabIndex = 95;
            this.button6.Text = "--";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(2, 271);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 45);
            this.button7.TabIndex = 94;
            this.button7.Text = "--";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(2, 226);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 45);
            this.button8.TabIndex = 93;
            this.button8.Text = "--";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(2, 184);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 45);
            this.button9.TabIndex = 92;
            this.button9.Text = "--";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(2, 360);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 45);
            this.button10.TabIndex = 96;
            this.button10.Text = "--";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(645, 360);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(134, 67);
            this.SubmitButton.TabIndex = 97;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Managers:";
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(645, 111);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.EmployeeListBox.Size = new System.Drawing.Size(134, 238);
            this.EmployeeListBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Employee\'s:";
            // 
            // ItemListBox
            // 
            this.ItemListBox.FormattingEnabled = true;
            this.ItemListBox.Location = new System.Drawing.Point(496, 111);
            this.ItemListBox.Name = "ItemListBox";
            this.ItemListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ItemListBox.Size = new System.Drawing.Size(134, 316);
            this.ItemListBox.TabIndex = 104;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(493, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 105;
            this.label4.Text = "Items:";
            // 
            // StoreListBox
            // 
            this.StoreListBox.FormattingEnabled = true;
            this.StoreListBox.Location = new System.Drawing.Point(338, 111);
            this.StoreListBox.Name = "StoreListBox";
            this.StoreListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.StoreListBox.Size = new System.Drawing.Size(146, 316);
            this.StoreListBox.TabIndex = 106;
            // 
            // ManagerListBox
            // 
            this.ManagerListBox.FormattingEnabled = true;
            this.ManagerListBox.Location = new System.Drawing.Point(181, 163);
            this.ManagerListBox.Name = "ManagerListBox";
            this.ManagerListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ManagerListBox.Size = new System.Drawing.Size(146, 264);
            this.ManagerListBox.TabIndex = 107;
            // 
            // EventNameTextBox
            // 
            this.EventNameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EventNameTextBox.Location = new System.Drawing.Point(181, 63);
            this.EventNameTextBox.Name = "EventNameTextBox";
            this.EventNameTextBox.ReadOnly = true;
            this.EventNameTextBox.Size = new System.Drawing.Size(598, 20);
            this.EventNameTextBox.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Staff Members:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 110;
            this.label6.Text = "Stores:";
            // 
            // StaffMemberLabel
            // 
            this.StaffMemberLabel.AutoSize = true;
            this.StaffMemberLabel.Location = new System.Drawing.Point(262, 95);
            this.StaffMemberLabel.Name = "StaffMemberLabel";
            this.StaffMemberLabel.Size = new System.Drawing.Size(44, 13);
            this.StaffMemberLabel.TabIndex = 111;
            this.StaffMemberLabel.Text = "NoData";
            // 
            // StoresLabel
            // 
            this.StoresLabel.AutoSize = true;
            this.StoresLabel.Location = new System.Drawing.Point(224, 122);
            this.StoresLabel.Name = "StoresLabel";
            this.StoresLabel.Size = new System.Drawing.Size(44, 13);
            this.StoresLabel.TabIndex = 112;
            this.StoresLabel.Text = "NoData";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BackButton.Location = new System.Drawing.Point(2, 403);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(160, 45);
            this.BackButton.TabIndex = 113;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ELabel
            // 
            this.ELabel.AutoSize = true;
            this.ELabel.ForeColor = System.Drawing.Color.Red;
            this.ELabel.Location = new System.Drawing.Point(180, 431);
            this.ELabel.Name = "ELabel";
            this.ELabel.Size = new System.Drawing.Size(0, 13);
            this.ELabel.TabIndex = 136;
            // 
            // EventInitializer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ELabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.StoresLabel);
            this.Controls.Add(this.StaffMemberLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EventNameTextBox);
            this.Controls.Add(this.ManagerListBox);
            this.Controls.Add(this.StoreListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.StoreButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventInitializer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventInitializer";
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button StoreButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ItemListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox StoreListBox;
        private System.Windows.Forms.ListBox ManagerListBox;
        private System.Windows.Forms.TextBox EventNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StaffMemberLabel;
        private System.Windows.Forms.Label StoresLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label ELabel;
    }
}