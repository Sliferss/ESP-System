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
    public partial class EventInitializer : BaseForm
    {
        public Event newEvent;

        public EventInitializer(string _eventName)
        {
            newEvent = new Event(_eventName);
            InitializeComponent();
            EventNameTextBox.Text = _eventName;
        }

        //updates all fields displayed to represent new data
        public void UpdatePageContents()
        {
            ClearListBoxContents();
            StaffMemberLabel.Text = newEvent.staffMembers.Count().ToString();
            StoresLabel.Text = newEvent.stores.Count().ToString();
            FillListBoxContents();
        }
        
        //clears all list boxes for reseting
        public void ClearListBoxContents()
        {
            ManagerListBox.Items.Clear();
            StoreListBox.Items.Clear();
            ItemListBox.Items.Clear();
            EmployeeListBox.Items.Clear();
        }

        //fills list boxes on page
        public void FillListBoxContents()
        {
            foreach(Store foo in newEvent.stores)
            {
                ManagerListBox.Items.Add(foo.manager.name);
                StoreListBox.Items.Add(foo.storeName);
            }
            foreach(Item bar in newEvent.eventItems)
            {
                ItemListBox.Items.Add(bar.name);
            }
            foreach(Staff baz in newEvent.staffMembers)
            {
                EmployeeListBox.Items.Add(baz.name);
            }
        }

        //gives 
        public void UpdateEvent(Event _event)
        {
            newEvent = _event;
        }

        private void FormHeader_MouseUp(object sender, MouseEventArgs e)
        {
            HeaderMouseUpAction();
        }

        private void FormHeader_MouseDown(object sender, MouseEventArgs e)
        {
            HeaderMouseDownAction();
        }

        private void FormHeader_MouseMove(object sender, MouseEventArgs e)
        {
            HeaderMouseMoveAction();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeAction();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("store", this, newEvent);
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("employee", this, newEvent);
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("item", this, newEvent);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(newEvent.stores.Count != 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                ELabel.Text = "Error: No Stores Assigned";
            }
        }
    }
}
