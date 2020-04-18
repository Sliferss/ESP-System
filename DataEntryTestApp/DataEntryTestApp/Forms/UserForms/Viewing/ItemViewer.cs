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
    public partial class ItemViewer : Viewer
    {
        public EventViewer parentReference;
        public Event storedEvent;

        private int unitsSold = 0;
        private int storesStocking = 0;
        private float itemProfit = 0;
        private int unitsStocked = 0;
        public ItemViewer(EventViewer _temp, Event _eventData)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            GenerateList();
            UpdatePageData(storedEvent.eventItems[0]);
        }

        //constructor for opening form with target item
        public ItemViewer(EventViewer _temp, Event _eventData, Item _item)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            GenerateList();
            UpdatePageData(_item);
        }

        private void GenerateList()
        {
            foreach (Item item in storedEvent.eventItems)
            {
                ListBoxInsert(EventItemListBox, item.name);
            }
        }
        //updates all fields based on a selected item
        private void UpdatePageData(Item _item)
        {
            StoreSalesInfo(ItemProfitChart, _item);
            ItemNameTextBox.Text = _item.name;
            WholesalePriceTextBox.Text = FormatNumber(_item.buyPrice);
            SalePriceTextBox.Text = FormatNumber(_item.salePrice);
            ProffitPerUnitTextBox.Text = FormatNumber(_item.proffitPerUnit);
            UnitsSoldTextBox.Text = unitsSold.ToString();
            StoresStockingTextBox.Text = storesStocking.ToString();
            ProfitLabel.Text = FormatNumber(itemProfit);
            PlotPiePoints(SalesChart);
            
        }

        //gets all information about the instances of the item sold at each store
        public void StoreSalesInfo(Chart _targetChart, Item _item) // chart, seriesName, xvalueName, yValueName, title, 
        {
            unitsSold = 0;
            storesStocking = 0;
            itemProfit = 0;
            unitsStocked = 0;

            _targetChart.Series.Clear();
            _targetChart.Titles.Clear();
            _targetChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            _targetChart.Series.Add("Stores");
            _targetChart.Titles.Add("Units Sold");

            foreach(Store foo in storedEvent.stores)
            {
                foreach(StoreItem bar in foo.inventory)
                {
                    if(bar.item == _item)
                    {
                        PlotBarChartPoint(bar, foo.storeName, _targetChart);
                        unitsSold += bar.sold;
                        storesStocking += 1;
                        itemProfit += bar.GetProfitOfItem();
                        unitsStocked += bar.stock;
                        break;
                    }
                }
            }
            _targetChart.ChartAreas[0].RecalculateAxesScale();
        }
        private void PlotPiePoints(Chart _targetChart)
        {
            _targetChart.Series.Clear();
            _targetChart.Series.Add("series1");
            _targetChart.Series[0].ChartType = SeriesChartType.Pie;
            _targetChart.Series[0]["PieLabelStyle"] = "Disabled";
            _targetChart.Series[0].Points.AddXY("Sold", unitsSold);
            _targetChart.Series[0].Points.AddXY("Unsold", unitsStocked - unitsSold);
        }

        //plots point on column graph using data about store item sales
        private void PlotBarChartPoint(StoreItem _item, string _storeName, Chart _targetChart)
        {
            DataPoint foo = new DataPoint();
            foo.SetValueXY(_storeName, _item.sold);
            _targetChart.Series["Stores"].Points.Add(foo);
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

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeAction();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        private void StoreViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("store", parentReference, storedEvent);
        }

        private void EmployeeViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("employee", parentReference, storedEvent);

        }

        private void ManagerViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("manager", parentReference, storedEvent);
        }

        private void ViewerBackButton_Click(object sender, EventArgs e)
        {
            UnhideEventViewer(parentReference);
        }

        private void EventItemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (EventItemListBox.SelectedIndex != -1)
            {
                UpdatePageData(storedEvent.eventItems[EventItemListBox.SelectedIndex]);
                EventItemListBox.SetSelected(EventItemListBox.SelectedIndex, false);
            }
          
        }
    }
}
