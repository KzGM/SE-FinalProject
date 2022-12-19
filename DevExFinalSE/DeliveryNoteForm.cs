using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExFinalSE
{
    public partial class DeliveryNoteForm : DevExpress.XtraEditors.XtraForm
    {
        public DeliveryNoteForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow dr;
            for (int i = 0; i < gridview.RowCount; i++)
            {
                dr = gridview.GetDataRow(i);
                if(dr.RowState == DataRowState.Modified)
                {
                    CnClass.exQuery("Update OrderDetail set Status ='" + gridview.GetRowCellValue(i, "Status") + "' Where OrderID = '" + dr["OrderID"] + "'");
                }
                if(dr.RowState == DataRowState.Added)
                {

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DeliveryReport rpt = new DeliveryReport();
            rpt.CreateDocument();
            rpt.ShowPreview();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void DeliveryNoteForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test_se2DataSet2.OrderDetail' table. You can move, or remove it, as needed.
            this.orderDetailTableAdapter.Fill(this.test_se2DataSet2.OrderDetail);
            loadData();
            loadAgentID();
            loadPID();
            loadStatus();
        }
        private void loadData()
        {
            Gridcntr.DataSource = CnClass.GetData("Select od.Status,od.OrderID, o.AgentID, o.OrderDate,od.ProductID,od.Quantity,od.Price From OrderDetail od Join Orders o On od.OrderID = o.OrderId");
        }
        private void loadAgentID()
        {
            lkAgentID.DataSource = CnClass.GetData("Select * From Agent");
            lkAgentID.DisplayMember = "AgentID";
            lkAgentID.ValueMember = "AgentID";
        }
        private void loadPID()
        {
            lkPID.DataSource = CnClass.GetData("Select ProductID,ProductName,Price From Product");
            lkPID.DisplayMember = "ProductID";
            lkPID.ValueMember = "ProductID";
        }
        private void loadStatus()
        {
            lkStatus.DataSource = CnClass.GetData("Select Status From OrderDetail");
            lkStatus.DisplayMember = "Status";
            lkStatus.ValueMember = "Status";
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            Gridcntr.DataSource = CnClass.GetData("select od.Status,dt.OrderID,o.AgentID,o.OrderDate,dt.ProductID,dt.Quantity,dt.Price From Orders o, OrderDetail dt Where dt.OrderID ='" + txtOrderID.Text+"'");
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gridcntr.DataSource = CnClass.GetData("select dt.OrderID,o.AgentID,o.OrderDate,dt.ProductID,dt.Quantity,dt.Price From Orders o, OrderDetail dt Where dt.Status ='" + cbStatus.Text + "'");
        }

    }
}