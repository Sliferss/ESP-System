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
    public partial class StoreViewer : Viewer
    {
        public EventViewer parentReference;
        public Event storedEvent;

        public StoreViewer(EventViewer _temp, Event _eventData)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            GenerateTable();
            UpdatePageData(storedEvent.stores[0]);
        }

        //opens a store viewer with target store open
        public StoreViewer(EventViewer _temp, Event _eventData, Store _store)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            GenerateTable();
            UpdatePageData(_store);
        }

        private void GenerateTable()
        {
            foreach (Store store in storedEvent.stores)
            {
                ListBoxInsert(StoreListBox, store.storeName);
            }
        }

        private void FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            HeaderMouseDownAction();
        }

        private void FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            HeaderMouseMoveAction();
        }

        private void FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            HeaderMouseUpAction();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeAction();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        //updates all data on page to specified store
        public void UpdatePageData(Store _store)
        {
            ListBoxClear(StaffMemberListBox);
            ListBoxClear(InventoryListBox);

            StoreNameTextBox.Text = _store.storeName;
            ManagerNameTextBox.Text = _store.manager.name;
            StaffNumTextBox.Text = (_store.staffOnDuty.Count() + 1).ToString();
            SoldCountTextBox.Text = _store.GetItemSoldCount().ToString();
            UniqueCountTextBox.Text = _store.inventory.Count().ToString();
            StockCostTextBox.Text = FormatNumber(_store.GetInvestmentOnInventory());
            StaffMemberListBox.Items.Add(_store.manager.name);
            foreach(Staff _tempStaff in _store.staffOnDuty)
            {
                ListBoxInsert(StaffMemberListBox, _tempStaff.name);
            }
            foreach(StoreItem _tempStoreItem in _store.inventory)
            {
                ListBoxInsert(InventoryListBox, _tempStoreItem.item.name);
            }
            StoreProfitLabel.Text = FormatNumber(_store.GetProfit());
            FillBarChart(ItemProfitChart, _store);
        }

        //fills multi series bar chart
        public void FillBarChart(Chart _targetChart, Store _store)
        {
            StoreItem tempItem;
            _targetChart.Series.Clear();
            _targetChart.Titles.Clear();
            _targetChart.Titles.Add("Item Summary:");
            _targetChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            _targetChart.Series.Add("Investment");
            _targetChart.Series.Add("Profit");

            _targetChart.Series["Investment"].Color = Color.FromArgb(168, 168, 168);
            _targetChart.Series["Profit"].Color = Color.FromArgb(64, 64, 64);

            if (_store.inventory.Count != 0)
            {
                for (int i = 0; i != _store.inventory.Count; i++)
                {
                    tempItem = _store.inventory[i];
                    _targetChart.Series["Investment"].Points.AddXY(tempItem.item.name, tempItem.item.buyPrice * tempItem.stock);
                    _targetChart.Series["Profit"].Points.AddXY(tempItem.item.name, tempItem.GetProfitOfItem());
                }
                _targetChart.AlignDataPointsByAxisLabel();
            }
            _targetChart.ChartAreas[0].RecalculateAxesScale();
        }

        private void StoreListBox_MouseClick(object sender, MouseEventArgs e)
        {
            if(StoreListBox.SelectedIndex != -1)
            {
                UpdatePageData(storedEvent.stores[StoreListBox.SelectedIndex]);
                StoreListBox.SetSelected(StoreListBox.SelectedIndex, false);
            }
        }

        private void EmployeeViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("employee", parentReference, storedEvent);
        }

        private void ItemViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("item", parentReference, storedEvent);
        }

        private void ManagerViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("manager", parentReference, storedEvent);
        }

        private void ViewerBackButton_Click(object sender, EventArgs e)
        {
            UnhideEventViewer(parentReference);
        }

        //click staff member off of list, opens staff viewer / manager viewer on using clicked staff member
        private void StaffMemberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaffMemberListBox.SelectedIndex != -1)
            {
                windowPosition = this.Location;
                Staff foo = storedEvent.GetStaffByName(GetListBoxSelected(StaffMemberListBox));
                if (storedEvent.CheckIsManager(foo)) // staff member is manager
                {
                    ManagerViewer tempForm = new ManagerViewer(parentReference, storedEvent, foo);
                    this.Hide();
                    tempForm.Location = windowPosition;
                    tempForm.ShowDialog();
                    this.Close();
                }
                else // staff member is not manager
                {
                    Form newForm = new Form(parentReference, storedEvent, foo);
                    this.Hide();
                    newForm.Location = windowPosition;
                    newForm.ShowDialog();
                    this.Close();
                }
            }
        }

        //opens manager viewer using clicked manager as target
        private void ManagerNameTextBox_Click(object sender, EventArgs e)
        {
            windowPosition = this.Location;
            Store foo = storedEvent.GetStoreByManagerName(ManagerNameTextBox.Text);
            ManagerViewer newForm = new ManagerViewer(parentReference, storedEvent, foo.manager);
            this.Hide();
            newForm.Location = windowPosition;
            newForm.ShowDialog();
            this.Close();
        }

        private void InventoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CheckItemSelected(InventoryListBox))
            {
                windowPosition = this.Location;
                Item foo = storedEvent.GetItemByName(GetListBoxSelected(InventoryListBox));
                ItemViewer tempForm = new ItemViewer(parentReference, storedEvent, foo);
                this.Hide();
                tempForm.Location = windowPosition;
                tempForm.ShowDialog();
                this.Close();
            }
        }
    }
}
