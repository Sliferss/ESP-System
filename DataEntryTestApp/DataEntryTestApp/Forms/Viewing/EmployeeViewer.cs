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
    public partial class Form : BaseForm
    {
        public EventViewer parentReference;
        public Event storedEvent;
        public List<Staff> storedStaff = new List<Staff>();

        //base constructor, opens the first staff member in the list
        public Form(EventViewer _temp, Event _eventData)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            GenerateStaffList();
            UpdatePageData(storedEvent.staffMembers[0]);
        }

        //targeted constructor, opens the form with specified staff open
        public Form(EventViewer _temp, Event _eventData, Staff _target)
        {
            parentReference = _temp;
            storedEvent = _eventData;
            InitializeComponent();
            GenerateStaffList();
            UpdatePageData(_target);
        }

        //updates all statistical data on the page based on the staff
        private void UpdatePageData(Staff _staff)
        {
            StaffNameLabel.Text = _staff.name;
            SalaryLabel.Text = FormatNumber(_staff.pay);
            StoreLabel.Text = GetStoreName(_staff);
        }

        //gets the store name of the store target staff is working on
        private string GetStoreName(Staff _staff)
        {
            foreach(Store foo in storedEvent.stores)
            {
                if(foo.staffOnDuty.Contains(_staff))
                {
                    return foo.storeName;
                }
            }
            return "no data";
        }

        //generates a list of all staff members
        private void GenerateStaffList()
        {
            foreach(Store foo in storedEvent.stores)
            {
                foreach(Staff bar in foo.staffOnDuty)
                {
                    StaffListBox.Items.Add(bar.name);
                    storedStaff.Add(bar);

                }
            }
        }

        //invokes UpdatePageData using the clicked staff member off the list as the passed parameter 
        private void StaffListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StaffListBox.SelectedIndex != -1)
            {
                UpdatePageData(storedStaff[StaffListBox.SelectedIndex]);
                StaffListBox.SetSelected(StaffListBox.SelectedIndex, false);
            }
        }

        //opens store form using the targeted store as the open parameter
        private void StoreLabel_MouseClick(object sender, MouseEventArgs e)
        {
            windowPosition = this.Location;
            Store foo = storedEvent.stores.First(bar => bar.storeName == StoreLabel.Text);
            StoreViewer newForm = new StoreViewer(parentReference, storedEvent, foo);
            this.Hide();
            newForm.Location = windowPosition;
            newForm.ShowDialog();
            this.Close();
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

        private void ItemViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("item", parentReference, storedEvent);
        }

        private void ManagerViewerButton_Click(object sender, EventArgs e)
        {
            ShowViewer("manager", parentReference, storedEvent);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UnhideEventViewer(parentReference);
        }
    }
}
