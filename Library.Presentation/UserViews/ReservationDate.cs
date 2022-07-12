using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace Library.Presentation.UserViews
{
    public partial class ReservationDate : MaterialForm
    {
        public DateTime dateTimeFrom { get; set; }
        public DateTime dateTimeTo { get; set; }
        public ReservationDate()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dateFromPicker.Value;
            DateTime dateTo = dateToPicker.Value;

            if(dateFrom > dateTo)
            {
                MaterialMessageBox.Show("Please enter valid date range");
            }
            else
            {
                this.dateTimeFrom = dateFrom;
                this.dateTimeTo = dateTo;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

    }
}
