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
    public partial class FormThongKeMauConLai : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormThongKeMauConLai()
        {
            InitializeComponent();
        }

        private void FormThongKeMauConLai_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            string sql = "select row_number() over (order by donvimau.mau_id) as [STT], donvimau.mau_id, thetich, ngayhm, abo, rh" +
                " from donvimau" +
                " full join HANHTRINHDVM on HANHTRINHDVM.MAU_ID = DONVIMAU.MAU_ID" +
                " where DONVIMAU.MAU_ID in (select MAU_ID from donvimau except select MAU_ID from hanhtrinhdvm)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_mauconlai.DataSource = tb;
            SqlCommand cmd1 = new SqlCommand("select count(donvimau.mau_id) as tong" +
                 " from donvimau" +
                 " full join HANHTRINHDVM on HANHTRINHDVM.MAU_ID = DONVIMAU.MAU_ID" +
                 " where DONVIMAU.MAU_ID in (select MAU_ID from donvimau except select MAU_ID from hanhtrinhdvm)", con);
            //cmd.ExecuteNonQuery();
            con.Open();
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                txt_sum.Text = dr["tong"].ToString();
            }
            dr.Close();
            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        /*public string load_sum()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            //string sql = "select count(donvimau.mau_id)" +
              //  " from donvimau" +
                //" full join HANHTRINHDVM on HANHTRINHDVM.MAU_ID = DONVIMAU.MAU_ID" +
                //" where DONVIMAU.MAU_ID =(select MAU_ID from donvimau except select MAU_ID from hanhtrinhdvm)";
            SqlCommand cmd = new SqlCommand("select count(donvimau.mau_id)" +
                " from donvimau" +
                " full join HANHTRINHDVM on HANHTRINHDVM.MAU_ID = DONVIMAU.MAU_ID" +
                " where DONVIMAU.MAU_ID =(select MAU_ID from donvimau except select MAU_ID from hanhtrinhdvm)", con);
            //cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_sum.Text = dr["donvimau.mau_id"].ToString();
            }
            dr.Close();
     
        }*/

        private void txt_sum_TextChanged(object sender, EventArgs e)
        {
            //txt_sum.Text = "test";
            //load_sum();
        }
    }
}
