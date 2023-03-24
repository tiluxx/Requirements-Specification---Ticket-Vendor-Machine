using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Destination__TVM_
{
    public partial class SearchDestinationForm : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        DataTable resTable;
        public static string curTripId;

        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        public SearchDestinationForm()
        {
            InitializeComponent();
        }

        private void SearchDestinationForm_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(strConn);
            cn.Open();
        }

        void showGRD(string sql)
        {
            data = new SqlDataAdapter(sql, cn);
            resTable = new DataTable();
            data.Fill(resTable);

            if (resTable != null && resTable.Rows.Count > 0)
            {
                resultGrd.DataSource = resTable;
            } else
            {
                resTable.Clear();
                resultGrd.DataSource = resTable;
                MessageBox.Show("Your destination is invalid or unsupported at the current time.", "We are sorry!");
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            string inputLocation = dropOffLocationTextBox.Text;
            if (string.IsNullOrEmpty(inputLocation))
            {
                MessageBox.Show("You have to enter your destination!", "Warning");
            } else
            {
                string sql = "select T.tripId as ID, D.destiantionName as Destination, Trans.transportType as Transport, Trans.transportNumber as 'Vehicle No.', T.price as Price, T.startTime as 'Start Time', T.endTime as 'End time', (select D1.destiantionName from Destination D1 where D1.destinationId = T.pickupLocationId) as 'Pick-up location'" +
                            " from Trip T, Destination D, Transport Trans" +
                            " where(D.destiantionName like N'%" + inputLocation + "%' or D.detailAddress like N'%" + inputLocation + "%')" +
                                    " and D.destinationId = T.destinationId" +
                                    " and T.transportId = Trans.transportId" +
                                    " and T.condition = 'available'";
                showGRD(sql);
            }
        }

        private void resultGrd_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SelectTripForm selectTripForm = new SelectTripForm();
            curTripId = resultGrd.CurrentRow.Cells[0].Value.ToString();
            selectTripForm.Show();
        }
    }
}
