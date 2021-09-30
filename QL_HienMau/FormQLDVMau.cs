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
    public partial class FormQLDVMau : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormQLDVMau()
        {
            InitializeComponent();
        }

        public void load_lop()
        {
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from donvimau", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            cmd.Dispose();
            con.Close();
            grv_dvm.DataSource = tb;
            grv_dvm.Refresh();
        }

        private void bt_insert_Click(object sender, EventArgs e)
        {
            string p_mauID = txt_mauID.Text;
            string p_v = cmb_thetich.SelectedItem.ToString();
            //int p_v = Convert.ToInt32(cmb_thetich.SelectedItem);
            DateTime p_ngayhm = dt_ngayhm.Value;
            string p_diadiemhm = txt_ddhm.Text;
            string p_abo = cmb_abo.SelectedItem.ToString();
            string p_rh = cmb_rh.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into donvimau values(N'"+p_mauID+"',N'"+p_v+"'," +
                "N'"+p_ngayhm+"',N'"+p_diadiemhm+"',N'"+p_abo+"',N'"+p_rh+"')", con);
            cmd.ExecuteNonQuery();
            load_lop();
            MessageBox.Show("Thêm thành công!");
        }

        private void grv_dvm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txt_mauID.Text = grv_dvm.Rows[i].Cells[0].Value.ToString();
            cmb_thetich.Text = grv_dvm.Rows[i].Cells[1].Value.ToString();
            dt_ngayhm.Text = grv_dvm.Rows[i].Cells[2].Value.ToString();
            txt_ddhm.Text = grv_dvm.Rows[i].Cells[3].Value.ToString();
            cmb_abo.Text = grv_dvm.Rows[i].Cells[4].Value.ToString();
            cmb_rh.Text = grv_dvm.Rows[i].Cells[5].Value.ToString();
            txt_mauID.Enabled = false;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            string p_mauID = txt_mauID.Text;
            string p_v = cmb_thetich.SelectedItem.ToString();       
            DateTime p_ngayhm = dt_ngayhm.Value;
            string p_diadiemhm = txt_ddhm.Text;
            string p_abo = cmb_abo.SelectedItem.ToString();
            string p_rh = cmb_rh.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("update donvimau set thetich=N'"+p_v+"'," +
                "ngayhm=N'"+p_ngayhm+"',diadiemhm=N'"+p_diadiemhm+"', abo=N'"+p_abo+"',rh=N'"+p_rh+"' where mau_ID=N'"+p_mauID+"'", con);
            cmd.ExecuteNonQuery();
            load_lop();
            MessageBox.Show("Sửa thành công!");
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            string p_mauID = txt_mauID.Text;
            string p_v = cmb_thetich.SelectedItem.ToString();
            DateTime p_ngayhm = dt_ngayhm.Value;
            string p_diadiemhm = txt_ddhm.Text;
            string p_abo = cmb_abo.SelectedItem.ToString();
            string p_rh = cmb_rh.SelectedItem.ToString();

            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("delete donvimau where mau_ID=N'"+p_mauID+"'", con);
            cmd.ExecuteNonQuery();
            load_lop();
            MessageBox.Show("Xóa thành công!");
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            txt_mauID.Text = " ";
            txt_ddhm.Text = " ";
            txt_mauID.Enabled = true;
        }

        private void FormQLDVMau_Load(object sender, EventArgs e)
        {
            load_lop();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
