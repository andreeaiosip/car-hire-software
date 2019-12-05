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

        static string mydataSource="Data Source=C:\\Users\\Client 0819\\Dropbox\\CarsDatabase\\hire.db";
        public SQLiteConnection conn = new SQLiteConnection(mydataSource);


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
            DataTable dt = new DataTable();
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
                            WHERE('VehicleRegNo') VALUES (
                            '{vehRegNoBox.Text}'
                        );";

            rtb.Text = mySQL;
                conn.Open();
                SQLiteCommand sQLCmd = new SQLiteCommand(mySQL, conn);
                sQLCmd.ExecuteNonQuery();
                conn.Close();

        }
    }
}

