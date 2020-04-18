namespace DataEntryTestApp
{
    partial class StoreInitialize
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
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ManagerComboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.ItemAddButton = new System.Windows.Forms.Button();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.StaffComboBox = new System.Windows.Forms.ComboBox();
            this.StaffAddButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SubmitStorebutton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.ItemButton = new System.Windows.Forms.Button();
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.StoreButton = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.StaffListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.StoreListBox = new System.Windows.Forms.ListBox();
            this.FormHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MinimizeButton.Location = new System.Drawing.Point(701, 5);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(45, 42);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitButton.Location = new System.Drawing.Point(752, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 42);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormHeader.Controls.Add(this.MinimizeButton);
            this.FormHeader.Controls.Add(this.label1);
            this.FormHeader.Controls.Add(this.ExitButton);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(800, 50);
            this.FormHeader.TabIndex = 70;
            this.FormHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseDown);
            this.FormHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseMove);
            this.FormHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormHeader_MouseUp);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.StoreNameTextBox);
            this.panel2.Location = new System.Drawing.Point(177, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 53);
            this.panel2.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Store Name:";
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Location = new System.Drawing.Point(82, 15);
            this.StoreNameTextBox.MaxLength = 100;
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(291, 20);
            this.StoreNameTextBox.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.ManagerComboBox);
            this.panel3.Location = new System.Drawing.Point(331, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 53);
            this.panel3.TabIndex = 83;
            // 
            // ManagerComboBox
            // 
            this.ManagerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ManagerComboBox.FormattingEnabled = true;
            this.ManagerComboBox.Location = new System.Drawing.Point(15, 17);
            this.ManagerComboBox.Name = "ManagerComboBox";
            this.ManagerComboBox.Size = new System.Drawing.Size(208, 21);
            this.ManagerComboBox.TabIndex = 95;
            this.ManagerComboBox.SelectedIndexChanged += new System.EventHandler(this.ManagerComboBox_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Controls.Add(this.ItemComboBox);
            this.panel5.Controls.Add(this.ItemAddButton);
            this.panel5.Controls.Add(this.StockTextBox);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(331, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(238, 153);
            this.panel5.TabIndex = 87;
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(52, 30);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(167, 21);
            this.ItemComboBox.TabIndex = 97;
            // 
            // ItemAddButton
            // 
            this.ItemAddButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemAddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemAddButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ItemAddButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ItemAddButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ItemAddButton.Location = new System.Drawing.Point(15, 109);
            this.ItemAddButton.Name = "ItemAddButton";
            this.ItemAddButton.Size = new System.Drawing.Size(211, 35);
            this.ItemAddButton.TabIndex = 87;
            this.ItemAddButton.Text = "Add";
            this.ItemAddButton.UseVisualStyleBackColor = false;
            this.ItemAddButton.Click += new System.EventHandler(this.ItemAddButton_Click);
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(60, 72);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(159, 20);
            this.StockTextBox.TabIndex = 91;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "Stock:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 89;
            this.label9.Text = "Item:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel7.Controls.Add(this.StaffComboBox);
            this.panel7.Controls.Add(this.StaffAddButton);
            this.panel7.Location = new System.Drawing.Point(331, 187);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(238, 53);
            this.panel7.TabIndex = 94;
            // 
            // StaffComboBox
            // 
            this.StaffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StaffComboBox.FormattingEnabled = true;
            this.StaffComboBox.Location = new System.Drawing.Point(11, 16);
            this.StaffComboBox.Name = "StaffComboBox";
            this.StaffComboBox.Size = new System.Drawing.Size(148, 21);
            this.StaffComboBox.TabIndex = 96;
            // 
            // StaffAddButton
            // 
            this.StaffAddButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StaffAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StaffAddButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StaffAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StaffAddButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.StaffAddButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StaffAddButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.StaffAddButton.Location = new System.Drawing.Point(165, 5);
            this.StaffAddButton.Name = "StaffAddButton";
            this.StaffAddButton.Size = new System.Drawing.Size(68, 45);
            this.StaffAddButton.TabIndex = 85;
            this.StaffAddButton.Text = "Add";
            this.StaffAddButton.UseVisualStyleBackColor = false;
            this.StaffAddButton.Click += new System.EventHandler(this.StaffAddButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 95;
            this.label13.Text = "Staff:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(339, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 96;
            this.label14.Text = "Manager:";
            // 
            // SubmitStorebutton
            // 
            this.SubmitStorebutton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SubmitStorebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitStorebutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitStorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitStorebutton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.SubmitStorebutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SubmitStorebutton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.SubmitStorebutton.Location = new System.Drawing.Point(575, 363);
            this.SubmitStorebutton.Name = "SubmitStorebutton";
            this.SubmitStorebutton.Size = new System.Drawing.Size(213, 45);
            this.SubmitStorebutton.TabIndex = 94;
            this.SubmitStorebutton.Text = "Submit";
            this.SubmitStorebutton.UseVisualStyleBackColor = false;
            this.SubmitStorebutton.Click += new System.EventHandler(this.SubmitStorebutton_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(0, 357);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 45);
            this.button10.TabIndex = 105;
            this.button10.Text = "--";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(0, 313);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 45);
            this.button8.TabIndex = 104;
            this.button8.Text = "--";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(0, 269);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 45);
            this.button9.TabIndex = 103;
            this.button9.Text = "--";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(0, 182);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(160, 45);
            this.button11.TabIndex = 102;
            this.button11.Text = "--";
            this.button11.UseVisualStyleBackColor = false;
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
            this.ItemButton.Location = new System.Drawing.Point(0, 138);
            this.ItemButton.Name = "ItemButton";
            this.ItemButton.Size = new System.Drawing.Size(160, 45);
            this.ItemButton.TabIndex = 101;
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
            this.EmployeeButton.Location = new System.Drawing.Point(0, 94);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(160, 45);
            this.EmployeeButton.TabIndex = 100;
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
            this.StoreButton.Location = new System.Drawing.Point(0, 52);
            this.StoreButton.Name = "StoreButton";
            this.StoreButton.Size = new System.Drawing.Size(160, 45);
            this.StoreButton.TabIndex = 99;
            this.StoreButton.Text = "Store";
            this.StoreButton.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(0, 226);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(160, 45);
            this.button13.TabIndex = 107;
            this.button13.Text = "--";
            this.button13.UseVisualStyleBackColor = false;
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
            this.BackButton.Location = new System.Drawing.Point(0, 401);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(160, 45);
            this.BackButton.TabIndex = 108;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Location = new System.Drawing.Point(689, 69);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ItemsListBox.Size = new System.Drawing.Size(99, 277);
            this.ItemsListBox.TabIndex = 110;
            // 
            // StaffListBox
            // 
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.Location = new System.Drawing.Point(575, 69);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.StaffListBox.Size = new System.Drawing.Size(99, 277);
            this.StaffListBox.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Staff:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(687, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 112;
            this.label6.Text = "Items:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(178, 421);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 113;
            // 
            // StoreListBox
            // 
            this.StoreListBox.FormattingEnabled = true;
            this.StoreListBox.Location = new System.Drawing.Point(177, 117);
            this.StoreListBox.Name = "StoreListBox";
            this.StoreListBox.Size = new System.Drawing.Size(135, 290);
            this.StoreListBox.TabIndex = 114;
            // 
            // StoreInitialize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StoreListBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffListBox);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.ItemButton);
            this.Controls.Add(this.EmployeeButton);
            this.Controls.Add(this.StoreButton);
            this.Controls.Add(this.SubmitStorebutton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreInitialize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StoreInitialize";
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ItemAddButton;
        private System.Windows.Forms.TextBox StockTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button StaffAddButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button SubmitStorebutton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button ItemButton;
        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button StoreButton;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ListBox StaffListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ManagerComboBox;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.ComboBox StaffComboBox;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ListBox StoreListBox;
    }
}