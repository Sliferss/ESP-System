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
    public partial class EmployeeInitializer : Initializer
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
                    if(float.Parse(PayTextBox.Text) >= 0)
                    {
                        Staff foo = new Staff(NameTextBox.Text, (float.Parse(PayTextBox.Text)));
                        eventRef.staffMembers.Add(foo);
                        parentRef.UpdateEvent(eventRef);
                        ListBoxInsert(EmployeeListBox, foo.name);
                        ClearErrorLabel(ErrorLabel);
                        PayTextBox.Text = "";
                        NameTextBox.Text = "";
                    }
                    else
                    {
                        SetError(ErrorLabel, "Pay Cannot Be < 0");
                    }
                }
            }
            catch(Exception bar)
            {
                SetError(ErrorLabel, bar.Message);
            }
        }

        //checks that no fields are empty for progression
        private bool CheckForFields()
        {
            if(NameTextBox.Text != "")
            {
                if (PayTextBox.Text != "")
                {
                    return true;
                }
                else
                {
                    SetError(ErrorLabel, "No Pay Assigned");
                    return false;
                }
            }
            else
            {
                SetError(ErrorLabel, "No Name Assigned");
                return false;
            }
        }

        //updates full list on start
        private void UpdateListContents()
        {
            foreach(Staff foo in eventRef.staffMembers)
            {
                ListBoxInsert(EmployeeListBox, foo.name);
            }
        }
    }
}
