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
    public partial class Initializer : BaseForm
    {
        public void ShowInitializer(string type, EventInitializer _temp, Event _eventData)
        {
            System.Windows.Forms.Form newForm = new System.Windows.Forms.Form();
            windowPosition = this.Location;

            switch (type.ToLower())
            {
                case "store":
                    newForm = new StoreInitialize(_temp, _eventData);
                    break;
                case "item":
                    newForm = new ItemInitializer(_temp, _eventData);
                    break;
                case "employee":
                    newForm = new EmployeeInitializer(_temp, _eventData);
                    break;
            }
            this.Hide();
            newForm.Location = windowPosition;
            newForm.ShowDialog();
            if (!(this is EventInitializer)) // if the current open page is not an event viewer
            {
                this.Close();
            }
        }

        //used to return to the parent form
        protected void UnhideEventInitializer(EventInitializer _temp)
        {
            if (!_temp.Visible)
            {
                windowPosition = this.Location;
                this.Hide();
                _temp.Location = windowPosition;
                _temp.Show();
                _temp.UpdatePageContents();
                this.Close();
            }
        }

        //deselects item in combo box
        protected void DeselectComboBox(ComboBox _target)
        {
            _target.SelectedIndex = -1;
        }

        //deselects multiple combo boxes
        protected void DeselectComboBoxes(List<ComboBox> _targets)
        {
            foreach(ComboBox foo in _targets)
            {
                DeselectComboBox(foo);
            }
        }

        //inserts item into combo box
        protected void ComboBoxInsert(ComboBox _target, string _foo)
        {
            _target.Items.Add(_foo);
        }

        protected void ComboBoxRemove(ComboBox _target, string _foo)
        {
            _target.Items.Remove(_foo);
        }

        //checks if item has been selected in combo box
        protected bool CheckCBSelected(ComboBox _target)
        {
            if(_target.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //gets data selected in combo box, should only be used if index  != -1, can cause errors if not
        protected string GetCBSelected(ComboBox _target)
        {
            return _target.SelectedItem.ToString();
        }
    }
}
