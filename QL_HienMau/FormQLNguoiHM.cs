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
    public partial class FormQLNguoiHM : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormQLNguoiHM()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        public void load_nguoiHM()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from nguoihm", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_nhm.DataSource = tb;
            grv_nhm.Refresh();

        }

        public void load_mauID()
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

        public void load_resultID()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from KETQUA", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            DataRow r = tb.NewRow();
            r["RESULT_MAUID"] = " ";
            tb.Rows.InsertAt(r, 0);
            cmb_resultID.DataSource = tb;
            cmb_resultID.ValueMember = "RESULT_MAUID";
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
            DataRow r = tb.NewRow();
            r["hanhtrinh_ID"] = " ";
            tb.Rows.InsertAt(r, 0);
            cmb_htID.DataSource = tb;
            cmb_htID.ValueMember = "hanhtrinh_ID";
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string p_nameID = txt_nameID.Text;
            string p_hoten = txt_hoten.Text;
            DateTime p_ns = dtp_ns.Value;
            string p_gt = cmb_gt.SelectedItem.ToString();
            string p_dc = txt_dc.Text;
            double p_weight = Convert.ToDouble(txt_weight.Text);
            string p_mauID = cmb_mauID.SelectedValue.ToString();
            string p_resultID = cmb_resultID.SelectedValue.ToString();
            string p_htID = cmb_htID.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into nguoihm values(N'"+p_nameID+"',N'"+p_hoten+"'," +
                "N'"+p_ns+"',N'"+p_gt+"',N'"+p_dc+"',N'"+p_weight+"',N'"+p_mauID+"',N'"+p_resultID+"',N'"+p_htID+"')", con);
            cmd.ExecuteNonQuery();
            load_nguoiHM();
            MessageBox.Show("Thêm thành công!");

        }

        private void FormQLNguoiHM_Load(object sender, EventArgs e)
        {
            load_mauID();
            load_resultID();
            load_htID();
            load_nguoiHM();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string p_nameID = txt_nameID.Text;
            string p_hoten = txt_hoten.Text;
            DateTime p_ns = dtp_ns.Value;
            string p_gt = cmb_gt.SelectedItem.ToString();
            string p_dc = txt_dc.Text;
            double p_weight = Convert.ToDouble(txt_weight.Text);
            string p_mauID = cmb_mauID.SelectedValue.ToString();
            string p_resultID = cmb_resultID.SelectedValue.ToString();
            string p_htID = cmb_htID.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("update nguoihm set hoten=N'"+p_hoten+"', ngaysinh=N'"+p_ns+"'," +
                "gioitinh=N'"+p_gt+"', diachi=N'"+p_dc+"',cannang=N'"+p_weight+"', result_mauid=N'"+p_resultID+"', hanhtrinh_id=N'"+p_htID+"' where mau_id=N'"+p_mauID+"'", con);
            cmd.ExecuteNonQuery();
            load_nguoiHM();
            MessageBox.Show("Sửa thành công!");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string p_nameID = txt_nameID.Text;
            string p_hoten = txt_hoten.Text;
            DateTime p_ns = dtp_ns.Value;
            string p_gt = cmb_gt.SelectedItem.ToString();
            string p_dc = txt_dc.Text;
            double p_weight = Convert.ToDouble(txt_weight.Text);
            string p_mauID = cmb_mauID.SelectedValue.ToString();
            string p_resultID = cmb_resultID.SelectedValue.ToString();
            string p_htID = cmb_htID.SelectedValue.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete nguoihm where name_id=N'" + p_nameID + "'", con);
            cmd.ExecuteNonQuery();
            load_nguoiHM();
            MessageBox.Show("Xóa thành công!");
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_nameID.Text = " ";
            txt_hoten.Text = " ";
            txt_dc.Text = " ";
            txt_weight.Text = " ";
            txt_nameID.Enabled = true;
            cmb_mauID.Enabled = true;
            cmb_resultID.Enabled = true;
            cmb_htID.Enabled = true;
        }

        private void grv_nhm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_nameID.Text = grv_nhm.Rows[i].Cells[0].Value.ToString();
            txt_hoten.Text = grv_nhm.Rows[i].Cells[1].Value.ToString();
            dtp_ns.Text = grv_nhm.Rows[i].Cells[2].Value.ToString();
            cmb_gt.Text = grv_nhm.Rows[i].Cells[3].Value.ToString();
            txt_dc.Text = grv_nhm.Rows[i].Cells[4].Value.ToString();
            txt_weight.Text = grv_nhm.Rows[i].Cells[5].Value.ToString();
            cmb_mauID.Text = grv_nhm.Rows[i].Cells[6].Value.ToString();
            cmb_resultID.Text = grv_nhm.Rows[i].Cells[7].Value.ToString();
            cmb_htID.Text = grv_nhm.Rows[i].Cells[8].Value.ToString();
            txt_nameID.Enabled = false;
            cmb_mauID.Enabled = false;
            //cmb_resultID.Enabled = false;
            //cmb_htID.Enabled = false;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {

        }

        private void cmb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
