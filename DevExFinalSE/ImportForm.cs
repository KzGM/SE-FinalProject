using DevExpress.Utils.About;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DevExFinalSE
{
    public partial class ImportForm : DevExpress.XtraEditors.XtraForm
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void ImportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'test_se2DataSet2.Accountant' table. You can move, or remove it, as needed.
            //this.accountantTableAdapter1.Fill(this.test_se2DataSet2.Accountant);
            // TODO: This line of code loads data into the 'test_se2DataSet2.Orders' table. You can move, or remove it, as needed.
            //this.ordersTableAdapter.Fill(this.test_se2DataSet2.Orders);
            // TODO: This line of code loads data into the 'test_se2DataSet2.OrderDetail' table. You can move, or remove it, as needed.
            //this.orderDetailTableAdapter.Fill(this.test_se2DataSet2.OrderDetail);
            //this.accountantTableAdapter.Fill(this.goodManageDataSet.Accountant);
            loadData();
            loadIID();
            loadAccID();
            loadPID();
            gridView1.AddNewRow();
            gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            
        }

        private void datePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtIID_TextChanged(object sender, EventArgs e)
        {
            String q = "select ImportDetail.ID,ImportDetail.TotalPrice,ImportDetail.ImportPrice,Import.ImportDate, ImportDetail.AccountantID, ImportDetail.ProductID, Product.ProductName, ImportDetail.Quantity From ImportDetail Join Import On ImportDetail.IID = Import.IID Join Product On ImportDetail.ProductID = Product.ProductID Where ImportDetail.IID = '" + txtIID.Text+"'";
            gridControl1.DataSource = CnClass.GetData(q); 
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataRow dr;
            dr = gridView1.GetFocusedDataRow();
            if (dr != null)
            {
                if (MessageBox.Show("Do you want to delete this ?", " ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CnClass.exQuery("Delete ImportDetail Where ID ='" + dr["ID"] + "'");
                }
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow dr;
            for (int i = 0;i < gridView1.RowCount; i++)
            {
                try
                {
                    int quantity = Convert.ToInt32(gridView1.GetRowCellValue(i, "Quantity"));
                    int iprice = Convert.ToInt32(gridView1.GetRowCellValue(i, "ImportPrice"));
                    int mul = quantity * iprice;
                dr = gridView1.GetDataRow(i);
                if (dr.RowState == DataRowState.Modified)
                {
                    CnClass.exQuery("Update ImportDetail Set AccountantID ='" + gridView1.GetRowCellValue(i, "AccountantID") + "',ProductID='" + gridView1.GetRowCellValue(i, "ProductID") + "',ImportPrice='" + gridView1.GetRowCellValue(i, "ImportPrice") + "',Quantity='" + gridView1.GetRowCellValue(i, "Quantity") + "'Where ID = '" + dr["ID"] + "'");
                    CnClass.exQuery("Update ImportDetail Set TotalPrice = '"+ mul.ToString() + "' Where ID = '" + dr["ID"] + "'");
                }
                if (dr.RowState == DataRowState.Added)
                {
                    CnClass.exQuery("Insert Into ImportDetail(IID,AccountantID,ProductID,Quantity,ImportPrice,TotalPrice) " +
                        "values ('" + gridView1.GetRowCellValue(i,"IID")+"','" + gridView1.GetRowCellValue(i, "AccountantID") + "','"+gridView1.GetRowCellValue(i, "ProductID")+"','" + gridView1.GetRowCellValue(i, "Quantity")+ "','" + gridView1.GetRowCellValue(i, "ImportPrice") + "','" +0+ "')");
                    CnClass.exQuery("Update ImportDetail Set TotalPrice = '" + mul.ToString() + "' Where ID = '" + dr["ID"] + "'");
                }
                    
                }
                catch (InvalidCastException)
                {

                }
            }
            
            loadData();
        }
        private void loadData()
        {
            gridControl1.DataSource = CnClass.GetData("select ImportDetail.ID,ImportDetail.TotalPrice,ImportDetail.ImportPrice,ImportDetail.IID,Import.ImportDate, ImportDetail.AccountantID, ImportDetail.ProductID, Product.ProductName, ImportDetail.Quantity From ImportDetail Join Import On ImportDetail.IID = Import.IID Join Product On ImportDetail.ProductID = Product.ProductID");
            sumTotal();
        }
        private void loadIID()
        {
            lkIID.DataSource = CnClass.GetData("Select IID From Import");
            lkIID.DisplayMember = "IID";
            lkIID.ValueMember = "IID";
        }
        private void loadAccID()
        {
            lkAccID.DataSource = CnClass.GetData("Select AccountantID From Accountant");
            lkAccID.DisplayMember = "AccountantID";
            lkAccID.ValueMember = "AccountantID";
        }
        private void loadPID()
        {
            lkPID.DataSource = CnClass.GetData("Select ProductID,ProductName From Product");
            lkPID.DisplayMember = "ProductID";
            lkPID.ValueMember = "ProductID";
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CnClass.exQuery("Insert into Import(IID,ImportDate) values('"+txtIID.Text+"','"+datePicker.Text+"')");
            CnClass.exQuery("Update Import Set ImportDate='"+datePicker.Text+"' Where IID = '"+txtIID.Text+"' ");
        }

        private void cbAccID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String q = "select ImportDetail.ID,ImportDetail.TotalPrice,ImportDetail.ImportPrice,Import.ImportDate, ImportDetail.AccountantID, ImportDetail.ProductID, Product.ProductName, ImportDetail.Quantity From ImportDetail Join Import On ImportDetail.IID = Import.IID Join Product On ImportDetail.ProductID = Product.ProductID Where ImportDetail.AccountantID = '" + cbAccID.Text + "'";
            gridControl1.DataSource = CnClass.GetData(q);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void sumTotal()
        {
            int sum = 0;
            DataRow dr;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                sum += Convert.ToInt32(gridView1.GetRowCellValue(i, "TotalPrice"));
            }
            txtTotal.Text = sum.ToString();
        }
    }
}