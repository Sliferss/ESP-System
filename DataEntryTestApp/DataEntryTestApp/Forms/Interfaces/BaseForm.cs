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

        //inserts single item into list box
        protected void ListBoxInsert(ListBox _target, string _foo)
        {
            _target.Items.Add(_foo);
        }

        //inserts list into list box
        protected void ListBoxsListInsert(ListBox _target, List<string> _list)
        {
            foreach(string item in _list)
            {
                _target.Items.Add(item);
            }
        }

        //removes specified item from list box
        protected void ListBoxRemove(ListBox _target, string _foo)
        {
            _target.Items.Remove(_foo);
        }

        //removes all items from specified list box
        protected void ListBoxClear(ListBox _target)
        {
            _target.Items.Clear();
        }

        //sets specified error label to message
        protected void SetError(Label _target, string _message)
        {
            _target.Text = "Error: " + _message;
        }

        //clears error Label specified
        protected void ClearErrorLabel(Label _target)
        {
            _target.Text = "";
        }

        //formats any float into a £0.00 format
        protected string FormatNumber(float _foo)
        {
            string original = _foo.ToString();

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

        //checks if list box has item selected
        protected bool CheckItemSelected(ListBox _target)
        {
            if(_target.SelectedIndex == -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //checks if text box is empty
        protected bool CheckTBOccupied(TextBox _target)
        {
            if(_target.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
