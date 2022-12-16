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

namespace FinalSE
{
    public partial class ImportForm : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-1OHG4VJT;Initial Catalog=GoodManage;Integrated Security=True");
        
        public ImportForm()
        {
            InitializeComponent();
        }
        private void Display()
        {
            String query = "select ImportDetail.IID, Import.ImportDate, ImportDetail.AccountantID, ImportDetail.ProductID, Product.ProductName, ImportDetail.Quantity From ImportDetail Join Import On ImportDetail.IID = Import.IID Join Product On ImportDetail.ProductID = Product.ProductID";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dtgImport.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }
        private void UpdateDataBase() { 
        



            
        }
        private void InsertinDatabase() { 
            conn.Open();
            SqlDataAdapter Duplicate1= new SqlDataAdapter();
            SqlDataAdapter Duplicate2 = new SqlDataAdapter();
            SqlDataAdapter NonDuplicate = new SqlDataAdapter();
            //Duplicate Command
            Duplicate1.InsertCommand = new SqlCommand("Insert into Import(IID) values(@IID)",conn);
            Duplicate1.InsertCommand.Parameters.Add("@IID", SqlDbType.NVarChar).Value = txtImportID.Text;
            Duplicate2.InsertCommand = new SqlCommand("Insert into Import(ImportDate) values(@ImportDate)",conn);
            Duplicate2.InsertCommand.Parameters.Add("@ImportDate", SqlDbType.Date).Value = txtImportDate.Text;
            try
            {
                Duplicate1.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            try
            {
                Duplicate2.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
            //NonDuplicate
            if (txtAccID.Text.Length > 0 || txtAccID.Text.Length > 0 || txtQuantity.Text.Length > 0 || txtIPrice.Text.Length > 0 || txtPID.Text.Length > 0)
            {
                NonDuplicate.InsertCommand = new SqlCommand("Insert into ImportDetail(IID,AccountantID,ProductID,ImportPrice,Quantity) values (@IID,@ACCID,@PID,@IPrice,@Quantity)",conn);
                NonDuplicate.InsertCommand.Parameters.Add("@IID", SqlDbType.NVarChar).Value = txtImportID.Text;
                NonDuplicate.InsertCommand.Parameters.Add("@ACCID", SqlDbType.NVarChar).Value = txtAccID.Text;
                NonDuplicate.InsertCommand.Parameters.Add("@PID", SqlDbType.NVarChar).Value = txtPID.Text;
                NonDuplicate.InsertCommand.Parameters.Add("@IPrice", SqlDbType.Int).Value = txtIPrice.Text;
                NonDuplicate.InsertCommand.Parameters.Add("Quantity", SqlDbType.Int).Value = txtQuantity.Text;
                NonDuplicate.InsertCommand.ExecuteNonQuery();
            }
            conn.Close();
        }



        private void Import_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void dtgImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           InsertinDatabase();
        }

        private void txtPID_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
