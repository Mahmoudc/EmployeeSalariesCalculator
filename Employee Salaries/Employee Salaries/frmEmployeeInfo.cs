using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salaries
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }
        public bool add = false;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            add = false;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if(validateControls())
            {
                add = true;
                this.Close();
            }
            else
            {
                add = false;
            }
                
        }
        private bool validateControls() {
        
            return Validator.IsPresent(txtFirstName) && Validator.IsPresent(txtLastname) && Validator.IsPresent(txtEmail) &&
                 Validator.IsPresent(txtPhoneNumber) && Validator.IsPresent(txtState) && Validator.IsPresent(txtZipCode)
                 && Validator.IsPresent(txtCity) && Validator.IsInt32(txtZipCode);
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else 
            {
                e.Handled = true;
            }
        }
    }
}
