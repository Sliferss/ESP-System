namespace DataEntryTestApp
{
    partial class Form
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
            this.ManagerViewerButton = new System.Windows.Forms.Button();
            this.ItemViewerButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.EmployeeViewerButton = new System.Windows.Forms.Button();
            this.StoreViewerButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StaffNameLabel = new System.Windows.Forms.Label();
            this.SalaryLabel = new System.Windows.Forms.Label();
            this.StoreLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BackButton = new System.Windows.Forms.Button();
            this.StaffListBox = new System.Windows.Forms.ListBox();
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
            // ManagerViewerButton
            // 
            this.ManagerViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ManagerViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagerViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManagerViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ManagerViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManagerViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ManagerViewerButton.Location = new System.Drawing.Point(2, 184);
            this.ManagerViewerButton.Name = "ManagerViewerButton";
            this.ManagerViewerButton.Size = new System.Drawing.Size(160, 45);
            this.ManagerViewerButton.TabIndex = 71;
            this.ManagerViewerButton.Text = "Managers";
            this.ManagerViewerButton.UseVisualStyleBackColor = false;
            this.ManagerViewerButton.Click += new System.EventHandler(this.ManagerViewerButton_Click);
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
            // 
            // StoreViewerButton
            // 
            this.StoreViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StoreViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoreViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StoreViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoreViewerButton.Location = new System.Drawing.Point(2, 53);
            this.StoreViewerButton.Name = "StoreViewerButton";
            this.StoreViewerButton.Size = new System.Drawing.Size(160, 45);
            this.StoreViewerButton.TabIndex = 62;
            this.StoreViewerButton.Text = "Stores";
            this.StoreViewerButton.UseVisualStyleBackColor = false;
            this.StoreViewerButton.Click += new System.EventHandler(this.StoreViewerButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Staff:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.StaffNameLabel);
            this.panel1.Controls.Add(this.SalaryLabel);
            this.panel1.Controls.Add(this.StoreLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(415, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 123);
            this.panel1.TabIndex = 74;
            // 
            // StaffNameLabel
            // 
            this.StaffNameLabel.AutoSize = true;
            this.StaffNameLabel.Location = new System.Drawing.Point(61, 24);
            this.StaffNameLabel.Name = "StaffNameLabel";
            this.StaffNameLabel.Size = new System.Drawing.Size(47, 13);
            this.StaffNameLabel.TabIndex = 16;
            this.StaffNameLabel.Text = "No Data";
            // 
            // SalaryLabel
            // 
            this.SalaryLabel.AutoSize = true;
            this.SalaryLabel.Location = new System.Drawing.Point(61, 55);
            this.SalaryLabel.Name = "SalaryLabel";
            this.SalaryLabel.Size = new System.Drawing.Size(47, 13);
            this.SalaryLabel.TabIndex = 15;
            this.SalaryLabel.Text = "No Data";
            // 
            // StoreLabel
            // 
            this.StoreLabel.AutoSize = true;
            this.StoreLabel.Location = new System.Drawing.Point(61, 88);
            this.StoreLabel.Name = "StoreLabel";
            this.StoreLabel.Size = new System.Drawing.Size(47, 13);
            this.StoreLabel.TabIndex = 14;
            this.StoreLabel.Text = "No Data";
            this.StoreLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StoreLabel_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Store:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Information:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BackButton.Location = new System.Drawing.Point(2, 402);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(160, 45);
            this.BackButton.TabIndex = 76;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // StaffListBox
            // 
            this.StaffListBox.FormattingEnabled = true;
            this.StaffListBox.Location = new System.Drawing.Point(188, 72);
            this.StaffListBox.Name = "StaffListBox";
            this.StaffListBox.Size = new System.Drawing.Size(166, 355);
            this.StaffListBox.TabIndex = 77;
            this.StaffListBox.SelectedIndexChanged += new System.EventHandler(this.StaffListBox_SelectedIndexChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffListBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.ManagerViewerButton);
            this.Controls.Add(this.ItemViewerButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.EmployeeViewerButton);
            this.Controls.Add(this.StoreViewerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.Button ManagerViewerButton;
        private System.Windows.Forms.Button ItemViewerButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button EmployeeViewerButton;
        private System.Windows.Forms.Button StoreViewerButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox StaffListBox;
        private System.Windows.Forms.Label StoreLabel;
        private System.Windows.Forms.Label StaffNameLabel;
        private System.Windows.Forms.Label SalaryLabel;
    }
}