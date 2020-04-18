namespace DataEntryTestApp
{
    partial class ManagerViewer
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.ManagersViewerButton = new System.Windows.Forms.Button();
            this.ItemViewerButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.EmployeeViewerButton = new System.Windows.Forms.Button();
            this.StoresViewerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StoreNameTextBox = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ViewerBackButton = new System.Windows.Forms.Button();
            this.ManagerListBox = new System.Windows.Forms.ListBox();
            this.EmployeeListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FormHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.FormHeader.TabIndex = 69;
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
            // ExitButton
            // 
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitButton.Location = new System.Drawing.Point(752, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(45, 42);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ManagersViewerButton
            // 
            this.ManagersViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ManagersViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagersViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManagersViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagersViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ManagersViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManagersViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ManagersViewerButton.Location = new System.Drawing.Point(2, 184);
            this.ManagersViewerButton.Name = "ManagersViewerButton";
            this.ManagersViewerButton.Size = new System.Drawing.Size(160, 45);
            this.ManagersViewerButton.TabIndex = 71;
            this.ManagersViewerButton.Text = "Managers";
            this.ManagersViewerButton.UseVisualStyleBackColor = false;
            // 
            // ItemViewerButton
            // 
            this.ItemViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ItemViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ItemViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ItemViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ItemViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ItemViewerButton.Location = new System.Drawing.Point(2, 139);
            this.ItemViewerButton.Name = "ItemViewerButton";
            this.ItemViewerButton.Size = new System.Drawing.Size(160, 45);
            this.ItemViewerButton.TabIndex = 70;
            this.ItemViewerButton.Text = "Items";
            this.ItemViewerButton.UseVisualStyleBackColor = false;
            this.ItemViewerButton.Click += new System.EventHandler(this.ItemViewerButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(2, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 45);
            this.button6.TabIndex = 67;
            this.button6.Text = "--";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(2, 316);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 45);
            this.button7.TabIndex = 66;
            this.button7.Text = "--";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(2, 271);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 45);
            this.button8.TabIndex = 65;
            this.button8.Text = "--";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(2, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 45);
            this.button9.TabIndex = 64;
            this.button9.Text = "--";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // EmployeeViewerButton
            // 
            this.EmployeeViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.EmployeeViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmployeeViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeeViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.EmployeeViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmployeeViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.EmployeeViewerButton.Location = new System.Drawing.Point(2, 95);
            this.EmployeeViewerButton.Name = "EmployeeViewerButton";
            this.EmployeeViewerButton.Size = new System.Drawing.Size(160, 45);
            this.EmployeeViewerButton.TabIndex = 63;
            this.EmployeeViewerButton.Text = "Employees";
            this.EmployeeViewerButton.UseVisualStyleBackColor = false;
            this.EmployeeViewerButton.Click += new System.EventHandler(this.EmployeeViewerButton_Click);
            // 
            // StoresViewerButton
            // 
            this.StoresViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StoresViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoresViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StoresViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoresViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoresViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoresViewerButton.Location = new System.Drawing.Point(2, 53);
            this.StoresViewerButton.Name = "StoresViewerButton";
            this.StoresViewerButton.Size = new System.Drawing.Size(160, 45);
            this.StoresViewerButton.TabIndex = 62;
            this.StoresViewerButton.Text = "Stores";
            this.StoresViewerButton.UseVisualStyleBackColor = false;
            this.StoresViewerButton.Click += new System.EventHandler(this.StoresViewerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Information:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.StoreNameTextBox);
            this.panel1.Controls.Add(this.SalaryTextBox);
            this.panel1.Controls.Add(this.NameTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(313, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 156);
            this.panel1.TabIndex = 78;
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.AutoSize = true;
            this.StoreNameTextBox.Location = new System.Drawing.Point(76, 101);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(47, 13);
            this.StoreNameTextBox.TabIndex = 89;
            this.StoreNameTextBox.Text = "No Data";
            this.StoreNameTextBox.Click += new System.EventHandler(this.StoreNameTextBox_Click);
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.AutoSize = true;
            this.SalaryTextBox.Location = new System.Drawing.Point(76, 69);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(47, 13);
            this.SalaryTextBox.TabIndex = 88;
            this.SalaryTextBox.Text = "No Data";
            // 
            // NameTextBox
            // 
            this.NameTextBox.AutoSize = true;
            this.NameTextBox.Location = new System.Drawing.Point(76, 40);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(47, 13);
            this.NameTextBox.TabIndex = 87;
            this.NameTextBox.Text = "No Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Store:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // ViewerBackButton
            // 
            this.ViewerBackButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ViewerBackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewerBackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewerBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewerBackButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ViewerBackButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ViewerBackButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ViewerBackButton.Location = new System.Drawing.Point(3, 403);
            this.ViewerBackButton.Name = "ViewerBackButton";
            this.ViewerBackButton.Size = new System.Drawing.Size(160, 45);
            this.ViewerBackButton.TabIndex = 83;
            this.ViewerBackButton.Text = "Back";
            this.ViewerBackButton.UseVisualStyleBackColor = false;
            this.ViewerBackButton.Click += new System.EventHandler(this.ViewerBackButton_Click);
            // 
            // ManagerListBox
            // 
            this.ManagerListBox.FormattingEnabled = true;
            this.ManagerListBox.Location = new System.Drawing.Point(168, 56);
            this.ManagerListBox.Name = "ManagerListBox";
            this.ManagerListBox.Size = new System.Drawing.Size(139, 381);
            this.ManagerListBox.TabIndex = 84;
            this.ManagerListBox.SelectedIndexChanged += new System.EventHandler(this.ManagerListBox_SelectedIndexChanged);
            // 
            // EmployeeListBox
            // 
            this.EmployeeListBox.FormattingEnabled = true;
            this.EmployeeListBox.Location = new System.Drawing.Point(649, 69);
            this.EmployeeListBox.Name = "EmployeeListBox";
            this.EmployeeListBox.Size = new System.Drawing.Size(139, 368);
            this.EmployeeListBox.TabIndex = 85;
            this.EmployeeListBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeListBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Employee\'s Managed:";
            // 
            // ManagerViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmployeeListBox);
            this.Controls.Add(this.ManagerListBox);
            this.Controls.Add(this.ViewerBackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.ManagersViewerButton);
            this.Controls.Add(this.ItemViewerButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.EmployeeViewerButton);
            this.Controls.Add(this.StoresViewerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManagerViewer";
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ManagersViewerButton;
        private System.Windows.Forms.Button ItemViewerButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button EmployeeViewerButton;
        private System.Windows.Forms.Button StoresViewerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ViewerBackButton;
        private System.Windows.Forms.ListBox ManagerListBox;
        private System.Windows.Forms.ListBox EmployeeListBox;
        private System.Windows.Forms.Label StoreNameTextBox;
        private System.Windows.Forms.Label SalaryTextBox;
        private System.Windows.Forms.Label NameTextBox;
        private System.Windows.Forms.Label label3;
    }
}