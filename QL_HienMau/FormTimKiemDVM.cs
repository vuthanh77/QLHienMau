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
    public partial class FormTimKiemDVM : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";

        public FormTimKiemDVM()
        {
            InitializeComponent();
        }

        public void load_mauID()
        {
            string p_mauID = txt_mauID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select donvimau.* from DONVIMAU where mau_ID=N'" + p_mauID + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_dvm.DataSource = tb;
            grv_dvm.Refresh();
        }

        public void load_resultID()
        {
            string p_mauID = txt_mauID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select ketqua.* from KETQUA,donvimau where donvimau.mau_id=ketqua.mau_id and donvimau.mau_id=N'"+p_mauID+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_kqdvm.DataSource = tb;
            grv_kqdvm.Refresh();
        }

        public void load_htID()
        {
            string p_mauID = txt_mauID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select hanhtrinhdvm.* from hanhtrinhdvm, donvimau where donvimau.mau_id=hanhtrinhdvm.mau_id and DONVIMAU.mau_id=N'" + p_mauID + "'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_htm.DataSource = tb;
            grv_htm.Refresh();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string p_mauID = txt_mauID.Text;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from donvimau where mau_ID=N'" + p_mauID + "'", con);
            cmd.ExecuteNonQuery();          
            load_mauID();
            load_resultID();
            load_htID();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
