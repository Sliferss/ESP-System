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
    public partial class SalesCompleteMessage : BaseForm
    {
        public Event eventRef;
        public ModeSelection parentRef;
        public SalesCompleteMessage(Event _eventRef, ModeSelection _parentRef)
        {
            eventRef = _eventRef;
            parentRef = _parentRef;
            InitializeComponent();
        }

        private void ProceedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            parentRef.UpdateEvent(eventRef);
            parentRef.Show();
            this.Close();
        }
    }
}
