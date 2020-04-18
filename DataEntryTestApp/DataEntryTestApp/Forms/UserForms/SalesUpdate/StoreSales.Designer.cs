namespace DataEntryTestApp
{
    partial class StoreSales
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
            this.StoreSelect = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.FormLabel = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.StoreListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.FormHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // StoreSelect
            // 
            this.StoreSelect.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StoreSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoreSelect.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StoreSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreSelect.Location = new System.Drawing.Point(12, 275);
            this.StoreSelect.Name = "StoreSelect";
            this.StoreSelect.Size = new System.Drawing.Size(131, 45);
            this.StoreSelect.TabIndex = 34;
            this.StoreSelect.Text = "Select Store";
            this.StoreSelect.UseVisualStyleBackColor = false;
            this.StoreSelect.Click += new System.EventHandler(this.StoreSelect_Click);
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
            // 
            // FormLabel
            // 
            this.FormLabel.AutoSize = true;
            this.FormLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormLabel.Location = new System.Drawing.Point(12, 20);
            this.FormLabel.Name = "FormLabel";
            this.FormLabel.Size = new System.Drawing.Size(162, 13);
            this.FormLabel.TabIndex = 3;
            this.FormLabel.Text = "Test Form For ODBC Connection";
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
            // 
            // FormHeader
            // 
            this.FormHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormHeader.Controls.Add(this.MinimizeButton);
            this.FormHeader.Controls.Add(this.FormLabel);
            this.FormHeader.Controls.Add(this.ExitButton);
            this.FormHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormHeader.Location = new System.Drawing.Point(0, 0);
            this.FormHeader.Name = "FormHeader";
            this.FormHeader.Size = new System.Drawing.Size(300, 50);
            this.FormHeader.TabIndex = 26;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(157, 275);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(131, 45);
            this.SubmitButton.TabIndex = 35;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // StoreListBox
            // 
            this.StoreListBox.FormattingEnabled = true;
            this.StoreListBox.Location = new System.Drawing.Point(51, 73);
            this.StoreListBox.Name = "StoreListBox";
            this.StoreListBox.Size = new System.Drawing.Size(192, 173);
            this.StoreListBox.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Stores Remaining:";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(15, 254);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 37;
            // 
            // StoreSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 332);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StoreListBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.StoreSelect);
            this.Controls.Add(this.FormHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreSales";
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StoreSelect;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label FormLabel;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ListBox StoreListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorLabel;
    }
}