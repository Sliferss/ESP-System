using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataEntryTestApp
{
    public partial class ManagerViewer : BaseForm
    {
        public EventViewer parentReference;
        public Event storedEvent;
        public List<Staff> managers = new List<Staff>();

        public ManagerViewer(EventViewer _temp, Event _eventData)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            FillManagerListBox();
            UpdatePageData(managers[0]);
        }

        //constrcutor for form open with targeted manager
        public ManagerViewer(EventViewer _temp, Event _eventData, Staff _manager)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            FillManagerListBox();
            UpdatePageData(_manager);
        }

        //updates all data on page based on selected manager
        private void UpdatePageData(Staff _manager)
        {
            NameTextBox.Text = _manager.name;
            SalaryTextBox.Text = FormatNumber(_manager.pay);
            StoreNameTextBox.Text = GetStoreName(_manager);
            FillStaffListBox(_manager);
        }

        private string GetStoreName(Staff _manager)
        {
            foreach(Store foo in storedEvent.stores)
            {
                if(foo.manager == _manager)
                {
                    return foo.storeName;
                }
            }
            return "no data found";
        }

        //get the name of the manager for each store and adds them to the list box
        private void FillManagerListBox()
        {
            foreach (Store foo in storedEvent.stores)
            {
                ManagerListBox.Items.Add(foo.manager.name);
                managers.Add(foo.manager);
            }
        }

        //get the names of all staff under the selected manager
        private void FillStaffListBox(Staff _manager)
        {
            EmployeeListBox.Items.Clear();
            foreach (Store foo in storedEvent.stores)
            {
                if (foo.manager == _manager)
                {
                    foreach (Staff bar in foo.staffOnDuty)
                    {
                        EmployeeListBox.Items.Add(bar.name);
                    }
                    break;
                }
            }
        }


        private void FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            HeaderMouseMoveAction();
        }

        private void FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            HeaderMouseUpAction();
        }

        private void FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            HeaderMouseDownAction();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeAction();
        }

        private void StoresViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("store", parentReference, storedEvent);
        }

        private void EmployeeViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("employee", parentReference, storedEvent);
        }

        private void ItemViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("item", parentReference, storedEvent);
        }

        private void ViewerBackButton_Click(object sender, EventArgs e)
        {
            UnhideEventViewer(parentReference);
        }

        //opens data on clicked manager
        private void ManagerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ManagerListBox.SelectedIndex != -1)
            {
                UpdatePageData(managers[ManagerListBox.SelectedIndex]);
                ManagerListBox.SetSelected(ManagerListBox.SelectedIndex, false);
            }
        }

        //opens store viewer using clicked store 
        private void StoreNameTextBox_Click(object sender, EventArgs e)
        {
            windowPosition = this.Location;
            Store foo = storedEvent.stores.First(bar => bar.storeName == StoreNameTextBox.Text);
            StoreViewer newForm = new StoreViewer(parentReference, storedEvent, foo);
            this.Hide();
            newForm.Location = windowPosition;
            newForm.ShowDialog();
            this.Close();
        }

        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            windowPosition = this.Location;
            Staff foo = storedEvent.staffMembers.First(bar => bar.name == EmployeeListBox.SelectedItem.ToString());
            Form newForm = new Form(parentReference, storedEvent, foo);
            this.Hide();
            newForm.Location = windowPosition;
            newForm.ShowDialog();
            this.Close();
        }
    }
}
