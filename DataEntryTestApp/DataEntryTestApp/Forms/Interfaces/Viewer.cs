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
    public partial class Viewer : BaseForm
    {
        //used on back button on any viewer but the event viewer
        protected void UnhideEventViewer(EventViewer _temp)
        {
            if (!_temp.Visible)
            {
                windowPosition = this.Location;
                this.Hide();
                _temp.Location = windowPosition;
                _temp.Show();
                this.Close();
            }
        }
        //creates a new window when navigating child forms to the event viewer, on child is true if
        protected void ShowViewer(string type, EventViewer _temp, Event _eventData)
        {
            windowPosition = this.Location;
            System.Windows.Forms.Form newForm = new System.Windows.Forms.Form();

            switch (type.ToLower())
            {
                case "store":
                    newForm = new StoreViewer(_temp, _eventData);
                    break;
                case "item":
                    newForm = new ItemViewer(_temp, _eventData);
                    break;
                case "employee":
                    newForm = new Form(_temp, _eventData);
                    break;
                case "manager":
                    newForm = new ManagerViewer(_temp, _eventData);
                    break;
            }
            this.Hide();
            newForm.Location = windowPosition;
            newForm.ShowDialog();
            if (!(this is EventViewer)) // if the current open page is not an event viewer
            {
                this.Close();
            }
        }

        //gets string selected on the list
        protected string GetListBoxSelected(ListBox _target)
        {
            return _target.SelectedItem.ToString();
        }
    }
}
