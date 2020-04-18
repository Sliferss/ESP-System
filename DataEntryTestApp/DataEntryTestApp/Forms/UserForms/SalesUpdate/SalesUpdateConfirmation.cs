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
    public partial class SalesUpdateConfirmation : BaseForm
    {
        private Event eventRef;
        private ModeSelection parentRef;

        //copy constructor
        public SalesUpdateConfirmation(Event _event, ModeSelection _parentRef)
        {
            eventRef = _event;
            parentRef = _parentRef;
            InitializeComponent();
        }

        //goes back to the mode form
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentRef.Show();
            this.Close();
        }

        //opens store sales menu, from that onward you cannot close the window until input is complete
        private void ProceedButton_Click(object sender, EventArgs e)
        {
            StoreSales temp = new StoreSales(eventRef, parentRef);
            this.Hide();
            temp.ShowDialog();
            this.Close();
        }
    }
}
