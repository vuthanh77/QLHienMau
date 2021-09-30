using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_HienMau
{
    public partial class FormThongKeSLDVMDaSD : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormThongKeSLDVMDaSD()
        {
            InitializeComponent();
        }

        private void FormThongKeSLDVMDaSD_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by hanhtrinh_id) as [STT], hanhtrinh_id," +
                "diadiemluutru, thoigianluutru, diadiemsd, thoigiansd, mau_id from hanhtrinhdvm", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_htm.DataSource = tb;

            SqlCommand cmd1 = new SqlCommand("select count(hanhtrinh_id) as tong from hanhtrinhdvm", con);
            con.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                txt_sum.Text = dr["tong"].ToString();
            }
            dr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
