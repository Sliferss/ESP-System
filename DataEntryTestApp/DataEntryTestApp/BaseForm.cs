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
    public partial class BaseForm : System.Windows.Forms.Form
    {
        int originFormX = 0;
        int originFormY = 0;
        int originMouseX = 0;
        int originMouseY = 0;
        //is window allowed to move?
        bool mouseDown;
        public Point windowPosition = new Point();

        //called whenever the user clicks the close button on a form
        protected void ExitAction()
        {
            Application.Exit();
        }

        //called whenever the user clicks the exit button on a form
        protected void MinimizeAction()
        {
            WindowState = FormWindowState.Minimized;
        }

        //tracks the location of the mouse upon mouse down for transforming, enables HeaderMouseMoveAction
        protected void HeaderMouseDownAction()
        {
            mouseDown = true;

            originFormX = this.Location.X;
            originFormY = this.Location.Y;
            originMouseX = MousePosition.X;
            originMouseY = MousePosition.Y;
        }

        //disables HeaderMouseMoveAction
        protected void HeaderMouseUpAction()
        {
            mouseDown = false;
        }

        //transforms the location of the form based on the mouse location and the original form location on mouse down
        protected void HeaderMouseMoveAction()
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(originFormX + (MousePosition.X - originMouseX), originFormY + (MousePosition.Y - originMouseY));
            }
        }

        //inserts list into list box
        protected void ListBoxListInsert(ListBox target, List<string> list)
        {
            foreach(string item in list)
            {
                target.Items.Add(item);
            }
        }

        //formats any float into a £0.00 format
        protected string FormatNumber(float foo)
        {
            string original = foo.ToString();

            if (original.Contains("."))
            {
                string[] bar = new String[2];
                bar = original.Split('.');
                if (bar[1].Length == 0)
                {
                    return "£ " + bar[0] + ".00";
                }
                else if (bar[1].Length == 1)
                {
                    return "£" + bar[0] + "." + bar[1] + "0";
                }
                else if (bar[1].Length == 2)
                {
                    return "£" + bar[0] + "." + bar[1];
                }
                else
                {
                    return "£" + bar[0] + "." + bar[1].Substring(0, 2);
                }
            }
            else
            {
                return "£" + original;
            }
        }

        //======================Viewer Properties============================
     
        //used on back button on any viewer but the event viewer
        protected void UnhideEventViewer(EventViewer _temp)
        {
            if(!_temp.Visible)
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
            
            switch(type.ToLower())
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

        //======================Initializer Properties============================
        protected void ShowInitializer(string type, EventInitializer _temp, Event _eventData)
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
    }
}
