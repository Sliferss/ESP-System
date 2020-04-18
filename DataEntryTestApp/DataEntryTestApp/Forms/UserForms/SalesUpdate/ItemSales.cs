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
    public partial class ItemSales : BaseForm
    {
        public List<StoreItem> inventoryRef;
        public int currentTarget = 0;
        int itemCount;
        public ItemSales(List<StoreItem> _inventoryRef, string _storeName)
        {
            inventoryRef = _inventoryRef;
            itemCount = inventoryRef.Count() - 1;
            InitializeComponent();
            StoreNameTextBox.Text = _storeName;
            UpdateToItem(0);
        }

        //updates the form = to the selected item
        protected void UpdateToItem(int _target)
        {
            ItemNameTextBox.Text = inventoryRef[_target].item.name;
            StockTextBox.Text = inventoryRef[_target].stock.ToString();
            SoldTextBox.Text = inventoryRef[_target].sold.ToString();
        }

        //increments target, if is the second final target changes the button to finish, if is final taget
        //finishes data input
        private void NextButton_Click(object sender, EventArgs e)
        {
            ClearErrorLabel(ErrorLabel);
            if(CheckSoldUnderStock())
            {
                if(int.Parse(SoldTextBox.Text) > 0)
                {
                    inventoryRef[currentTarget].SetSaleCount(int.Parse(SoldTextBox.Text));
                    if (currentTarget == itemCount - 1)
                    {
                        NextButton.Text = "Finish";
                        currentTarget++;
                        UpdateToItem(currentTarget);
                    }
                    else if (currentTarget == itemCount)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        currentTarget++;
                        UpdateToItem(currentTarget);
                    }
                }
                else
                {
                    SetError(ErrorLabel, "Cannot Sell < 0");
                }
            }
        }

        //decrements target, if was on the final target, changes back to "Next Item", if is first item
        //creates error
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
            if (CheckSoldUnderStock())
            {
                if(int.Parse(SoldTextBox.Text) > 0)
                {
                    inventoryRef[currentTarget].SetSaleCount(int.Parse(SoldTextBox.Text));
                    if (currentTarget == itemCount)
                    {
                        NextButton.Text = "Next Item";
                        currentTarget--;
                        UpdateToItem(currentTarget);
                    }
                    else if (currentTarget == 0)
                    {
                        SetError(ErrorLabel, "No Previous Item");
                    }
                    else
                    {
                        currentTarget--;
                        UpdateToItem(currentTarget);
                    }
                }
                else
                {
                    SetError(ErrorLabel, "Cannot Sell < 0");
                }
                
            }
        }

        //if stock is greater than sold on an action, then it stops any advancement until the 
        //user corrects, and shows this error in the error label
        private bool CheckSoldUnderStock()
        {
            try
            {
                if (int.Parse(StockTextBox.Text) < int.Parse(SoldTextBox.Text))
                {
                    SetError(ErrorLabel, "Cannot Sell More Than Stocked");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch(Exception errorMessage)
            {
                SetError(ErrorLabel, errorMessage.Message);
                return false;
            }
        }
    }
}
