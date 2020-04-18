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
    public partial class StoreInitialize : Initializer
    {
        EventInitializer parentRef;
        Event eventRef;
        Store newStore;
        String previousManager = "";
        bool submitPushed = false;

        //copy constructor
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
            DeselectComboBox(ManagerComboBox);
            DeselectComboBox(StaffComboBox);
            DeselectComboBox(ItemComboBox);
            StockTextBox.Clear();
            ListBoxClear(StaffListBox);
            ListBoxClear(ItemsListBox);
            previousManager = "";
        }

        //resets items in combo box to be up to date
        public void ResetItemComboBox()
        {
            ItemComboBox.Items.Clear();
            foreach (Item foo in eventRef.eventItems)
            {
                ComboBoxInsert(ItemComboBox, foo.name);
            }
        }


        //updates all comobo boxes on the page to reflect all options
        public void UpdatePageContents()
        {
            foreach(Staff foo in eventRef.staffMembers)
            {
                if(!foo.used)
                {
                    ComboBoxInsert(ManagerComboBox, foo.name);
                    ComboBoxInsert(StaffComboBox, foo.name);
                }
            }
            foreach(Store bar in eventRef.stores)
            {
                ListBoxInsert(StoreListBox, bar.storeName);
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
            if (CheckCBSelected(StaffComboBox))
            {
                string staffName = GetCBSelected(StaffComboBox);


                newStore.staffOnDuty.Add(eventRef.GetStaffByName(staffName));
                ListBoxInsert(StaffListBox, staffName);
                AddStaffUpdateForm();
                DeselectComboBox(StaffComboBox);
            }
            else
            {
                SetError(ErrorLabel, "No Staff Selected");
            }
        }

        //adds item name to local list, adds item object to local Store object
        private void ItemAddButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            try
            {
                if(CheckCBSelected(ItemComboBox))
                {
                    if(int.Parse(StockTextBox.Text) > 0)
                    {
                        string itemName = GetCBSelected(ItemComboBox);
                        Item foo = eventRef.GetItemByName(itemName);
                        int bar = int.Parse(StockTextBox.Text);
                        StoreItem newItem = new StoreItem(foo, bar);
                        newStore.AddItemToInventory(newItem);
                        ListBoxInsert(ItemsListBox, itemName);
                        ComboBoxRemove(ItemComboBox, itemName);
                        DeselectComboBox(ItemComboBox);
                        StockTextBox.Text = "";
                    }
                    else
                    {
                        SetError(ErrorLabel, "Item Stock Cannot Be Less Than One");
                    }
                }
                else
                {
                    SetError(ErrorLabel, "No Item Selected");
                }
            }
            catch(Exception errorMessage)
            {
                SetError(ErrorLabel, errorMessage.Message);   
            }
        }

        //checks all fields are complete for submission to server
        
        private void SubmitStorebutton_Click(object sender, EventArgs e)
        {
            if(CheckCBSelected(ManagerComboBox))
            {
                newStore.manager = eventRef.GetStaffByName(GetCBSelected(ManagerComboBox));
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
                            ListBoxInsert(StoreListBox, newStore.storeName);
                            StoreNameTextBox.Text = "";
                            DeselectComboBoxes(new List<ComboBox>() { ManagerComboBox, StaffComboBox, ItemComboBox });
                            StockTextBox.Text = "";
                            ListBoxClear(StaffListBox);
                            ListBoxClear(ItemsListBox);
                            ComboBoxRemove(ManagerComboBox, newStore.manager.name);
                            newStore = new Store();
                            previousManager = "";
                            submitPushed = false;
                            ResetItemComboBox();
                        }
                        else
                        {
                            SetError(ErrorLabel, "No Store Name Assigned");
                        }
                    }
                    else
                    {
                        SetError(ErrorLabel, "No Items Assigned");
                    }
                }
                else
                {
                    SetError(ErrorLabel, "No Staff Assigned");
                }
            }
            else
            {
                SetError(ErrorLabel, "No Manager Assigned");
            }
        }

        //when manager is selected, updates form to prevent duplication
        private void ManagerComboBox_TextChanged(object sender, EventArgs e)
        {
            if(!submitPushed)
            {
                if (previousManager == "") // if there is no previous manager
                {
                    previousManager = GetCBSelected(ManagerComboBox);
                    ComboBoxRemove(StaffComboBox, previousManager);
                }
                else // had previous manager
                {
                    ComboBoxInsert(StaffComboBox, previousManager);
                    previousManager = GetCBSelected(ManagerComboBox);
                    ComboBoxRemove(StaffComboBox, previousManager);
                }
            }
        }
        
        //when staff member is added to store, stops that staff member from being re-added 
        //to the same store as a staff member or as a manager
        private void AddStaffUpdateForm()
        {
            ComboBoxRemove(ManagerComboBox, GetCBSelected(StaffComboBox));
            ComboBoxRemove(StaffComboBox, GetCBSelected(StaffComboBox));
        }

        //sets all used staff to true (managers and staff members), called on submit
        private void UpdateStaffUsed()
        {
            foreach(Staff foo in newStore.staffOnDuty)
            {
                eventRef.SetStaffMemberUsed(foo);
            }
            eventRef.SetStaffMemberUsed(newStore.manager);
        }
    }
}
