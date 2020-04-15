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
    public partial class ModeSelection : BaseForm
    {
       
        List<Event> events = new List<Event>(){new NoNetworkEvent("full").tempEvent};  // loads an example into application
        List<Event> incompleteEvents = new List<Event>() { new NoNetworkEvent("partial").tempEvent };
        public ModeSelection()
        {
            InitializeComponent();
            DisplayEventNames();
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

        //hides current window and opens event viewer
        private void SelectButton_Click(object sender, EventArgs e)
        {
            if(EventsListBox.SelectedIndex != -1) // checks that item is selected
            {
                this.Hide();
                using (var eventViewer = new EventViewer(events[EventsListBox.SelectedIndex]))
                {
                    switch (eventViewer.ShowDialog())
                    {
                        case DialogResult.OK:
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                this.Show();
            }
            else
            {
                ErrorLabel.Text = "No Target Selected.";
            }
        }

        //hides current window and opens event creation tool
        private void NewButton_Click(object sender, EventArgs e)
        {
            if(EventNameTextBox.TextLength != 0)
            {
                this.Hide();
                using (var eventViewer = new EventInitializer(EventNameTextBox.Text))
                {
                    switch (eventViewer.ShowDialog())
                    {
                        case DialogResult.OK:
                            UploadNewEvent(eventViewer.newEvent);
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                this.Show();
            }
            else
            {
                ErrorLabel.Text = "ERROR: No event name given.";
            }
        }

        //uploads new event to server
        private void UploadNewEvent(Event _newEvent)
        {
            //communication goes here
            //code bellow is for offline use
            incompleteEvents.Add(_newEvent);
            DisplayEventNames();
        }

        //updates event on server
        public void UpdateEvent(Event _newEvent)
        {
            //communication goes here
            //code bellow is for offline use
            events.Add(_newEvent);
            incompleteEvents.Remove(incompleteEvents.First(foo => foo.eventName == _newEvent.eventName));
            DisplayEventNames();
        }

        //adds all event names to list
        private void DisplayEventNames()
        {
            EventsListBox.Items.Clear();
            NoSaleListBox.Items.Clear();
            foreach(Event foo in events)
            {
                EventsListBox.Items.Add(foo.eventName);
            }
            foreach(Event bar in incompleteEvents)
            {
                NoSaleListBox.Items.Add(bar.eventName);
            }
        }

        private void SalesDataButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (NoSaleListBox.SelectedIndex != -1)
            {

                this.Hide();
                SalesUpdateConfirmation temp = new SalesUpdateConfirmation(incompleteEvents[NoSaleListBox.SelectedIndex], this);
                temp.ShowDialog();
            }

            else
            {
                ErrorLabel.Text = "Error: No Event Selected.";
            }
        }
    }
}
