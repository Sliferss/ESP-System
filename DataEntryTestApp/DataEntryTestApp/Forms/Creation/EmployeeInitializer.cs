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
    public partial class EmployeeInitializer : BaseForm
    {
        EventInitializer parentRef;
        Event eventRef;
        public EmployeeInitializer(EventInitializer _parentRef, Event _event)
        {
            parentRef = _parentRef;
            eventRef = _event;
            InitializeComponent();
            UpdateListContents();
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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        private void StoreButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("store", parentRef, eventRef);
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("item", parentRef, eventRef);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UnhideEventInitializer(parentRef);
        }

        //adds employee to new event, and updates list on page
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(CheckForFields())
                {
                    Staff foo = new Staff(NameTextBox.Text, (float.Parse(PayTextBox.Text)));
                    eventRef.staffMembers.Add(foo);
                    parentRef.UpdateEvent(eventRef);
                    EmployeeListBox.Items.Add(foo.name);
                    ErrorLabel.Text = "";
                    PayTextBox.Text = "";
                    NameTextBox.Text = "";
                }
            }
            catch(Exception bar)
            {
                ErrorLabel.Text = "Error: " + bar.Message;
            }
        }

        private bool CheckForFields()
        {
            if(NameTextBox.Text != "")
            {
                if (PayTextBox.Text != "")
                {
                    ErrorLabel.Text = "Correct";
                    return true;
                }
                else
                {
                    ErrorLabel.Text = "Error: No Pay Assigned";
                    return false;
                }
            }
            else
            {
                ErrorLabel.Text = "Error: No Name Assigned";
                return false;
            }
        }

        //updates full list on start
        private void UpdateListContents()
        {
            foreach(Staff foo in eventRef.staffMembers)
            {
                EmployeeListBox.Items.Add(foo.name);
            }
        }
    }
}
