namespace DataEntryTestApp
{
    partial class StoreViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ManagerViewerButton = new System.Windows.Forms.Button();
            this.ItemViewerButton = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.EmployeeViewerButton = new System.Windows.Forms.Button();
            this.StoreViewerButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UniqueCountTextBox = new System.Windows.Forms.Label();
            this.StockCostTextBox = new System.Windows.Forms.Label();
            this.SoldCountTextBox = new System.Windows.Forms.Label();
            this.StaffNumTextBox = new System.Windows.Forms.Label();
            this.ManagerNameTextBox = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StoreProfitLabel = new System.Windows.Forms.Label();
            this.StoreListBox = new System.Windows.Forms.ListBox();
            this.StaffMemberListBox = new System.Windows.Forms.ListBox();
            this.InventoryListBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ItemProfitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ViewerBackButton = new System.Windows.Forms.Button();
            this.FormHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemProfitChart)).BeginInit();
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
            this.FormHeader.TabIndex = 59;
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
            // ManagerViewerButton
            // 
            this.ManagerViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ManagerViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManagerViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ManagerViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManagerViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.ManagerViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManagerViewerButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ManagerViewerButton.Location = new System.Drawing.Point(2, 183);
            this.ManagerViewerButton.Name = "ManagerViewerButton";
            this.ManagerViewerButton.Size = new System.Drawing.Size(160, 45);
            this.ManagerViewerButton.TabIndex = 61;
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
            this.ItemViewerButton.Location = new System.Drawing.Point(2, 138);
            this.ItemViewerButton.Name = "ItemViewerButton";
            this.ItemViewerButton.Size = new System.Drawing.Size(160, 45);
            this.ItemViewerButton.TabIndex = 60;
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
            this.button6.Location = new System.Drawing.Point(2, 360);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 45);
            this.button6.TabIndex = 57;
            this.button6.Text = "--";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(2, 315);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 45);
            this.button7.TabIndex = 56;
            this.button7.Text = "--";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(2, 270);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(160, 45);
            this.button8.TabIndex = 55;
            this.button8.Text = "--";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(2, 228);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 45);
            this.button9.TabIndex = 54;
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
            this.EmployeeViewerButton.Location = new System.Drawing.Point(2, 94);
            this.EmployeeViewerButton.Name = "EmployeeViewerButton";
            this.EmployeeViewerButton.Size = new System.Drawing.Size(160, 45);
            this.EmployeeViewerButton.TabIndex = 53;
            this.EmployeeViewerButton.Text = "Employees";
            this.EmployeeViewerButton.UseVisualStyleBackColor = false;
            this.EmployeeViewerButton.Click += new System.EventHandler(this.EmployeeViewerButton_Click);
            // 
            // StoreViewerButton
            // 
            this.StoreViewerButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StoreViewerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoreViewerButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.StoreViewerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoreViewerButton.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreViewerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StoreViewerButton.Location = new System.Drawing.Point(2, 52);
            this.StoreViewerButton.Name = "StoreViewerButton";
            this.StoreViewerButton.Size = new System.Drawing.Size(160, 45);
            this.StoreViewerButton.TabIndex = 52;
            this.StoreViewerButton.Text = "Stores";
            this.StoreViewerButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.UniqueCountTextBox);
            this.panel2.Controls.Add(this.StockCostTextBox);
            this.panel2.Controls.Add(this.SoldCountTextBox);
            this.panel2.Controls.Add(this.StaffNumTextBox);
            this.panel2.Controls.Add(this.ManagerNameTextBox);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.StoreNameTextBox);
            this.panel2.Location = new System.Drawing.Point(308, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 180);
            this.panel2.TabIndex = 63;
            // 
            // UniqueCountTextBox
            // 
            this.UniqueCountTextBox.AutoSize = true;
            this.UniqueCountTextBox.Location = new System.Drawing.Point(85, 117);
            this.UniqueCountTextBox.Name = "UniqueCountTextBox";
            this.UniqueCountTextBox.Size = new System.Drawing.Size(44, 13);
            this.UniqueCountTextBox.TabIndex = 16;
            this.UniqueCountTextBox.Text = "NoData";
            // 
            // StockCostTextBox
            // 
            this.StockCostTextBox.AutoSize = true;
            this.StockCostTextBox.Location = new System.Drawing.Point(75, 143);
            this.StockCostTextBox.Name = "StockCostTextBox";
            this.StockCostTextBox.Size = new System.Drawing.Size(44, 13);
            this.StockCostTextBox.TabIndex = 15;
            this.StockCostTextBox.Text = "NoData";
            // 
            // SoldCountTextBox
            // 
            this.SoldCountTextBox.AutoSize = true;
            this.SoldCountTextBox.Location = new System.Drawing.Point(72, 91);
            this.SoldCountTextBox.Name = "SoldCountTextBox";
            this.SoldCountTextBox.Size = new System.Drawing.Size(44, 13);
            this.SoldCountTextBox.TabIndex = 14;
            this.SoldCountTextBox.Text = "NoData";
            // 
            // StaffNumTextBox
            // 
            this.StaffNumTextBox.AutoSize = true;
            this.StaffNumTextBox.Location = new System.Drawing.Point(99, 62);
            this.StaffNumTextBox.Name = "StaffNumTextBox";
            this.StaffNumTextBox.Size = new System.Drawing.Size(44, 13);
            this.StaffNumTextBox.TabIndex = 13;
            this.StaffNumTextBox.Text = "NoData";
            // 
            // ManagerNameTextBox
            // 
            this.ManagerNameTextBox.AutoSize = true;
            this.ManagerNameTextBox.Location = new System.Drawing.Point(65, 36);
            this.ManagerNameTextBox.Name = "ManagerNameTextBox";
            this.ManagerNameTextBox.Size = new System.Drawing.Size(44, 13);
            this.ManagerNameTextBox.TabIndex = 12;
            this.ManagerNameTextBox.Text = "NoData";
            this.ManagerNameTextBox.Click += new System.EventHandler(this.ManagerNameTextBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Stock Cost:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unique Items:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Items Sold:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number Of Staff:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manager:";
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Location = new System.Drawing.Point(4, 4);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.ReadOnly = true;
            this.StoreNameTextBox.Size = new System.Drawing.Size(208, 20);
            this.StoreNameTextBox.TabIndex = 0;
            this.StoreNameTextBox.Text = "Store Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 57;
            this.label7.Text = "Store Profit:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.StoreProfitLabel);
            this.panel3.Location = new System.Drawing.Point(168, 257);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 181);
            this.panel3.TabIndex = 58;
            // 
            // StoreProfitLabel
            // 
            this.StoreProfitLabel.AutoSize = true;
            this.StoreProfitLabel.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StoreProfitLabel.Location = new System.Drawing.Point(18, 66);
            this.StoreProfitLabel.Name = "StoreProfitLabel";
            this.StoreProfitLabel.Size = new System.Drawing.Size(174, 47);
            this.StoreProfitLabel.TabIndex = 1;
            this.StoreProfitLabel.Text = "No Data";
            // 
            // StoreListBox
            // 
            this.StoreListBox.FormattingEnabled = true;
            this.StoreListBox.Location = new System.Drawing.Point(168, 58);
            this.StoreListBox.Name = "StoreListBox";
            this.StoreListBox.Size = new System.Drawing.Size(134, 186);
            this.StoreListBox.TabIndex = 64;
            this.StoreListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StoreListBox_MouseClick);
            // 
            // StaffMemberListBox
            // 
            this.StaffMemberListBox.FormattingEnabled = true;
            this.StaffMemberListBox.Location = new System.Drawing.Point(529, 69);
            this.StaffMemberListBox.Name = "StaffMemberListBox";
            this.StaffMemberListBox.Size = new System.Drawing.Size(129, 173);
            this.StaffMemberListBox.TabIndex = 65;
            this.StaffMemberListBox.SelectedIndexChanged += new System.EventHandler(this.StaffMemberListBox_SelectedIndexChanged);
            // 
            // InventoryListBox
            // 
            this.InventoryListBox.FormattingEnabled = true;
            this.InventoryListBox.Location = new System.Drawing.Point(664, 69);
            this.InventoryListBox.Name = "InventoryListBox";
            this.InventoryListBox.Size = new System.Drawing.Size(129, 173);
            this.InventoryListBox.TabIndex = 66;
            this.InventoryListBox.SelectedIndexChanged += new System.EventHandler(this.InventoryListBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Staff Members:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(666, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 68;
            this.label11.Text = "Inventory:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Controls.Add(this.ItemProfitChart);
            this.panel5.Location = new System.Drawing.Point(393, 257);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(400, 181);
            this.panel5.TabIndex = 62;
            // 
            // ItemProfitChart
            // 
            this.ItemProfitChart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemProfitChart.BorderlineColor = System.Drawing.SystemColors.InactiveBorder;
            chartArea1.Name = "ChartArea1";
            this.ItemProfitChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ItemProfitChart.Legends.Add(legend1);
            this.ItemProfitChart.Location = new System.Drawing.Point(3, 5);
            this.ItemProfitChart.Name = "ItemProfitChart";
            this.ItemProfitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ItemProfitChart.Series.Add(series1);
            this.ItemProfitChart.Size = new System.Drawing.Size(392, 172);
            this.ItemProfitChart.TabIndex = 1;
            this.ItemProfitChart.Text = "chart1";
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
            this.ViewerBackButton.Location = new System.Drawing.Point(2, 402);
            this.ViewerBackButton.Name = "ViewerBackButton";
            this.ViewerBackButton.Size = new System.Drawing.Size(160, 45);
            this.ViewerBackButton.TabIndex = 70;
            this.ViewerBackButton.Text = "Back";
            this.ViewerBackButton.UseVisualStyleBackColor = false;
            this.ViewerBackButton.Click += new System.EventHandler(this.ViewerBackButton_Click);
            // 
            // StoreViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewerBackButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.InventoryListBox);
            this.Controls.Add(this.StaffMemberListBox);
            this.Controls.Add(this.StoreListBox);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
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
            this.Name = "StoreViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StoreViewer";
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemProfitChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ManagerViewerButton;
        private System.Windows.Forms.Button ItemViewerButton;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button EmployeeViewerButton;
        private System.Windows.Forms.Button StoreViewerButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox StoreListBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label StoreProfitLabel;
        private System.Windows.Forms.ListBox StaffMemberListBox;
        private System.Windows.Forms.ListBox InventoryListBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart ItemProfitChart;
        private System.Windows.Forms.Button ViewerBackButton;
        private System.Windows.Forms.Label UniqueCountTextBox;
        private System.Windows.Forms.Label StockCostTextBox;
        private System.Windows.Forms.Label SoldCountTextBox;
        private System.Windows.Forms.Label StaffNumTextBox;
        private System.Windows.Forms.Label ManagerNameTextBox;
    }
}