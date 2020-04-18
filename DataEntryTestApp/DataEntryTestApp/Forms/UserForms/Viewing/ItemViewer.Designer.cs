namespace DataEntryTestApp
{
    partial class ItemViewer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StoresStockingTextBox = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UnitsSoldTextBox = new System.Windows.Forms.Label();
            this.ProffitPerUnitTextBox = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SalePriceTextBox = new System.Windows.Forms.Label();
            this.WholesalePriceTextBox = new System.Windows.Forms.Label();
            this.FormHeader = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ManagerViewerButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.EmployeeViewerButton = new System.Windows.Forms.Button();
            this.StoreViewerButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ItemProfitChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.ViewerBackButton = new System.Windows.Forms.Button();
            this.EventItemListBox = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.FormHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemProfitChart)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Units Sold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Profit Per Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sale Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wholesale Price:";
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(4, 4);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.ReadOnly = true;
            this.ItemNameTextBox.Size = new System.Drawing.Size(208, 20);
            this.ItemNameTextBox.TabIndex = 0;
            this.ItemNameTextBox.Text = "Item Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.StoresStockingTextBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.UnitsSoldTextBox);
            this.panel2.Controls.Add(this.ProffitPerUnitTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.SalePriceTextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.WholesalePriceTextBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ItemNameTextBox);
            this.panel2.Location = new System.Drawing.Point(308, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 180);
            this.panel2.TabIndex = 76;
            // 
            // StoresStockingTextBox
            // 
            this.StoresStockingTextBox.AutoSize = true;
            this.StoresStockingTextBox.Location = new System.Drawing.Point(98, 143);
            this.StoresStockingTextBox.Name = "StoresStockingTextBox";
            this.StoresStockingTextBox.Size = new System.Drawing.Size(47, 13);
            this.StoresStockingTextBox.TabIndex = 85;
            this.StoresStockingTextBox.Text = "No Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Stores Stocking:";
            // 
            // UnitsSoldTextBox
            // 
            this.UnitsSoldTextBox.AutoSize = true;
            this.UnitsSoldTextBox.Location = new System.Drawing.Point(71, 117);
            this.UnitsSoldTextBox.Name = "UnitsSoldTextBox";
            this.UnitsSoldTextBox.Size = new System.Drawing.Size(47, 13);
            this.UnitsSoldTextBox.TabIndex = 84;
            this.UnitsSoldTextBox.Text = "No Data";
            // 
            // ProffitPerUnitTextBox
            // 
            this.ProffitPerUnitTextBox.AutoSize = true;
            this.ProffitPerUnitTextBox.Location = new System.Drawing.Point(88, 91);
            this.ProffitPerUnitTextBox.Name = "ProffitPerUnitTextBox";
            this.ProffitPerUnitTextBox.Size = new System.Drawing.Size(47, 13);
            this.ProffitPerUnitTextBox.TabIndex = 83;
            this.ProffitPerUnitTextBox.Text = "No Data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // SalePriceTextBox
            // 
            this.SalePriceTextBox.AutoSize = true;
            this.SalePriceTextBox.Location = new System.Drawing.Point(71, 62);
            this.SalePriceTextBox.Name = "SalePriceTextBox";
            this.SalePriceTextBox.Size = new System.Drawing.Size(47, 13);
            this.SalePriceTextBox.TabIndex = 82;
            this.SalePriceTextBox.Text = "No Data";
            // 
            // WholesalePriceTextBox
            // 
            this.WholesalePriceTextBox.AutoSize = true;
            this.WholesalePriceTextBox.Location = new System.Drawing.Point(100, 36);
            this.WholesalePriceTextBox.Name = "WholesalePriceTextBox";
            this.WholesalePriceTextBox.Size = new System.Drawing.Size(47, 13);
            this.WholesalePriceTextBox.TabIndex = 12;
            this.WholesalePriceTextBox.Text = "No Data";
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
            this.FormHeader.TabIndex = 72;
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
            this.ManagerViewerButton.TabIndex = 75;
            this.ManagerViewerButton.Text = "Managers";
            this.ManagerViewerButton.UseVisualStyleBackColor = false;
            this.ManagerViewerButton.Click += new System.EventHandler(this.ManagerViewerButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.Location = new System.Drawing.Point(2, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 45);
            this.button3.TabIndex = 74;
            this.button3.Text = "Items";
            this.button3.UseVisualStyleBackColor = false;
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
            this.button6.TabIndex = 69;
            this.button6.Text = "--";
            this.button6.UseVisualStyleBackColor = false;
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
            this.button9.TabIndex = 66;
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
            this.EmployeeViewerButton.TabIndex = 65;
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
            this.StoreViewerButton.Location = new System.Drawing.Point(2, 53);
            this.StoreViewerButton.Name = "StoreViewerButton";
            this.StoreViewerButton.Size = new System.Drawing.Size(160, 45);
            this.StoreViewerButton.TabIndex = 64;
            this.StoreViewerButton.Text = "Stores";
            this.StoreViewerButton.UseVisualStyleBackColor = false;
            this.StoreViewerButton.Click += new System.EventHandler(this.StoreViewerButton_Click);
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
            this.button7.TabIndex = 68;
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
            this.button8.TabIndex = 67;
            this.button8.Text = "--";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(553, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Sold vs Stocked";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.SalesChart);
            this.panel1.Location = new System.Drawing.Point(529, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 190);
            this.panel1.TabIndex = 75;
            // 
            // SalesChart
            // 
            this.SalesChart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.SalesChart.BorderlineColor = System.Drawing.SystemColors.InactiveBorder;
            chartArea1.Name = "ChartArea1";
            this.SalesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.SalesChart.Legends.Add(legend1);
            this.SalesChart.Location = new System.Drawing.Point(3, 10);
            this.SalesChart.Name = "SalesChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.SalesChart.Series.Add(series1);
            this.SalesChart.Size = new System.Drawing.Size(253, 177);
            this.SalesChart.TabIndex = 1;
            this.SalesChart.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(548, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Individual Store Sales:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.ItemProfitChart);
            this.panel3.Location = new System.Drawing.Point(529, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(259, 176);
            this.panel3.TabIndex = 78;
            // 
            // ItemProfitChart
            // 
            this.ItemProfitChart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ItemProfitChart.BorderlineColor = System.Drawing.SystemColors.InactiveBorder;
            chartArea2.Name = "ChartArea1";
            this.ItemProfitChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ItemProfitChart.Legends.Add(legend2);
            this.ItemProfitChart.Location = new System.Drawing.Point(3, 10);
            this.ItemProfitChart.Name = "ItemProfitChart";
            this.ItemProfitChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ItemProfitChart.Series.Add(series2);
            this.ItemProfitChart.Size = new System.Drawing.Size(253, 163);
            this.ItemProfitChart.TabIndex = 2;
            this.ItemProfitChart.Text = "chart1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(544, 245);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(332, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 76;
            this.label12.Text = "Total Proffit";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Controls.Add(this.ProfitLabel);
            this.panel5.Location = new System.Drawing.Point(308, 249);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(215, 190);
            this.panel5.TabIndex = 77;
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitLabel.Location = new System.Drawing.Point(19, 65);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(174, 47);
            this.ProfitLabel.TabIndex = 1;
            this.ProfitLabel.Text = "No Data";
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
            this.ViewerBackButton.TabIndex = 80;
            this.ViewerBackButton.Text = "Back";
            this.ViewerBackButton.UseVisualStyleBackColor = false;
            this.ViewerBackButton.Click += new System.EventHandler(this.ViewerBackButton_Click);
            // 
            // EventItemListBox
            // 
            this.EventItemListBox.FormattingEnabled = true;
            this.EventItemListBox.Location = new System.Drawing.Point(168, 60);
            this.EventItemListBox.Name = "EventItemListBox";
            this.EventItemListBox.Size = new System.Drawing.Size(134, 381);
            this.EventItemListBox.TabIndex = 81;
            this.EventItemListBox.SelectedIndexChanged += new System.EventHandler(this.EventItemListBox_SelectedIndexChanged);
            // 
            // ItemViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EventItemListBox);
            this.Controls.Add(this.ViewerBackButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FormHeader);
            this.Controls.Add(this.ManagerViewerButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.EmployeeViewerButton);
            this.Controls.Add(this.StoreViewerButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ItemViewer";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.FormHeader.ResumeLayout(false);
            this.FormHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesChart)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemProfitChart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel FormHeader;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ManagerViewerButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button EmployeeViewerButton;
        private System.Windows.Forms.Button StoreViewerButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button ViewerBackButton;
        private System.Windows.Forms.ListBox EventItemListBox;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ItemProfitChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SalesChart;
        private System.Windows.Forms.Label StoresStockingTextBox;
        private System.Windows.Forms.Label UnitsSoldTextBox;
        private System.Windows.Forms.Label ProffitPerUnitTextBox;
        private System.Windows.Forms.Label SalePriceTextBox;
        private System.Windows.Forms.Label WholesalePriceTextBox;
    }
}