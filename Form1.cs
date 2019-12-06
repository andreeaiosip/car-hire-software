using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace CarsDatabase
{
    public partial class frmCars : Form

    {
        public void showmyData(int recordPositionDisplay)
        {
            vehRegNoBox.Text = dt.Rows[recordPositionDisplay]["VehicleRegNo"].ToString();
            makeBox.Text = dt.Rows[recordPositionDisplay]["Make"].ToString();
            engineBox.Text = dt.Rows[recordPositionDisplay]["EngineSize"].ToString();
            dateRgBox.Text = dt.Rows[recordPositionDisplay]["DateRegistered"].ToString();
            rentPerDayBox.Text = dt.Rows[recordPositionDisplay]["RentalPerDay"].ToString();
        }

        static string mydataSource = "Data Source=C:\\Users\\Client 0819\\Documents\\1Assigment2\\CarsDatabase\\hire.db";
        public SQLiteConnection conn = new SQLiteConnection(mydataSource);

        DataTable dt = new DataTable();
        int totalRecords = 0;
        int recordCounter = 0;

        public frmCars()
        {
            InitializeComponent();
        }

        private void rentperdaybox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validates text box for numbers only
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if (e.KeyChar == (char)13)
            {
                rentPerDayBox.Text = string.Format("{0:n0}", double.Parse(rentPerDayBox.Text));
            }
        }

        private void frmCars_Load(object sender, EventArgs e)
        {

            string mySQL = $@"SELECT * 
                            FROM tblCar 
                            ORDER by VehicleRegNo";
            conn.Open();
            SQLiteDataAdapter Da = new SQLiteDataAdapter(mySQL, conn);
            
            Da.Fill(dt);
            Da.Dispose();
            conn.Close();
            foreach (DataRow row in dt.Rows)
            {
                vehRegNoBox.Text = row["VehicleRegNo"].ToString();
                makeBox.Text = row["Make"].ToString();
                engineBox.Text = row["EngineSize"].ToString();
                dateRgBox.Text = row["DateRegistered"].ToString();
                rentPerDayBox.Text = row["RentalPerDay"].ToString();

                if (row["Available"].ToString() == "1")
                {
                    availCheckBox.Checked = true;
                }
                else
                {
                    availCheckBox.Checked = false;
                }

                break;
            }

            totalRecords = dt.Rows.Count;
            boxCounter.Text = (recordCounter + 1) + " OF " + totalRecords;
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string mySQL = $@"INSERT INTO tblCar ('VehicleRegNo','Make','EngineSize', 'DateRegistered','RentalPerDay', 'Available') VALUES 
                    ('{vehRegNoBox.Text}',
                    '{makeBox.Text}',
                    '{engineBox.Text}',
                    '{dateRgBox.Text}',
                    '{rentPerDayBox.Text}',
                    '{availCheckBox.Checked}');";


            rtb.Text = mySQL;

            conn.Open();
            SQLiteCommand sQLCmd = new SQLiteCommand(mySQL, conn);
            sQLCmd.ExecuteNonQuery();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string mySQL = $@"DELETE
                           FROM tblCar
                           WHERE VehicleRegNo = 
                          '{vehRegNoBox.Text}'";

            rtb.Text = mySQL;
            conn.Open();
            SQLiteCommand sQLCmd = new SQLiteCommand(mySQL, conn);
            sQLCmd.ExecuteNonQuery();
            conn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int checkBoxAvailable = 0;

            if (availCheckBox.Checked)
            {
                checkBoxAvailable = 1;
            }


            string mySQL = $@"UPDATE
                           tblCar
                           SET 
                                Make = '{makeBox.Text}',
                                EngineSize = '{engineBox.Text}',
                                DateRegistered = '{dateRgBox.Text}',
                                RentalPerDay = '{rentPerDayBox.Text}',
                                Available = '{checkBoxAvailable}'
                           WHERE VehicleRegNo = '{vehRegNoBox.Text}' ";

            rtb.Text = mySQL;
            conn.Open();
            SQLiteCommand sQLCmd = new SQLiteCommand(mySQL, conn);
            sQLCmd.ExecuteNonQuery();
            conn.Close();
        }


        // Open the search window form
        private void btnSearch_Click(object sender, EventArgs e)
        {


            taskAsearch newForm = new taskAsearch();
            newForm.Show();

        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {
           if (recordCounter < (totalRecords - 1)) { 
               recordCounter ++;
               boxCounter.Text = (recordCounter + 1) + " OF " + totalRecords;

                showmyData(recordCounter);
          }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            recordCounter = 0;
            boxCounter.Text = (recordCounter + 1) + " OF " + totalRecords;

            showmyData(recordCounter);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            recordCounter = totalRecords - 1;
            boxCounter.Text = (recordCounter + 1) + " OF " + totalRecords;

            showmyData(recordCounter);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   
            conn.Close();
            Application.Exit();
  
        }
    }
    
}
