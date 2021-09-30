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
    public partial class FormDangNhap : Form
    {
        public static string connect = "Data Source=DESKTOP-FDH5S8E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        //  "Data Source=DESKTOP-FTI6T0E\\SQLEXPRESS;Initial Catalog=QLHM1;Integrated Security=True";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            //DataTable dt = new DataTable();
           // dt = connect.GetData("");
            //string user = txt_user.Text;
          string role = cmb_role.SelectedItem.ToString();
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from login1 where usename=N'" + txt_user.Text + "' and " +
                "pass=N'" + txt_pass.Text + "'and quyen=N'"+role+"'", con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                MessageBox.Show("Đăng nhập vào hệ thống thành công!","Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form f = new FormTrangChu(tb.Rows[0][0].ToString(), tb.Rows[0][1].ToString(), tb.Rows[0][2].ToString());
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!","Xin lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_user.Text = " ";
                txt_pass.Text = " ";
            }
            cmd.Dispose();
            rd.Close();
            con.Close();
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked)
            {
                txt_pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
            }
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
