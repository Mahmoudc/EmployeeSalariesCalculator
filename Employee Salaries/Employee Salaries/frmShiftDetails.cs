using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Employee_Salaries
{
    public partial class frmShiftDetails : Form
    {
        public frmShiftDetails()
        {
            InitializeComponent();
        }
        public int employeeId;
        public string name;

        private void shiftsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.shiftsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void frmShiftDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Shifts' table. You can move, or remove it, as needed.
            this.shiftsTableAdapter.Fill(this.employeeDataSet.Shifts, employeeId);
            calculatePay();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmShiftInfo shiftInfo = new frmShiftInfo();
            shiftInfo.ShowDialog();
            decimal hoursIn, hoursOut;
            decimal minutesIn, minutesOut;
            decimal hoursWorked;
            string hoursInString, hoursOutString;
            
            if (shiftInfo.add)
            {
                hoursIn = decimal.Parse(shiftInfo.cbTimeIn.Text);
                hoursOut = decimal.Parse(shiftInfo.cbTimeOut.Text);
                minutesIn = decimal.Parse(shiftInfo.cbInMinutes.Text);
                minutesOut = decimal.Parse(shiftInfo.cboOutMinutes.Text);
                
             
                hoursInString = hoursIn + ":" + minutesIn+":"+"00";
                hoursOutString = hoursOut + ":" + minutesOut + ":" + "00";
                minutesIn = minutesIn / 60;
                minutesOut = minutesOut / 60;
                hoursIn = hoursIn + minutesIn;
                hoursOut = hoursOut + minutesOut;
               
                hoursWorked = hoursOut - hoursIn;
                decimal hourlyRate = decimal.Parse(shiftInfo.txtHourly.Text);
                decimal totalPay = hourlyRate * hoursWorked;
                totalPay = Math.Round(totalPay, 2);
                hoursWorked = Math.Round(hoursWorked, 2);
                shiftsTableAdapter.FillByInsertShift(employeeDataSet.Shifts, employeeId, shiftInfo.cbDay.Text, hoursInString, hoursOutString,
                    hourlyRate, hoursWorked, totalPay, shiftInfo.dateTimePicker1.Text);
                this.shiftsTableAdapter.Fill(this.employeeDataSet.Shifts, employeeId);
                //pay adjust according to amount
                calculatePay();
            }
            
        }

        private void shiftsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.ColumnIndex==8)
            {
                int selected = e.RowIndex;
                DataGridViewRow data = shiftsDataGridView.Rows[selected];
                DataGridViewCell cell = data.Cells[0];
                int deleteShift = (int)cell.Value;
                shiftsTableAdapter.FillByDeleteShift(employeeDataSet.Shifts, deleteShift);
                shiftsTableAdapter.Fill(employeeDataSet.Shifts, employeeId);
                calculatePay();

            }
        }
        private void calculatePay()
        {
            int rowNumber = shiftsDataGridView.RowCount;
            DataGridViewRow rows;
            DataGridViewCell cell;
            decimal totalPay = 0;
            for (int i = 0; i < rowNumber; i++)
            {
                rows = shiftsDataGridView.Rows[i];
                cell = rows.Cells[7];
                totalPay += (decimal)cell.Value;

            }
            lblTotalPay.Text = totalPay.ToString("c");
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSave.Filter = "CSV (*.csv)|*.csv|Excel (*.xls)|*.xls|All files (*.*)|*.*";
            //Works finally
            if (sfdSave.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfdSave.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    int allRows;
                    int allColumns;
                    allRows = shiftsDataGridView.RowCount;
                    allColumns = shiftsDataGridView.ColumnCount-2;
                    DataGridViewRow rows;
                    DataGridViewCell columns;
                    string data;
                    int columnCount = 0;
                   
                    
                    sw.WriteLine("Name:,"+ name);
                    sw.WriteLine("Date, Day, Time in, Time out, Hourly rate, Hour worked, Total pay");
                    for (int i = 0; i < allRows; i++)
                    {
                        rows = shiftsDataGridView.Rows[i];

                        //for every time you go through a row you'll have to go through all the columns
                        for (int ix = 0; ix < allColumns; ix++)
                        {
                            columns = rows.Cells[columnCount + 1];
                            data = columns.Value.ToString();
                            if(columnCount == 6)
                            {
                                sw.Write("$" + data.ToString());
                               
                            }
                            else 
                            {
                                sw.Write(data + ",");
                            }
                           
                            if (columnCount == allColumns)
                            {
                                columnCount = 0;
                            }
                            columnCount++;
                        }
                        columnCount = 0;
                        sw.WriteLine();


                    }
                    sw.WriteLine();
                    calculatePay();
                    sw.Write("Total earnings:" +",,,,,,"+lblTotalPay.Text.ToString());

                }
            }
            
        }
    }
  }

