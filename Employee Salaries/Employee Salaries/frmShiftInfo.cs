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
    public partial class frmShiftInfo : Form
    {
        public frmShiftInfo()
        {
            InitializeComponent();
        }
        public bool add = false;
       
       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShiftInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                cbInMinutes.Items.Add(i);
                cboOutMinutes.Items.Add(i);
            }
            for(int i=0;i<13;i++)
            {
                cbTimeIn.Items.Add(i);
                cbTimeOut.Items.Add(i);

            }
               
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            add = validateControls();
            int test;
            if(add)
            {

                this.Close();
            }

        }
        private bool validateControls()
        {
            if(cbInAmOrPm.Text=="" || cboOutMinutes.Text == "" ||
                cbDay.Text == "" || cbInMinutes.Text == "" || cbTimeIn.Text == "" ||
                cboOutMinutes.Text=="" || cbIOutAmOrPm.Text=="")
            {
                MessageBox.Show("You can't leave data empty");
                return false;
            }
            int hoursIn, hoursOut;
            hoursIn = int.Parse(cbTimeIn.Text);
            hoursOut = int.Parse(cbTimeOut.Text);
            if(cbInAmOrPm.Text=="AM" && hoursIn>11)//if it is above the am range
            {
                cbInAmOrPm.Text = "PM";
            }
            if (cbIOutAmOrPm.Text == "AM" && hoursOut > 11)//if it is above the am range
            {
                cbIOutAmOrPm.Text = "PM";
            }
            if(hoursIn==0)
            {
                cbInAmOrPm.Text = "AM";
            }
       
            if(hoursOut==0)
            {
                cboOutMinutes.Text ="AM";
            }
           

            if (cbInAmOrPm.Text=="PM" && hoursIn!=12)
            {
                hoursIn += 12;
            }
            if (cbIOutAmOrPm.Text == "PM" &&hoursOut !=12)
            {
                hoursOut += 12;
            }
            int totalHours = hoursOut - hoursIn;
            if(totalHours<0)
            {
                MessageBox.Show("Negative amount of hours is not allowed");
                return false;
            }
            return Validator.IsPresent(txtHourly) && Validator.IsDecimal(txtHourly);
                
        }
    }
}
