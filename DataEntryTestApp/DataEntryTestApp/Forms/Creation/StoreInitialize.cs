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
    public partial class StoreInitialize : BaseForm
    {
        EventInitializer parentRef;
        Event eventRef;
        Store newStore;
        String previousManager = "";
        bool submitPushed = false;
        public StoreInitialize(EventInitializer _parentRef, Event _event)
        {
            parentRef = _parentRef;
            eventRef = _event;
            InitializeComponent();
            UpdatePageContents();
            ResetLocalStore();
        }

        //resets local event and all data on form;
        public void ResetLocalStore()
        {
            newStore = new Store();
            StoreNameTextBox.Clear();
            ManagerComboBox.SelectedIndex = -1;
            StaffComboBox.SelectedIndex = -1;
            ItemComboBox.SelectedIndex = -1;
            StockTextBox.Clear();
            StaffListBox.Items.Clear();
            ItemsListBox.Items.Clear();
            previousManager = "";
        }

        public void ResetItemComboBox()
        {
            ItemComboBox.Items.Clear();
            foreach (Item foo in eventRef.eventItems)
            {
                ItemComboBox.Items.Add(foo.name);
            }
        }


        //updates all comobo boxes on the page to reflect all options
        public void UpdatePageContents()
        {
            foreach(Staff foo in eventRef.staffMembers)
            {
                if(!foo.used)
                {
                    ManagerComboBox.Items.Add(foo.name);
                    StaffComboBox.Items.Add(foo.name);
                }
            }
            foreach(Store bar in eventRef.stores)
            {
                StoreListBox.Items.Add(bar.storeName);
            }
            ResetItemComboBox();
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

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("employee", parentRef, eventRef);
        }

        private void ItemButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("item", parentRef, eventRef);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UnhideEventInitializer(parentRef);
        }

        //adds staff name to list box, and staff object to local staff var
        private void StaffAddButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (StaffComboBox.SelectedIndex != -1)
            {
                string staffName = StaffComboBox.SelectedItem.ToString();
                newStore.staffOnDuty.Add(eventRef.staffMembers.First(foo => foo.name == staffName));
                StaffListBox.Items.Add(staffName);
                AddStaffUpdateForm();
                StaffComboBox.SelectedIndex = -1;
            }
            else
            {
                ErrorLabel.Text = "Error: No Staff Selected";
            }
        }

        //adds item name to local list, adds item object to local Store object
        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            try
            {
                if(ItemComboBox.SelectedIndex != -1)
                {
                    string itemName = ItemComboBox.SelectedItem.ToString();
                    Item foo = eventRef.eventItems.First(bar => bar.name == itemName);
                    int faz = int.Parse(StockTextBox.Text);
                    StoreItem newItem = new StoreItem(foo, faz);
                    newStore.inventory.Add(newItem);
                    ItemsListBox.Items.Add(itemName);
                    ItemComboBox.Items.Remove(itemName);
                    ItemComboBox.SelectedIndex = -1;
                    StockTextBox.Text = "";
                }
                else
                {
                    ErrorLabel.Text = "Error: No item Selected";
                }
            }
            catch(Exception errorMessage)
            {
                ErrorLabel.Text = "Error: " + errorMessage.Message;           
            }
        }

        private void SubmitStorebutton_Click(object sender, EventArgs e)
        {
            if(ManagerComboBox.SelectedIndex != -1)
            {
                newStore.manager = eventRef.staffMembers.First(foo => foo.name == ManagerComboBox.SelectedItem.ToString());
                if(newStore.staffOnDuty.Count != 0)
                {
                    if(newStore.inventory.Count != 0)
                    {
                        if(StoreNameTextBox.Text != "")
                        {
                            submitPushed = true;
                            newStore.storeName = StoreNameTextBox.Text;
                            eventRef.stores.Add(newStore);
                            UpdateStaffUsed();
                            parentRef.UpdateEvent(eventRef);
                            StoreListBox.Items.Add(newStore.storeName);
                            StoreNameTextBox.Text = "";
                            ManagerComboBox.SelectedIndex = -1;
                            StaffComboBox.SelectedIndex = -1;
                            ItemComboBox.SelectedIndex = -1;
                            StockTextBox.Text = "";
                            StaffListBox.Items.Clear();
                            ItemsListBox.Items.Clear();
                            ManagerComboBox.Items.Remove(newStore.manager.name);
                            newStore = new Store();
                            previousManager = "";
                            submitPushed = false;
                            ResetItemComboBox();
                        }
                        else
                        {
                            ErrorLabel.Text = "Error: No Store Name Assigned";
                        }
                    }
                    else
                    {
                        ErrorLabel.Text = "Error: No Items Assigned";
                    }
                }
                else
                {
                    ErrorLabel.Text = "Error: No Staff Assigned";
                }
            }
            else
            {
                ErrorLabel.Text = "Error: No Manager Assigned";
            }
        }

        //when manager is selected, updates form to prevent duplication
        private void ManagerComboBox_TextChanged(object sender, EventArgs e)
        {
            if(!submitPushed)
            {
                if (previousManager == "") // if there is no previous manager
                {
                    previousManager = ManagerComboBox.SelectedItem.ToString();
                    StaffComboBox.Items.Remove(ManagerComboBox.SelectedItem.ToString());
                }
                else // had previous manager
                {
                    StaffComboBox.Items.Add(previousManager);
                    previousManager = ManagerComboBox.SelectedItem.ToString();
                    StaffComboBox.Items.Remove(ManagerComboBox.SelectedItem.ToString());
                }
            }
        }
        
        //when staff member is added to store, stops that staff member from being re-added 
        //to the same store as a staff member or as a manager
        private void AddStaffUpdateForm()
        {
            ManagerComboBox.Items.Remove(StaffComboBox.SelectedItem.ToString());
            StaffComboBox.Items.Remove(StaffComboBox.SelectedItem.ToString());
        }

        //sets all used staff to true (managers and staff members), called on submit
        private void UpdateStaffUsed()
        {
            foreach(Staff foo in newStore.staffOnDuty)
            {
                eventRef.staffMembers.First(bar => foo == bar).used = true;
            }
            eventRef.staffMembers.First(baz => baz == newStore.manager).used = true;
        }
    }
}
