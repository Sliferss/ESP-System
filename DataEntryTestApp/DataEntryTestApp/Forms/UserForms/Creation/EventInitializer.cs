﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DataEntryTestApp
{
    public partial class EventInitializer : Initializer
    {
        public Event newEvent;
        List<Event> eventsTest = new List<Event>();

        public EventInitializer(string _eventName)
        {
            newEvent = new Event(_eventName);
            InitializeComponent();
            LoadEvent();
            EventNameTextBox.Text = _eventName;
        }

        //updates all fields displayed to represent new data
        public void UpdatePageContents()
        {
            ClearListBoxContents();
            StaffMemberLabel.Text = newEvent.GetEmployeeCount().ToString();
            StoresLabel.Text = newEvent.GetStoreCount().ToString();
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
                ListBoxInsert(ManagerListBox, newEvent.GetManagerName(foo));
                ListBoxInsert(StoreListBox,foo.storeName);
            }
            foreach(Item bar in newEvent.eventItems)
            {
                ListBoxInsert(ItemListBox, bar.name);
            }
            foreach(Staff baz in newEvent.staffMembers)
            {
                ListBoxInsert(EmployeeListBox, baz.name);
            }
        }

        //called by child forms, updates the event stored to reflect changes
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
            if(newEvent.StoresExist())
            {
                eventsTest.Add(newEvent);
                SaveEvent();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                SetError(ELabel, "No Stores Assigned");
            }
        }

        void SaveEvent()
        {
            try
            {
                using (Stream stream = File.Open("Event.dat", FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(stream, eventsTest);
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }

        }

        void LoadEvent()
        {
            try
            {
                using (Stream stream = File.Open("Event.dat", FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    eventsTest = (List<Event>)bf.Deserialize(stream);
                    stream.Close();
                }
            }
            catch (IOException)
            {
            }
        }
    }
}
