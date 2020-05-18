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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.employeeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 9) //View Line Items button clicked
            {

                
                //Get the ID of the selected invoice
                int i = e.RowIndex;                 //get index of current row of data grid control

                // Get an instance of a DataGridViewRow object using the above index
                DataGridViewRow row = employeesDataGridView.Rows[i];
                //Get cell(column) instance containing InvoiceID which is the first column(index is 0)
                DataGridViewCell cell = row.Cells[1];
                DataGridViewCell cell2 = row.Cells[2];
                DataGridViewCell cellId = row.Cells[0];
                // Get value from cell
                string name = (string)cell.Value +" "+ (string)cell2.Value;
                
                // Display the Line Items form passing selected invoiceID to public variable InvoiceID
                // located on Line Items form
                frmShiftDetails shiftDetails = new frmShiftDetails();
                shiftDetails.name = name;
                shiftDetails.lblName.Text = name;
                shiftDetails.employeeId = (int)cellId.Value;
              
                shiftDetails.Show();

            }
            else if (e.ColumnIndex == 10)
            {
                int i = e.RowIndex;
                DataGridViewRow rowSeleted = employeesDataGridView.Rows[i];
                DataGridViewCell cell = rowSeleted.Cells[0];
                int employeeId = (int)cell.Value;
                //Must also delete the shift associated with specific employee id
                employeesTableAdapter.FillByDeleteEmployee(employeeDataSet.Employees, employeeId);
                frmShiftDetails deleteShift=new frmShiftDetails();
                deleteShift.shiftsTableAdapter.FillByDeleteShiftEmployee(employeeDataSet.Shifts, employeeId);
                this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo employee = new frmEmployeeInfo();
            employee.ShowDialog();
            if(employee.add)
            {
                
                employeesTableAdapter.FillByInsertEmployee(employeeDataSet.Employees,employee.txtFirstName.Text, employee.txtLastname.Text, employee.txtPhoneNumber.Text,
                    employee.txtEmail.Text, employee.txtAddress.Text, employee.txtCity.Text, employee.txtState.Text, int.Parse(employee.txtZipCode.Text));
                //Reload data
                this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);
            }
           
            
        }

        private void btnFirstName_Click(object sender, EventArgs e)
        {
            employeesTableAdapter.FillByFirstName(employeeDataSet.Employees, txtSearch.Text);
        }

        private void btnLastName_Click(object sender, EventArgs e)
        {
            employeesTableAdapter.FillByLastName(employeeDataSet.Employees, txtSearch.Text);
        }

        private void btnAllEmployees_Click(object sender, EventArgs e)
        {
            this.employeesTableAdapter.Fill(this.employeeDataSet.Employees);
        }
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            sfdSave.Filter = "CSV (*.csv)|*.csv|Excel (*.xls)|*.xls|All files (*.*)|*.*";
            //Works finally
            if (sfdSave.ShowDialog()==DialogResult.OK)
            {
                using (Stream s = File.Open(sfdSave.FileName, FileMode.CreateNew))
                    using (StreamWriter sw=new StreamWriter(s))
                {
                    int allRows;
                    int allColumns;
                    allRows = employeesDataGridView.RowCount;
                    allColumns = employeesDataGridView.ColumnCount - 3;
                    DataGridViewRow rows;
                    DataGridViewCell columns;
                    string data;
                    int columnCount=0;
                    sw.WriteLine("First name,Last name,Phone,Email,Address,City,State,Zipcode");
                    for (int i=0;i<allRows;i++)
                    {
                        rows = employeesDataGridView.Rows[i];
                        
                        //for every time you go through a row you'll have to go through all the columns
                       for(int ix=0;ix<allColumns;ix++)
                        {
                            columns = rows.Cells[columnCount+1];
                            data = columns.Value.ToString();
                            sw.Write(data+",");
                            if(columnCount==allColumns)
                                {
                                    columnCount = 0;
                                }
                            columnCount++;
                        }
                        columnCount = 0;
                        sw.WriteLine();


                    }

                }
            }
        }
    }
}
