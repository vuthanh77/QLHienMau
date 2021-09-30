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
    public partial class FormTimKiemNhomMau : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";

        public FormTimKiemNhomMau()
        {
            InitializeComponent();
        }

        public void load_mauID()
        {
            string p_abo = cmb_abo.SelectedItem.ToString();
            string p_rh = cmb_rh.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select row_number() over (order by mau_id) as [STT],* from DONVIMAU where abo = N'" + p_abo+"' and rh = N'"+p_rh+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_dvm.DataSource = tb;
            grv_dvm.Refresh();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            string p_abo = cmb_abo.SelectedItem.ToString();
            string p_rh = cmb_rh.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from DONVIMAU where abo = N'" + p_abo + "' and rh = N'" + p_rh + "'", con);
            cmd.ExecuteNonQuery();
            load_mauID();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
