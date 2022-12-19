using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
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

namespace DevExFinalSE
{
    public partial class Revenue : DevExpress.XtraEditors.XtraForm
    {
        public Revenue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(local)\SQLEXPRESS;Initial Catalog=test_se2;Integrated Security=True");
            conn.Open();
            String q = "Select SUM(dt.Price) as total From OrderDetail dt join Orders o on dt.OrderID = o.OrderID Where MONTH(o.OrderDate) = '" + txtMonth.Text + "' Group by Month(o.OrderDate) order by Month(o.OrderDate)";
            SqlDataAdapter da = new SqlDataAdapter(q, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                txtRevenue.Text = dt.Rows[0]["total"].ToString().Trim();
            }
            else
            {
              
            }
            conn.Close();   
        }

        private void Revenue_Load(object sender, EventArgs e)
        {

        }
    }
}