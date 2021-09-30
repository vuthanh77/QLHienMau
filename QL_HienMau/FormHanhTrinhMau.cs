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
    public partial class FormHanhTrinhMau : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormHanhTrinhMau()
        {
            InitializeComponent();
        }

        public void load_htID()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from hanhtrinhdvm", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
           grv_htdvm.DataSource = tb;
            grv_htdvm.Refresh();
        }

        public void load_IDmau()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from DONVIMAU", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            DataRow r = tb.NewRow();
            r["mau_ID"] = " ";
            tb.Rows.InsertAt(r, 0);
            cmb_mauID.DataSource = tb;
            cmb_mauID.ValueMember = "mau_ID";
        }
        private void bt_insert_Click(object sender, EventArgs e)
        {
            string p_maht = txt_htID.Text;
            string p_ddlt = txt_diadiemlt.Text;
            DateTime p_timelt = dt_lt.Value;
            string p_ddsd = txt_diadiemsd.Text;
            DateTime p_timesd = dt_timesd.Value;
            string p_mauID = cmb_mauID.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into hanhtrinhdvm values(N'"+p_maht+"',N'"+p_ddlt+"'," +
                "N'"+p_timelt+"',N'"+p_ddsd+"',N'"+p_timesd+"',N'"+p_mauID+"')", con);
            cmd.ExecuteNonQuery();
            load_htID();
            MessageBox.Show("Thêm thành công!");
        }

        private void FormHanhTrinhMau_Load(object sender, EventArgs e)
        {
            load_htID();
            load_IDmau();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string p_maht = txt_htID.Text;
            string p_ddlt = txt_diadiemlt.Text;
            DateTime p_timelt = dt_lt.Value;
            string p_ddsd = txt_diadiemsd.Text;
            DateTime p_timesd = dt_timesd.Value;
            string p_mauID = cmb_mauID.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("update hanhtrinhdvm set diadiemluutru=N'"+p_ddlt+"', thoigianluutru=N'"+p_timelt+"'," +
                "diadiemsd=N'"+p_ddsd+"', thoigiansd=N'"+p_timesd+"' where hanhtrinh_id=N'"+p_maht+"'", con);
            cmd.ExecuteNonQuery();
            load_htID();
            MessageBox.Show("Sửa thành công!");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string p_maht = txt_htID.Text;
            string p_ddlt = txt_diadiemlt.Text;
            DateTime p_timelt = dt_lt.Value;
            string p_ddsd = txt_diadiemsd.Text;
            DateTime p_timesd = dt_timesd.Value;
            string p_mauID = cmb_mauID.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete hanhtrinhdvm where hanhtrinh_id=N'" + p_maht + "'", con);
            cmd.ExecuteNonQuery();
            load_htID();
            MessageBox.Show("Xóa thành công!");
        }

        private void grv_htdvm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_htID.Text = grv_htdvm.Rows[i].Cells[0].Value.ToString();
            txt_diadiemlt.Text= grv_htdvm.Rows[i].Cells[1].Value.ToString();
            dt_lt.Text= grv_htdvm.Rows[i].Cells[2].Value.ToString();
            txt_diadiemsd.Text= grv_htdvm.Rows[i].Cells[3].Value.ToString();
            dt_timesd.Text= grv_htdvm.Rows[i].Cells[4].Value.ToString();
            cmb_mauID.Text= grv_htdvm.Rows[i].Cells[5].Value.ToString();
            txt_htID.Enabled = false;
            cmb_mauID.Enabled = false;
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_htID.Text = " ";
            txt_diadiemlt.Text = " ";
            txt_diadiemsd.Text = " ";
            txt_htID.Enabled = true;
            cmb_mauID.Enabled = true;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
