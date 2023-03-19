using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Search_Destination__TVM_
{
    public partial class SelectTripForm : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        DataTable resTable;

        public SelectTripForm()
        {
            InitializeComponent();
        }

        private void SelectTripForm_Load(object sender, EventArgs e)
        {
            string selectedTripId = SearchDestinationForm.curTripId;

            string s = "initial catalog = Trips_Manage; data source = DESKTOP-LESN61O; integrated security = true;";
            cn = new SqlConnection(s);
            cn.Open();

            string sql = "select T.tripId as ID, D.destiantionName as Destination, Trans.transportType as Transport, Trans.transportNumber as 'Vehicle No.', T.price as Price, T.startTime as 'Start Time', T.endTime as 'End time', (select D1.destiantionName from Destination D1 where D1.destinationId = T.pickupLocationId) as 'Pick-up location'" +
                            " from Trip T, Destination D, Transport Trans" +
                            " where T.tripId = '" + selectedTripId + "'" +
                                    " and D.destinationId = T.destinationId" +
                                    " and T.transportId = Trans.transportId";

            data = new SqlDataAdapter(sql, cn);
            resTable = new DataTable();
            data.Fill(resTable);

            tripSelectedGrd.DataSource = resTable;
        }

        private void creditCardBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successfully", "Congratulations!");
        }

        private void qrCodeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment successfully", "Congratulations!");
        }
    }
}
