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
    public partial class FormThongKeSLNHMTheoNam : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormThongKeSLNHMTheoNam()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /*public void load_nam()
        {
            //string p_nam = cmb_nam.SelectedValue.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from donvimau", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            DataRow r = tb.NewRow();
            r["ngayhm"] = " ";
            tb.Rows.InsertAt(r, 0);
            cmb_nam.DataSource = tb;
            cmb_nam.ValueMember = "ngayhm";
        }*/

        private void bt_tk_Click(object sender, EventArgs e)
        {
            string p_nam = txt_nam.Text;
            //string p_nam = cmb_nam.SelectedValue.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select name_id, hoten, ngaysinh, gioitinh, diachi, nguoihm.mau_id, ngayhm, thetich, diadiemhm" +
                " from nguoihm, donvimau where nguoihm.mau_id = donvimau.mau_id" +
                " and ngayhm like '"+p_nam+"%'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_slnhm.DataSource = tb;

            con.Open();
            SqlCommand cmd1 = new SqlCommand("select count(name_id) as tong" +
                " from donvimau, nguoihm where nguoihm.mau_id = donvimau.mau_id and ngayhm like '" + p_nam + "%'", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                txt_sum.Text = dr["tong"].ToString();
            }
            dr.Close();
        }

        private void FormThongKeSLNHMTheoNam_Load(object sender, EventArgs e)
        {
            //load_nam();
        }
    }
}
