using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataEntryTestApp
{
    public partial class EventViewer : BaseForm
    {
        Event storedEvent;
   
        public EventViewer(Event _event)
        {
            storedEvent = _event;
            InitializeComponent();
            UpdatePageData();
        }

        private void FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            HeaderMouseDownAction();
        }

        private void FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            HeaderMouseUpAction();
        }

        private void FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            HeaderMouseMoveAction();
        }

        private void _button_Click(object sender, EventArgs e)
        {
            MinimizeAction();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        //updates all catagories on current page
        public void UpdatePageData()
        {
            EventNameBox.Text = storedEvent.eventName;
            EmployeeCountTextBox.Text = storedEvent.staffMembers.Count.ToString();
            SoldItemTextBox.Text = SoldItemCount().ToString();
            StoreCountTextBox.Text = storedEvent.stores.Count.ToString();
            ProductCostTextBox.Text = FormatNumber(InitialInvestmentCalc());
            UniqueItemCountTextBox.Text = storedEvent.eventItems.Count.ToString();
            ProffitLabel.Text = FormatNumber(storedEvent.GetEventProfit());
            FillStoreBarChart(SumStoreProfChart);
            FillProffitPieChart(InvestmentCompareChart);
        }

        //counts the number of items sold
        public int SoldItemCount()
        {
            int total = 0;
            foreach(Store foo in storedEvent.stores)
            {
                foreach(StoreItem bar in foo.inventory)
                {
                    total += bar.sold;
                }
            }
            return total;
        }

        //calculates the wholesale cost of all stock at the event
        public float InitialInvestmentCalc()
        {
            float total = 0f;
            foreach (Store foo in storedEvent.stores)
            {
                foreach (StoreItem bar in foo.inventory)
                {
                    total += bar.stock;
                }
            }
            return total;
        }

        //generates the store bar chart
        public void FillStoreBarChart(Chart _targetChart) // chart, seriesName, xvalueName, yValueName, title, 
        {
            _targetChart.Series.Clear();
            _targetChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            _targetChart.Series.Add("Stores");
            _targetChart.Titles.Add("Store Profit");

            if (storedEvent.stores.Count != 0)
            {
                DataPoint foo = new DataPoint();
                for (int i = 0; i != storedEvent.stores.Count; i++)
                {
                    foo = new DataPoint();
                    foo.SetValueXY(storedEvent.stores[i].storeName, storedEvent.stores[i].GetProfit());
                    _targetChart.Series["Stores"].Points.Add(foo);
                }
            }
        }

        //generates the return pie chart
        public void FillProffitPieChart(Chart _targetChart)
        {
            _targetChart.Series.Clear();
            _targetChart.Series.Add("series1");
            _targetChart.Series[0].ChartType = SeriesChartType.Pie;
            _targetChart.Series[0]["PieLabelStyle"] = "Disabled";
            _targetChart.Series[0].Points.AddXY("Investment", storedEvent.GetEventInvestment());
            _targetChart.Series[0].Points.AddXY("Profit", storedEvent.GetEventProfit());
        }

        private void ViewerBackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void StoreViewButton_Click(object sender, EventArgs e)
        {
            ShowViewer("store", this, storedEvent);
        }

        private void EmployyeViewButton_Click(object sender, EventArgs e)
        {
            ShowViewer("employee", this, storedEvent);
        }

        private void ItemViewButton_Click(object sender, EventArgs e)
        {
            ShowViewer("item", this, storedEvent);
        }

        private void ManagerViewButton_Click(object sender, EventArgs e)
        {
            ShowViewer("manager", this, storedEvent);
        }
    }
}
