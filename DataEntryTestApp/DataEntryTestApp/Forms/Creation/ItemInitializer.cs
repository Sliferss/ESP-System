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
    public partial class ItemInitializer : BaseForm
    {
        EventInitializer parentRef;
        Event eventRef;
        public ItemInitializer(EventInitializer _parentRef, Event _event)
        {
            parentRef = _parentRef;
            eventRef = _event;
            InitializeComponent();
            UpdateListContents();
        }

        //called on start, updates the contents of the display list
        private void UpdateListContents()
        {
            ItemListBox.Items.Clear();
            foreach(Item foo in eventRef.eventItems)
            {
                ItemListBox.Items.Add(foo.name);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitAction();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            MinimizeAction();
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

        private void StoreButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("store", parentRef, eventRef);
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            ShowInitializer("employee", parentRef, eventRef);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UnhideEventInitializer(parentRef);
        }

        //adds item to event item list
        private void AddButon_Click(object sender, EventArgs e)
        {
            try
            {
                if(ItemNameTextBox.Text != "")
                {
                    if(WholeSaleTextBox.Text != "")
                    {
                        if(SaleTextBox.Text != "")
                        {
                            if (float.Parse(WholeSaleTextBox.Text) < float.Parse(SaleTextBox.Text))
                            {
                                Item foo = new Item(ItemNameTextBox.Text, float.Parse(WholeSaleTextBox.Text), float.Parse(SaleTextBox.Text));
                                eventRef.eventItems.Add(foo);
                                parentRef.UpdateEvent(eventRef);
                                ItemListBox.Items.Add(foo.name);
                                ItemNameTextBox.Clear();
                                WholeSaleTextBox.Clear();
                                SaleTextBox.Clear();
                            }
                            else
                            {
                                ErrorLabel.Text = "Error: Item sold for less than or equal to wholesale";
                            }
                        }
                        else
                        {
                            ErrorLabel.Text = "Error: No Sale Value Assigned";
                        }
                    }
                    else
                    {
                        ErrorLabel.Text = "Error: No Wholesale Value Assigned";
                    }
                }
                else
                {
                    ErrorLabel.Text = "Error: No Item Name Assigned";
                }
                
            }
            catch(Exception eMessage)
            {
                ErrorLabel.Text = "Error: " + eMessage.Message;
            }
           
        }
    }
}
