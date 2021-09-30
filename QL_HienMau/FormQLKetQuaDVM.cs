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
    public partial class FormQLKetQuaDVM : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormQLKetQuaDVM()
        {
            InitializeComponent();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void load_resultMauID()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ketqua", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_kqdvm.DataSource = tb;
            grv_kqdvm.Refresh();
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

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string p_result_mauID = txt_resultMauID.Text;
            string p_ktbt = cmb_ktbt.SelectedItem.ToString();
            string p_hbsag = cmb_hbsag.SelectedItem.ToString();
            string p_hcv = cmb_antihcv.SelectedItem.ToString();
            string p_hiv = cmb_hiv.SelectedItem.ToString();
            string p_giangmai = cmb_giangmai.SelectedItem.ToString();
            string p_mauID = cmb_mauID.SelectedValue.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ketqua values(N'"+p_result_mauID+"',N'"+p_ktbt+"'," +
                "N'"+p_hbsag+"',N'"+p_hcv+"',N'"+p_hiv+"',N'"+p_giangmai+"',N'"+p_mauID+"')", con);
            cmd.ExecuteNonQuery();
            load_resultMauID();
            MessageBox.Show("Thêm thành công!");
        }

        private void FormQLKetQuaDVM_Load(object sender, EventArgs e)
        {
            load_resultMauID();
            load_mauID();
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string p_result_mauID = txt_resultMauID.Text;
            string p_ktbt = cmb_ktbt.SelectedItem.ToString();
            string p_hbsag = cmb_hbsag.SelectedItem.ToString();
            string p_hcv = cmb_antihcv.SelectedItem.ToString();
            string p_hiv = cmb_hiv.SelectedItem.ToString();
            string p_giangmai = cmb_giangmai.SelectedItem.ToString();
            string p_mauID = cmb_mauID.SelectedValue.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("update ketqua set khangthebatthuong=N'" + p_ktbt + "',hbsag=" +
                "N'" + p_hbsag + "',antihcv=N'" + p_hcv + "',hivag_ab=N'" + p_hiv + "',giangmai=N'" + p_giangmai + "'" +
                "where result_mauid=N'"+p_result_mauID+"'", con);
            cmd.ExecuteNonQuery();
            load_resultMauID();
            MessageBox.Show("Sửa thành công!");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string p_result_mauID = txt_resultMauID.Text;
            string p_ktbt = cmb_ktbt.SelectedItem.ToString();
            string p_hbsag = cmb_hbsag.SelectedItem.ToString();
            string p_hcv = cmb_antihcv.SelectedItem.ToString();
            string p_hiv = cmb_hiv.SelectedItem.ToString();
            string p_giangmai = cmb_giangmai.SelectedItem.ToString();
            string p_mauID = cmb_mauID.SelectedValue.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete ketqua where result_mauid=N'" + p_result_mauID + "'", con);
            cmd.ExecuteNonQuery();
            load_resultMauID();
            MessageBox.Show("Xóa thành công!");
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_resultMauID.Text = " ";
            txt_resultMauID.Enabled = true;
            cmb_mauID.Enabled = true;
        }

        private void grv_kqdvm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_resultMauID.Text = grv_kqdvm.Rows[i].Cells[0].Value.ToString();
            cmb_ktbt.Text = grv_kqdvm.Rows[i].Cells[1].Value.ToString();
            cmb_hbsag.Text = grv_kqdvm.Rows[i].Cells[2].Value.ToString();
            cmb_antihcv.Text = grv_kqdvm.Rows[i].Cells[3].Value.ToString();
            cmb_hiv.Text = grv_kqdvm.Rows[i].Cells[4].Value.ToString();
            cmb_giangmai.Text = grv_kqdvm.Rows[i].Cells[5].Value.ToString();
            cmb_mauID.Text = grv_kqdvm.Rows[i].Cells[6].Value.ToString();
            txt_resultMauID.Enabled = false;
            cmb_mauID.Enabled = false;
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
