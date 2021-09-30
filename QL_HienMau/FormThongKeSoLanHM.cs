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
    public partial class FormThongKeSoLanHM : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormThongKeSoLanHM()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void load_slhm()
        {
            string P_nameid = txt_nameid.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by donvimau.mau_id) as [STT], name_id, hoten, ngaysinh, donvimau.mau_id, thetich, ngayhm, diadiemhm, abo, rh " +
                "from donvimau, nguoihm where name_id = N'"+P_nameid+"' and nguoihm.mau_id = donvimau.mau_id", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_slhm.DataSource = tb;
            grv_slhm.Refresh();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormThongKeSoLanHM_Load(object sender, EventArgs e)
        {
            load_slhm();
            /*string P_nameid = txt_nameid.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select count(name_id) as tong" +
                " from donvimau, nguoihm where name_id = N'" + P_nameid + "' and nguoihm.mau_id = donvimau.mau_id", con);           
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                txt_sum.Text = dr["tong"].ToString();
            }
            dr.Close();*/
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            string P_nameid = txt_nameid.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by donvimau.mau_id) as [STT], name_id, hoten, ngaysinh, donvimau.mau_id, thetich, ngayhm, diadiemhm, abo, rh " +
                "from donvimau, nguoihm where name_id = N'" + P_nameid + "' and nguoihm.mau_id = donvimau.mau_id", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            load_slhm();
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select count(name_id) as tong" +
                " from donvimau, nguoihm where name_id = N'" + P_nameid + "' and nguoihm.mau_id = donvimau.mau_id", con);
            SqlDataReader dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                txt_sum.Text = dr["tong"].ToString();
            }
            dr.Close();
        }
    }
}
